using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DeclaraSummary
{
    class Reader
    {

        public Invoice ReadInvoice(string path) {

            Invoice facturaInfo = new Invoice();
            facturaInfo.Details = new List<InvoiceDetail>();
            List<Invoice> invoices = new List<Invoice>();

            try
            {
                XmlDocument doc = new XmlDocument();

                doc.Load(path);
                
                XmlNodeList nodeList = doc.DocumentElement.ChildNodes;

                bool isNotaDeCredito = false;

                if (doc.DocumentElement.Name == "NotaCreditoElectronica") isNotaDeCredito = true;

                foreach (XmlNode node in nodeList)
                {
                    switch (node.Name)
                    {
                        case "NumeroConsecutivo":
                            facturaInfo.Serial = node.InnerText;
                            break;

                        case "FechaEmision":
                            facturaInfo.Date = Convert.ToDateTime(node.InnerText);
                            break;

                        case "Emisor":
                            foreach (XmlNode emisorElement in node.ChildNodes)
                            {
                                if (emisorElement.Name == "Nombre")
                                {
                                    facturaInfo.Emissor = emisorElement.InnerText;
                                }
                            }
                            break;

                        case "Receptor":
                            foreach (XmlNode receptorElement in node.ChildNodes)
                            {
                                if (receptorElement.Name == "Nombre")
                                {
                                    facturaInfo.Customer = receptorElement.InnerText;
                                }
                            }
                            break;

                        case "DetalleServicio":
                            foreach (XmlNode linea in node.ChildNodes)
                            {
                                InvoiceDetail detailLine = new InvoiceDetail();
                                detailLine.Exoneration = 0;
                                detailLine.ExonRate = 0;

                                foreach (XmlNode detalle in linea.ChildNodes)
                                {
                                    switch (detalle.Name)
                                    {
                                        case "Detalle":
                                            detailLine.Detail = detalle.InnerText;
                                            if (isService(detalle.InnerText)) detailLine.Type = "Servicio";
                                            else detailLine.Type = "Bien";
                                            break;

                                        case "SubTotal":
                                            detailLine.Subtotal = float.Parse(detalle.InnerText.ToString(), CultureInfo.InvariantCulture);
                                            if (isNotaDeCredito == true) detailLine.Subtotal = detailLine.Subtotal * -1;
                                            break;

                                        case "Impuesto":
                                            foreach (XmlNode impuesto in detalle.ChildNodes)
                                            {
                                                if (impuesto.Name == "Tarifa")
                                                {
                                                    detailLine.Rate = Convert.ToInt32(float.Parse(impuesto.InnerText.ToString(), 
                                                        CultureInfo.InvariantCulture));
                                                }

                                                if (impuesto.Name == "Monto")
                                                {
                                                    detailLine.Iva = float.Parse(impuesto.InnerText.ToString(), CultureInfo.InvariantCulture);
                                                    if (isNotaDeCredito == true) detailLine.Iva = detailLine.Iva * -1;
                                                }

                                                if (impuesto.Name == "Exoneracion")
                                                {
                                                    foreach (XmlNode exoneracion in impuesto.ChildNodes)
                                                    {
                                                        if (exoneracion.Name == "PorcentajeExoneracion")
                                                        {
                                                            detailLine.ExonRate = Convert.ToInt32(exoneracion.InnerText.ToString(), 
                                                                CultureInfo.InvariantCulture);
                                                        }
                                                        if (exoneracion.Name == "MontoExoneracion")
                                                        {
                                                            detailLine.Iva = detailLine.Iva - float.Parse(exoneracion.InnerText.ToString(), 
                                                                CultureInfo.InvariantCulture);
                                                            detailLine.Exoneration = (float)(Convert.ToDecimal(exoneracion.InnerText.ToString(), 
                                                                CultureInfo.InvariantCulture) / decimal.Divide(detailLine.Rate, 100));
                                                        }
                                                    }

                                                }
                                            }//End Impuesto tag
                                            break;

                                        default:
                                            break;
                                    }//End 2nd switch
                                }
                                facturaInfo.Details.Add(detailLine);
                            }
                            break;

                        default:
                            break;

                    }//End Switch

                }//End Xml Loop

                facturaInfo.Totaliva = 0;
                facturaInfo.Excempt = 0;
                facturaInfo.Taxed = 0;
                facturaInfo.TotalExo = 0;

                facturaInfo.Type = "Bien";

                int service = 0;
                int good = 0;

                foreach (InvoiceDetail linea in facturaInfo.Details)
                {
                    if (linea.Type == "Servicio") service++;
                    else good++;
                        
                    if (linea.Rate != 0)
                    {
                        facturaInfo.Taxed = facturaInfo.Taxed + linea.Subtotal;
                        facturaInfo.Totaliva = facturaInfo.Totaliva + linea.Iva;
                        if (linea.ExonRate != 0) facturaInfo.TotalExo = facturaInfo.TotalExo + linea.Exoneration;
                    }
                    else
                    {
                        facturaInfo.Excempt = facturaInfo.Excempt + linea.Subtotal;
                    }
                }

                if (service > good) facturaInfo.Type = "Servicio";

                facturaInfo.Total = facturaInfo.Excempt + facturaInfo.Taxed + facturaInfo.Totaliva;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return facturaInfo;

        }//End readInvoice()

        private bool isService(string detalle) {

            bool isService = false;

            string[] keywords = new string[9] { "servicio", "acarreo", "transporte", "comision",
                                                "trasporte", "trasnporte", "comisión", "flete", "realizados" };

            foreach (string keyword in keywords)
            {
                if (detalle.ToLower().Contains(keyword)) 
                {
                    isService = true;
                    break;
                }
            }
            return isService;
        }

    }//End of Class
}
