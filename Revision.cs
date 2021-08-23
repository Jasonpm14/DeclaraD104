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
    public partial class Revision : Form
    {
        List<Invoice> incomeInvoices;
        List<Invoice> expenseInvoices;

        public Revision(List<Invoice> income, List<Invoice> expense)
        {
            InitializeComponent();
            incomeInvoices = income;
            expenseInvoices = expense;

        }

        private void dgvIncome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvIncome_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string nInvoice = dgvIncome.Rows[e.RowIndex].Cells["Consecutivo"].Value.ToString();
            string newValue = dgvIncome.Rows[e.RowIndex].Cells["Bien/Servicio"].Value.ToString();

            foreach (Invoice invoiceElement in incomeInvoices)
            {
                if (invoiceElement.Serial == nInvoice)
                {
                    invoiceElement.Type = newValue;
                    break;
                } 
                
            }
        }

        private void Revision_Load(object sender, EventArgs e)
        {

            this.CenterToScreen();

            //Fill Income data grid with the invoices
            DataGridViewComboBoxColumn comboBox = new DataGridViewComboBoxColumn();

            comboBox.Name = "Bien/Servicio";
            comboBox.Items.Add("Bien");
            comboBox.Items.Add("Servicio");

            dgvIncome.Columns.Add(comboBox);
            dgvIncome.Columns.Add("Consecutivo", "Consecutivo");
            dgvIncome.Columns.Add("Cliente", "Cliente");
            dgvIncome.Columns.Add("Fecha", "Fecha");
            dgvIncome.Columns.Add("Excento", "Excento");
            dgvIncome.Columns.Add("Gravado", "Gravado");
            dgvIncome.Columns.Add("Impuesto", "Impuesto");
            dgvIncome.Columns.Add("Exonerado", "Exonerado");
            dgvIncome.Columns.Add("Total", "Total");

            foreach (Invoice invoice in incomeInvoices)
            {
                dgvIncome.Rows.Add(invoice.Type, invoice.Serial, invoice.Customer, invoice.Date,
                    invoice.Excempt.ToString("N"), invoice.Taxed.ToString("N"),
                    invoice.Totaliva.ToString("N"), invoice.TotalExo.ToString("N"), (invoice.Total - invoice.TotalExo).ToString("N"));
            }

            dgvIncome.Columns[1].ReadOnly = true;
            dgvIncome.Columns[2].ReadOnly = true;
            dgvIncome.Columns[3].ReadOnly = true;
            dgvIncome.Columns[4].ReadOnly = true;
            dgvIncome.Columns[5].ReadOnly = true;
            dgvIncome.Columns[6].ReadOnly = true;
            dgvIncome.Columns[7].ReadOnly = true;

            dgvIncome.AutoResizeColumns();
            dgvIncome.Columns["Exonerado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvIncome.Columns["Excento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvIncome.Columns["Gravado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvIncome.Columns["Impuesto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvIncome.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;



            //Fill Income data grid with the invoices
            DataGridViewComboBoxColumn comboBoxExp = new DataGridViewComboBoxColumn();

            comboBoxExp.Name = "Bien/Servicio";
            comboBoxExp.Items.Add("Bien");
            comboBoxExp.Items.Add("Servicio");

            dgvExpense.Columns.Add(comboBoxExp);
            dgvExpense.Columns.Add("Consecutivo", "Consecutivo");
            dgvExpense.Columns.Add("Cliente", "Cliente");
            dgvExpense.Columns.Add("Fecha", "Fecha");
            dgvExpense.Columns.Add("Excento", "Excento");
            dgvExpense.Columns.Add("Gravado", "Gravado");
            dgvExpense.Columns.Add("Impuesto", "Impuesto");
            dgvExpense.Columns.Add("Exonerado", "Exonerado");
            dgvExpense.Columns.Add("Total", "Total");

            foreach (Invoice invoice in expenseInvoices)
            {
                dgvExpense.Rows.Add(invoice.Type, invoice.Serial, invoice.Emissor, invoice.Date,
                    invoice.Excempt.ToString("N"), invoice.Taxed.ToString("N"),
                    invoice.Totaliva.ToString("N"), invoice.TotalExo.ToString("N"), (invoice.Total - invoice.TotalExo).ToString("N"));
            }

            dgvIncome.Columns[1].ReadOnly = true;
            dgvIncome.Columns[2].ReadOnly = true;
            dgvIncome.Columns[3].ReadOnly = true;
            dgvIncome.Columns[4].ReadOnly = true;
            dgvIncome.Columns[5].ReadOnly = true;
            dgvIncome.Columns[6].ReadOnly = true;
            dgvIncome.Columns[7].ReadOnly = true;

            dgvExpense.AutoResizeColumns();
            dgvExpense.Columns["Exonerado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvExpense.Columns["Excento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvExpense.Columns["Gravado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvExpense.Columns["Impuesto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvExpense.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            lblIncomeReaded.Text = "Total de documentos cargados: " + incomeInvoices.Count;
            lblExpenseReaded.Text = "Total de documentos cargados: " + expenseInvoices.Count;

        }

        private void Revision_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            System.Windows.Forms.Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvExpense_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvExpense_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string nInvoice = dgvExpense.Rows[e.RowIndex].Cells["Consecutivo"].Value.ToString();
            string newValue = dgvExpense.Rows[e.RowIndex].Cells["Bien/Servicio"].Value.ToString();

            foreach (Invoice invoiceElement in expenseInvoices)
            {
                if (invoiceElement.Serial == nInvoice)
                {
                    invoiceElement.Type = newValue;
                    break;
                } 
            }
        }

        private void btnDeclaracion_Click(object sender, EventArgs e)
        {
            Declaracion toDeclaracion = new Declaracion(incomeInvoices, expenseInvoices);

            toDeclaracion.Show();
            this.Dispose();
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            Main toMain = new Main();
            toMain.Show();
            this.Dispose();
        }
    }
}
