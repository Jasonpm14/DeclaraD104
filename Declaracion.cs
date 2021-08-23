using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeclaraSummary
{
    public partial class Declaracion : Form
    {
        private List<Invoice> incomeInvoices = new List<Invoice>();
        private List<Invoice> expenseInvoices = new List<Invoice>();

        private class formFields
        {
            public int exon { get; set; }
            public int tax0 {get; set;}
            public int tax1 { get; set; }
            public int tax2 { get; set; }
            public int tax4 { get; set; }
            public int tax8 { get; set; }
            public int tax13 { get; set; }
            public int typetotal { get; set; }
            public int taxTotal { get; set; }
            public int tax1Credit { get; set; }
            public int tax2Credit { get; set; }
            public int tax4Credit { get; set; }
            public int tax8Credit { get; set; }
            public int tax13Credit { get; set; }
        }

        public Declaracion(List<Invoice> income, List<Invoice> expense)
        {
            InitializeComponent();
            incomeInvoices = income;
            expenseInvoices = expense;
        }

        private int sumTaxes(int currentCount, float toSum) {
            return currentCount + Convert.ToInt32(Math.Round(toSum));
        }

        private void Declaracion_Load(object sender, EventArgs e)
        {

            //Adjust resolution

            int maxRes = 4320;

            foreach (var screen in Screen.AllScreens)
            {
                if (screen.WorkingArea.Height < maxRes) maxRes = screen.WorkingArea.Height;
            }

            this.Height = Convert.ToInt32(maxRes * 0.99);

            this.CenterToScreen();

            //End of Screeen adjusting

            DateTime today = DateTime.Now;

            string[] monthArray = new string[12]{"Enero", "Febrero", "Marzo", "Abril", "Mayo",
                "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre"};

            string month = monthArray[today.Month - 2];

            int year = today.Year;

            if (month == "Diciembre")
            {
                year = today.Year - 1;
            }

            this.lblDate.Text = month + " " + year.ToString();

            formFields IncomeService = new formFields();
            formFields IncomeGoods = new formFields();
            formFields ExpenseService = new formFields();
            formFields ExpenseGoods = new formFields();

            foreach (Invoice incomeInvoice in incomeInvoices)
            {
                foreach (InvoiceDetail details in incomeInvoice.Details)
                {
                    switch (details.Rate)
                    {
                        case 0:
                            if (incomeInvoice.Type == "Servicio")
                            {
                                IncomeService.tax0 = IncomeService.tax0 + Convert.ToInt32(Math.Round(details.Subtotal));
                            }
                            else {
                                IncomeGoods.tax0 = IncomeGoods.tax0 + Convert.ToInt32(Math.Round(details.Subtotal));
                            } 
                            break;

                        case 1:
                            if (incomeInvoice.Type == "Servicio")
                            {
                                IncomeService.tax1 = IncomeService.tax1 + Convert.ToInt32(Math.Round(details.Subtotal));
                                if (details.ExonRate > 0)
                                {
                                    IncomeService.tax1 = IncomeService.tax1 - Convert.ToInt32(Math.Round(details.Exoneration));
                                    IncomeService.exon = IncomeService.exon + Convert.ToInt32(Math.Round(details.Exoneration));
                                }
                            }
                            else {
                                IncomeGoods.tax1 = IncomeGoods.tax1 + Convert.ToInt32(Math.Round(details.Subtotal));
                                if (details.ExonRate > 0)
                                {
                                    IncomeGoods.tax1 = IncomeGoods.tax1 - Convert.ToInt32(Math.Round(details.Exoneration));
                                    IncomeGoods.exon = IncomeGoods.exon + Convert.ToInt32(Math.Round(details.Exoneration));
                                }
                            } 
                            break;

                        case 2:
                            if (incomeInvoice.Type == "Servicio")
                            {
                                IncomeService.tax2 = IncomeService.tax2 + Convert.ToInt32(Math.Round(details.Subtotal));
                                if (details.ExonRate > 0)
                                {
                                    IncomeService.tax2 = IncomeService.tax2 - Convert.ToInt32(Math.Round(details.Exoneration));
                                    IncomeService.exon = IncomeService.exon + Convert.ToInt32(Math.Round(details.Exoneration));
                                }
                            }
                            else {
                                IncomeGoods.tax2 = IncomeGoods.tax2 + Convert.ToInt32(Math.Round(details.Subtotal));
                                if (details.ExonRate > 0)
                                {
                                    IncomeGoods.tax2 = IncomeGoods.tax2 - Convert.ToInt32(Math.Round(details.Exoneration));
                                    IncomeGoods.exon = IncomeGoods.exon + Convert.ToInt32(Math.Round(details.Exoneration));
                                }
                            } 
                            break;

                        case 4:
                            if (incomeInvoice.Type == "Servicio")
                            {
                                IncomeService.tax4 = IncomeService.tax4 + Convert.ToInt32(Math.Round(details.Subtotal));
                                if (details.ExonRate > 0)
                                {
                                    IncomeService.tax4 = IncomeService.tax4 - Convert.ToInt32(Math.Round(details.Exoneration));
                                    IncomeService.exon = IncomeService.exon + Convert.ToInt32(Math.Round(details.Exoneration));
                                }
                            }
                            else {
                                IncomeGoods.tax4 = IncomeGoods.tax4 + Convert.ToInt32(Math.Round(details.Subtotal));
                                if (details.ExonRate > 0)
                                {
                                    IncomeGoods.tax4 = IncomeGoods.tax4 - Convert.ToInt32(Math.Round(details.Exoneration));
                                    IncomeGoods.exon = IncomeGoods.exon + Convert.ToInt32(Math.Round(details.Exoneration));
                                }
                            } 
                            break;

                        case 8:
                            if (incomeInvoice.Type == "Servicio")
                            {
                                IncomeService.tax8 = IncomeService.tax8 + Convert.ToInt32(Math.Round(details.Subtotal));
                                if (details.ExonRate > 0)
                                {
                                    IncomeService.tax8 = IncomeService.tax8 - Convert.ToInt32(Math.Round(details.Exoneration));
                                    IncomeService.exon = IncomeService.exon + Convert.ToInt32(Math.Round(details.Exoneration));
                                }
                            }
                            else {
                                IncomeGoods.tax8 = IncomeGoods.tax8 + Convert.ToInt32(Math.Round(details.Subtotal));
                                if (details.ExonRate > 0)
                                {
                                    IncomeGoods.tax8 = IncomeGoods.tax8 - Convert.ToInt32(Math.Round(details.Exoneration));
                                    IncomeGoods.exon = IncomeGoods.exon + Convert.ToInt32(Math.Round(details.Exoneration));
                                }
                            } 
                            break;

                        case 13:
                            if (incomeInvoice.Type == "Servicio")
                            {
                                IncomeService.tax13 = IncomeService.tax13 + Convert.ToInt32(Math.Round(details.Subtotal));
                                if (details.ExonRate > 0)
                                {
                                    IncomeService.tax13 = IncomeService.tax13 - Convert.ToInt32(Math.Round(details.Exoneration));
                                    IncomeService.exon = IncomeService.exon + Convert.ToInt32(Math.Round(details.Exoneration));
                                }
                            }
                            else {
                                IncomeGoods.tax13 = IncomeGoods.tax13 + Convert.ToInt32(Math.Round(details.Subtotal));
                                if (details.ExonRate > 0)
                                {
                                    IncomeGoods.tax13 = IncomeGoods.tax13 - Convert.ToInt32(Math.Round(details.Exoneration));
                                    IncomeGoods.exon = IncomeGoods.exon + Convert.ToInt32(Math.Round(details.Exoneration));
                                }
                            } 
                            break;

                        default:
                            MessageBox.Show("Linea de impuesto " + details.Detail + " no pudo ser clasificada en Ventas!" +
                                " El porcentage de impuesto de la linea es de: " + details.Rate, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }//End Switch

                    if (incomeInvoice.Type == "Servicio")
                    {
                        IncomeService.typetotal = sumTaxes(IncomeService.typetotal, (details.Subtotal - details.Exoneration));
                        IncomeService.taxTotal = sumTaxes(IncomeService.taxTotal, details.Iva);
                    }
                    else
                    {
                        IncomeGoods.typetotal = sumTaxes(IncomeGoods.typetotal, (details.Subtotal - details.Exoneration));
                        IncomeGoods.taxTotal = sumTaxes(IncomeGoods.taxTotal, details.Iva);
                    }
                }
            }//End For each

            foreach (Invoice expenseInvoice in expenseInvoices)
            {
                foreach (InvoiceDetail details in expenseInvoice.Details)
                {
                    switch (details.Rate)
                    {
                        case 0:
                            if (expenseInvoice.Type == "Servicio") ExpenseService.tax0 = ExpenseService.tax0 + Convert.ToInt32(Math.Round(details.Subtotal));
                            else ExpenseGoods.tax0 = ExpenseGoods.tax0 + Convert.ToInt32(Math.Round(details.Subtotal));
                            break;

                        case 1:
                            if (expenseInvoice.Type == "Servicio")
                            {
                                ExpenseService.tax1 = ExpenseService.tax1 + Convert.ToInt32(Math.Round(details.Subtotal));
                                ExpenseService.tax1Credit = ExpenseService.tax1Credit + Convert.ToInt32(Math.Round(details.Iva));
                                if (details.ExonRate > 0)
                                {
                                    ExpenseService.tax1 = ExpenseService.tax1 - Convert.ToInt32(Math.Round(details.Exoneration));
                                    ExpenseService.exon = ExpenseService.exon + Convert.ToInt32(Math.Round(details.Exoneration));
                                    ExpenseService.tax1Credit = ExpenseService.tax1Credit - Convert.ToInt32(Math.Round(details.Iva * (details.ExonRate / 100)));
                                }
                            }
                            else {
                                ExpenseGoods.tax1 = ExpenseGoods.tax1 + Convert.ToInt32(Math.Round(details.Subtotal));
                                ExpenseGoods.tax1Credit = ExpenseGoods.tax1Credit + Convert.ToInt32(Math.Round(details.Iva));
                                if (details.ExonRate > 0)
                                {
                                    ExpenseGoods.tax1 = ExpenseGoods.tax1 - Convert.ToInt32(Math.Round(details.Exoneration));
                                    ExpenseGoods.exon = ExpenseGoods.exon + Convert.ToInt32(Math.Round(details.Exoneration));
                                    ExpenseGoods.tax1Credit = ExpenseGoods.tax1Credit - Convert.ToInt32(Math.Round(details.Iva * (details.ExonRate / 100)));
                                }
                            }
                            
                            break;

                        case 2:
                            if (expenseInvoice.Type == "Servicio")
                            {
                                ExpenseService.tax2 = ExpenseService.tax2 + Convert.ToInt32(Math.Round(details.Subtotal));
                                ExpenseService.tax2Credit = ExpenseService.tax2Credit + Convert.ToInt32(Math.Round(details.Iva));
                                if (details.ExonRate > 0)
                                {
                                    ExpenseService.tax2 = ExpenseService.tax2 - Convert.ToInt32(Math.Round(details.Exoneration));
                                    ExpenseService.exon = ExpenseService.exon + Convert.ToInt32(Math.Round(details.Exoneration));
                                    ExpenseService.tax2Credit = ExpenseService.tax2Credit - Convert.ToInt32(Math.Round(details.Iva * (details.ExonRate / 100)));
                                }
                            }
                            else {
                                ExpenseGoods.tax2 = ExpenseGoods.tax2 + Convert.ToInt32(Math.Round(details.Subtotal));
                                ExpenseGoods.tax2Credit = ExpenseGoods.tax2Credit + Convert.ToInt32(Math.Round(details.Iva));
                                if (details.ExonRate > 0)
                                {
                                    ExpenseGoods.tax2 = ExpenseGoods.tax2 - Convert.ToInt32(Math.Round(details.Exoneration));
                                    ExpenseGoods.exon = ExpenseGoods.exon + Convert.ToInt32(Math.Round(details.Exoneration));
                                    ExpenseGoods.tax2Credit = ExpenseGoods.tax2Credit - Convert.ToInt32(Math.Round(details.Iva * (details.ExonRate / 100)));
                                }
                            } 
                            break;

                        case 4:
                            if (expenseInvoice.Type == "Servicio")
                            {
                                ExpenseService.tax4 = ExpenseService.tax4 + Convert.ToInt32(Math.Round(details.Subtotal));
                                ExpenseService.tax4Credit = ExpenseService.tax4Credit + Convert.ToInt32(Math.Round(details.Iva));
                                if (details.ExonRate > 0)
                                {
                                    ExpenseService.tax4 = ExpenseService.tax4 - Convert.ToInt32(Math.Round(details.Exoneration));
                                    ExpenseService.exon = ExpenseService.exon + Convert.ToInt32(Math.Round(details.Exoneration));
                                    ExpenseService.tax4Credit = ExpenseService.tax4Credit - Convert.ToInt32(Math.Round(details.Iva * (details.ExonRate / 100)));
                                }
                            }
                            else {
                                ExpenseGoods.tax4 = ExpenseGoods.tax4 + Convert.ToInt32(Math.Round(details.Subtotal));
                                ExpenseGoods.tax4Credit = ExpenseGoods.tax4Credit + Convert.ToInt32(Math.Round(details.Iva));
                                if (details.ExonRate > 0)
                                {
                                    ExpenseGoods.tax4 = ExpenseGoods.tax4 - Convert.ToInt32(Math.Round(details.Exoneration));
                                    ExpenseGoods.exon = ExpenseGoods.exon + Convert.ToInt32(Math.Round(details.Exoneration));
                                    ExpenseGoods.tax4Credit = ExpenseGoods.tax4Credit - Convert.ToInt32(Math.Round(details.Iva * (details.ExonRate / 100)));
                                }
                            } 
                            break;

                        case 8:
                            if (expenseInvoice.Type == "Servicio")
                            {
                                ExpenseService.tax8 = ExpenseService.tax8 + Convert.ToInt32(Math.Round(details.Subtotal));
                                ExpenseService.tax8Credit = ExpenseService.tax8Credit + Convert.ToInt32(Math.Round(details.Iva));
                                if (details.ExonRate > 0)
                                {
                                    ExpenseService.tax8 = ExpenseService.tax8 - Convert.ToInt32(Math.Round(details.Exoneration));
                                    ExpenseService.exon = ExpenseService.exon + Convert.ToInt32(Math.Round(details.Exoneration));
                                    ExpenseService.tax8Credit = ExpenseService.tax8Credit - Convert.ToInt32(Math.Round(details.Iva * (details.ExonRate / 100)));
                                }
                            }
                            else {
                                ExpenseGoods.tax8 = ExpenseGoods.tax8 + Convert.ToInt32(Math.Round(details.Subtotal));
                                ExpenseGoods.tax8Credit = ExpenseGoods.tax8Credit + Convert.ToInt32(Math.Round(details.Iva));
                                if (details.ExonRate > 0)
                                {
                                    ExpenseGoods.tax8 = ExpenseGoods.tax8 - Convert.ToInt32(Math.Round(details.Exoneration));
                                    ExpenseGoods.exon = ExpenseGoods.exon + Convert.ToInt32(Math.Round(details.Exoneration));
                                    ExpenseGoods.tax8Credit = ExpenseGoods.tax8Credit - Convert.ToInt32(Math.Round(details.Iva * (details.ExonRate / 100)));
                                }
                            }
                            
                            break;

                        case 13:
                            if (expenseInvoice.Type == "Servicio")
                            {
                                ExpenseService.tax13 = ExpenseService.tax13 + Convert.ToInt32(Math.Round(details.Subtotal));
                                ExpenseService.tax13Credit = ExpenseService.tax13Credit + Convert.ToInt32(Math.Round(details.Iva));
                                if (details.ExonRate > 0)
                                {
                                    ExpenseService.tax13 = ExpenseService.tax13 - Convert.ToInt32(Math.Round(details.Exoneration));
                                    ExpenseService.exon = ExpenseService.exon + Convert.ToInt32(Math.Round(details.Exoneration));
                                    ExpenseService.tax13Credit = ExpenseService.tax13Credit - Convert.ToInt32(Math.Round(details.Iva * (details.ExonRate / 100)));
                                }
                            }
                            else {
                                ExpenseGoods.tax13 = ExpenseGoods.tax13 + Convert.ToInt32(Math.Round(details.Subtotal));
                                ExpenseGoods.tax13Credit = ExpenseGoods.tax13Credit + Convert.ToInt32(Math.Round(details.Iva));
                                if (details.ExonRate > 0)
                                {
                                    ExpenseGoods.tax13 = ExpenseGoods.tax13 - Convert.ToInt32(Math.Round(details.Exoneration));
                                    ExpenseGoods.exon = ExpenseGoods.exon + Convert.ToInt32(Math.Round(details.Exoneration));
                                    ExpenseGoods.tax13Credit = ExpenseGoods.tax13Credit - Convert.ToInt32(Math.Round(details.Iva * (details.ExonRate / 100)));
                                }
                            }
                            
                            break;

                        default:
                            MessageBox.Show("Linea de impuesto " + details.Detail + " no pudo ser clasificada en Ventas!" +
                                " El porcentage de impuesto de la linea es de: " + details.Rate, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }//End Switch

                    if (expenseInvoice.Type == "Servicio")
                    {
                        ExpenseService.typetotal = sumTaxes(ExpenseService.typetotal, (details.Subtotal - details.Exoneration));
                        ExpenseService.taxTotal = sumTaxes(ExpenseService.taxTotal, details.Iva);
                    }
                    else
                    {
                        ExpenseGoods.typetotal = sumTaxes(ExpenseGoods.typetotal, (details.Subtotal - details.Exoneration));
                        ExpenseGoods.taxTotal = sumTaxes(ExpenseGoods.taxTotal, details.Iva);
                    }
                }
            }//End For each


            //Fill Ventas section
            txtServIncome0.Text = IncomeService.tax0.ToString();
            txtServIncome1.Text = IncomeService.tax1.ToString();
            txtServIncome2.Text = IncomeService.tax2.ToString();
            txtServIncome4.Text = IncomeService.tax4.ToString();
            txtServIncome8.Text = IncomeService.tax8.ToString();
            txtServIncome13.Text = IncomeService.tax13.ToString();
            txtServIncomeTotal.Text = IncomeService.typetotal.ToString();

            txtGIncome0.Text = IncomeGoods.tax0.ToString();
            txtGIncome1.Text = IncomeGoods.tax1.ToString();
            txtGIncome2.Text = IncomeGoods.tax2.ToString();
            txtGIncome4.Text = IncomeGoods.tax4.ToString();
            txtGIncome8.Text = IncomeGoods.tax8.ToString();
            txtGIncome13.Text = IncomeGoods.tax13.ToString();
            txtGIncomeTotal.Text = IncomeGoods.typetotal.ToString();

            txtIncomeTax.Text = (IncomeService.taxTotal + IncomeGoods.taxTotal).ToString();
            txtIncomeTotal.Text = (IncomeService.typetotal + IncomeGoods.typetotal + IncomeService.exon + IncomeGoods.exon).ToString();
            txtIncomeExon.Text = (IncomeService.exon + IncomeGoods.exon).ToString();

            //Fill Compras section
            txtServExpens0.Text = ExpenseService.tax0.ToString();
            txtServExpens1.Text = ExpenseService.tax1.ToString();
            txtServExpens2.Text = ExpenseService.tax2.ToString();
            txtServExpens4.Text = ExpenseService.tax4.ToString();
            txtServExpens8.Text = ExpenseService.tax8.ToString();
            txtServExpens13.Text = ExpenseService.tax13.ToString();
            txtServExpensCredit1.Text = ExpenseService.tax1Credit.ToString();
            txtServExpensCredit2.Text = ExpenseService.tax2Credit.ToString();
            txtServExpensCredit4.Text = ExpenseService.tax4Credit.ToString();
            txtServExpensCredit8.Text = ExpenseService.tax8Credit.ToString();
            txtServExpensCredit13.Text = ExpenseService.tax13Credit.ToString();
            txtServExpensTotal.Text = ExpenseService.typetotal.ToString();

            txtGoodsExpens0.Text = ExpenseGoods.tax0.ToString();
            txtGoodsExpens1.Text = ExpenseGoods.tax1.ToString();
            txtGoodsExpens2.Text = ExpenseGoods.tax2.ToString();
            txtGoodsExpens4.Text = ExpenseGoods.tax4.ToString();
            txtGoodsExpens8.Text = ExpenseGoods.tax8.ToString();
            txtGoodsExpens13.Text = ExpenseGoods.tax13.ToString();
            txtGoodsExpensCredit1.Text = ExpenseGoods.tax1Credit.ToString();
            txtGoodsExpensCredit2.Text = ExpenseGoods.tax2Credit.ToString();
            txtGoodsExpensCredit4.Text = ExpenseGoods.tax4Credit.ToString();
            txtGoodsExpensCredit8.Text = ExpenseGoods.tax8Credit.ToString();
            txtGoodsExpensCredit13.Text = ExpenseGoods.tax13Credit.ToString();
            txtGoodsExpensTotal.Text = ExpenseGoods.typetotal.ToString();

            txtExpensesTax.Text = (ExpenseService.taxTotal + ExpenseGoods.taxTotal).ToString();
            txtExpensesTotal.Text = (ExpenseService.typetotal + ExpenseGoods.typetotal + ExpenseService.exon + ExpenseGoods.exon).ToString();
            txtExpenseExon.Text = (ExpenseGoods.exon + ExpenseService.exon).ToString();

            txtTaxSells.Text = txtIncomeTax.Text;
            txtCreditExpenses.Text = txtExpensesTax.Text;

            int taxDiff = (IncomeService.taxTotal + IncomeGoods.taxTotal) - (ExpenseService.taxTotal + ExpenseGoods.taxTotal);

            if (taxDiff < 0) {
                lblApagar_saldoFavor.Text = "Saldo a favor:";
                lblSaldoFavorMsg.Visible = true;
                taxDiff = taxDiff * -1;
            }

            txtTaxToPay.Text = taxDiff.ToString();

            txtServIncome0.Select();
        }//End of DeclaracionLoad

        private void btnSalir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Declaracion_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            System.Windows.Forms.Application.Exit();
        }

        private void lblSaldoFavorMsg_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void btnBackToRev_Click(object sender, EventArgs e)
        {
            Revision toRev = new Revision(incomeInvoices, expenseInvoices);
            toRev.Show();
            this.Dispose();
        }
    }
}
