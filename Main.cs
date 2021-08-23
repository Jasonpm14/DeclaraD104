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
    public partial class Main : Form
    {

        private List<Invoice> incomeInvoices = new List<Invoice>();
        private List<Invoice> expenseInvoices = new List<Invoice>();



        public Main()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadIncome_Click(object sender, EventArgs e)
        {
            Logic loadInvoices = new Logic();

            incomeInvoices = loadInvoices.loadFileList(incomeInvoices, expenseInvoices, "Income");
            if (InvoiceValidation.isIncomeInvoicesValid == true)
            {
                IncomeSuccess.Visible = true;
            }
            loadInvoices.validateDates(incomeInvoices, expenseInvoices, "Income");
        }

        private void btnLoadExpenses_Click(object sender, EventArgs e)
        {
            Logic loadInvoices = new Logic();

            expenseInvoices = loadInvoices.loadFileList(incomeInvoices, expenseInvoices, "Expense");
            if (InvoiceValidation.isReceivedInvoicesValid == true) {
                receivedSuccess.Visible = true;
            }
            loadInvoices.validateDates(incomeInvoices, expenseInvoices, "Expense");
        }

        private void btnCheckInvoices_Click(object sender, EventArgs e)
        {

            if (InvoiceValidation.isIncomeInvoicesValid == false && InvoiceValidation.isReceivedInvoicesValid == false)
            {
                MessageBox.Show("No se ha cargado información!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Revision toRevision = new Revision(incomeInvoices, expenseInvoices);
                toRevision.Show();
                this.Hide();
            }

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            System.Windows.Forms.Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            InvoiceValidation.isReceivedInvoicesValid = false;
            InvoiceValidation.isIncomeInvoicesValid = false;
        }
    }

    static class InvoiceValidation
    {
        public static bool isIncomeInvoicesValid = false;
        public static bool isReceivedInvoicesValid = false;
    }
}
