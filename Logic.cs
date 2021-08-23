using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DeclaraSummary
{
    class Logic
    {

        private List<string> pickFolder(string type)
        {
            List<string> xmlList = new List<string>();

            List<string> folderContent = new List<string>();

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    folderContent = files.ToList();
                }
                else {
                    MessageBox.Show("Por Favor seleccione una carpeta con contenido valido!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //Clean Initial list from other non xml files and Recibido files
            foreach (string file in folderContent) {


                if (file.Substring(file.Length - 4) == ".xml")
                {
                    XmlDocument doc = new XmlDocument();

                    doc.Load(file);

                    if (doc.DocumentElement.Name == "FacturaElectronica" ||
                        doc.DocumentElement.Name == "NotaCreditoElectronica") xmlList.Add(file);                    
                }

            }
            validateList(xmlList, type);
            return xmlList;
        }//End of pichFolder

        private void validateList(List<string> files, string type)
        {

            if (files.Count > 0)
            {
                switch (type) {

                    case "Income":
                        InvoiceValidation.isIncomeInvoicesValid = true;
                        break;
                    case "Expense":
                        InvoiceValidation.isReceivedInvoicesValid = true;
                        break;
                    default:
                        MessageBox.Show("Errror desconocido: Validacion de listas de facturas");
                        break;
                }
            }
            else 
            {
                switch (type)
                {
                    case "Income":
                        InvoiceValidation.isIncomeInvoicesValid = false;
                        break;
                    case "Expense":
                        InvoiceValidation.isReceivedInvoicesValid = false;
                        break;
                    default:
                        MessageBox.Show("Errror desconocido: Validacion de listas de facturas");
                        break;
                }
            }

        }//End of Validate List

        public List<Invoice> loadFileList(List<Invoice> incomeInvoices, List<Invoice> expenseInvoices, string type) {


            List<string> files = pickFolder(type);

            Reader xmlReader = new Reader();

            List<Invoice> loadedXml = new List<Invoice>();

            foreach (string file in files)
            {

                loadedXml.Add(xmlReader.ReadInvoice(file));
            }

            if (type == "Income")
            {
                incomeInvoices.Clear();
                incomeInvoices = loadedXml;
            }
            else
            {
                expenseInvoices.Clear();
                expenseInvoices = loadedXml;
            }

            if ((type == "Income" && InvoiceValidation.isIncomeInvoicesValid == true) || 
                    (type == "Expense" && InvoiceValidation.isReceivedInvoicesValid == true))
            {
                if (type == "Income") {
                    return incomeInvoices;
                } else {
                    return expenseInvoices;
                } 

            }
            else {
                MessageBox.Show("Error! La carpeta seleccionada no tiene archivos validos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                List<Invoice> voidInvoice = new List<Invoice>();
                return voidInvoice;
            }
        }//End of loadFileList

        public void validateDates(List<Invoice> incomeInvoices, List<Invoice> expenseInvoices, string type) 
        {
            bool isDateOk = true;

            //Validate dates
            DateTime today = DateTime.Now;

            int year = today.Year;

            if (today.Month == 1) year--; 

            DateTime monthBeginning = new DateTime(year, today.Month - 1, 1);

            DateTime monthEnds = new DateTime(year, today.Month, 1);

            if (type == "Income")
            {
                foreach (Invoice invoice in incomeInvoices)
                {
                    if (!(invoice.Date >= monthBeginning && invoice.Date < monthEnds))
                    {
                        isDateOk = false;
                    }
                }
            }
            else {
                foreach (Invoice invoice in expenseInvoices)
                {
                    if (!(invoice.Date >= monthBeginning && invoice.Date < monthEnds))
                    {
                        isDateOk = false;
                    }
                }
            }

            if (isDateOk != true)
            {
                MessageBox.Show("Advertencia! \n " +
                    "Parece que en la carpeta hay una o mas facturas de un periodo no correspondiente!. " +
                    "\n Por favor Revise la información", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }//End ValidateDates
    }
}
