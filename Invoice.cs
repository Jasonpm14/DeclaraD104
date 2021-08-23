using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaraSummary
{
    public class Invoice
    {

        private string serial;   //NumeroConsecutivo
        private string emissor;   //Emisor -> Nombre
        private string customer;   //Receptor -> Nombre
        private string type;

        private float taxed;    //ResumenFactura -> TotalGravado
        private float excempt;  //ResumenFactura -> TotalExcento 
        private float total;      //ResumenFactura -> TotalComprobante
        private float totaliva;
        private float totalExo;

        private DateTime date;     //FechaEmision

        private List<InvoiceDetail> details;

        public string Serial { get => serial; set => serial = value; }
        public string Emissor { get => emissor; set => emissor = value; }
        public string Customer { get => customer; set => customer = value; }
        public string Type { get => type; set => type = value; }
        public float Taxed { get => taxed; set => taxed = value; }
        public float Excempt { get => excempt; set => excempt = value; }
        public float Total { get => total; set => total = value; }
        public float Totaliva { get => totaliva; set => totaliva = value; }
        public float TotalExo { get => totalExo; set => totalExo = value; }
        public DateTime Date { get => date; set => date = value; }
        internal List<InvoiceDetail> Details { get => details; set => details = value; }
    }

    public class InvoiceDetail
    {

        private string type;
        private float subtotal;    //DetalleServicio -> LineaDetalle
        private float iva;       //LineaDetalle -> Impuesto -> Tarifa
        private int rate;
        private string detail;
        private float exoneration;
        private int exonRate;

        public string Type { get => type; set => type = value; }
        public float Subtotal { get => subtotal; set => subtotal = value; }
        public float Iva { get => iva; set => iva = value; }
        public int Rate { get => rate; set => rate = value; }
        public string Detail { get => detail; set => detail = value; }
        public float Exoneration { get => exoneration; set => exoneration = value; }
        public int ExonRate { get => exonRate; set => exonRate = value; }
    }
}
