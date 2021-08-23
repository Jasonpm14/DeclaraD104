namespace DeclaraSummary
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadIncome = new System.Windows.Forms.Button();
            this.IncomeSuccess = new System.Windows.Forms.Label();
            this.receivedSuccess = new System.Windows.Forms.Label();
            this.btnLoadExpenses = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCheckInvoices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Por favor seleccione la carpeta con las facturas de Ventas:";
            // 
            // btnLoadIncome
            // 
            this.btnLoadIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadIncome.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadIncome.Image")));
            this.btnLoadIncome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoadIncome.Location = new System.Drawing.Point(482, 107);
            this.btnLoadIncome.Name = "btnLoadIncome";
            this.btnLoadIncome.Size = new System.Drawing.Size(105, 66);
            this.btnLoadIncome.TabIndex = 3;
            this.btnLoadIncome.Text = "Cargar Facturas";
            this.btnLoadIncome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoadIncome.UseVisualStyleBackColor = true;
            this.btnLoadIncome.Click += new System.EventHandler(this.btnLoadIncome_Click);
            // 
            // IncomeSuccess
            // 
            this.IncomeSuccess.AutoSize = true;
            this.IncomeSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomeSuccess.ForeColor = System.Drawing.Color.Green;
            this.IncomeSuccess.Location = new System.Drawing.Point(51, 160);
            this.IncomeSuccess.Name = "IncomeSuccess";
            this.IncomeSuccess.Size = new System.Drawing.Size(233, 13);
            this.IncomeSuccess.TabIndex = 4;
            this.IncomeSuccess.Text = "Las facturas fueron cargadas con éxito!";
            this.IncomeSuccess.Visible = false;
            // 
            // receivedSuccess
            // 
            this.receivedSuccess.AutoSize = true;
            this.receivedSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedSuccess.ForeColor = System.Drawing.Color.Green;
            this.receivedSuccess.Location = new System.Drawing.Point(54, 273);
            this.receivedSuccess.Name = "receivedSuccess";
            this.receivedSuccess.Size = new System.Drawing.Size(233, 13);
            this.receivedSuccess.TabIndex = 7;
            this.receivedSuccess.Text = "Las facturas fueron cargadas con éxito!";
            this.receivedSuccess.Visible = false;
            // 
            // btnLoadExpenses
            // 
            this.btnLoadExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadExpenses.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadExpenses.Image")));
            this.btnLoadExpenses.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoadExpenses.Location = new System.Drawing.Point(482, 216);
            this.btnLoadExpenses.Name = "btnLoadExpenses";
            this.btnLoadExpenses.Size = new System.Drawing.Size(105, 66);
            this.btnLoadExpenses.TabIndex = 6;
            this.btnLoadExpenses.Text = "Cargar Facturas";
            this.btnLoadExpenses.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoadExpenses.UseVisualStyleBackColor = true;
            this.btnLoadExpenses.Click += new System.EventHandler(this.btnLoadExpenses_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(430, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Por favor seleccione la carpeta con las facturas de Compras:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnCheckInvoices
            // 
            this.btnCheckInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckInvoices.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckInvoices.Image")));
            this.btnCheckInvoices.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCheckInvoices.Location = new System.Drawing.Point(251, 375);
            this.btnCheckInvoices.Name = "btnCheckInvoices";
            this.btnCheckInvoices.Size = new System.Drawing.Size(122, 60);
            this.btnCheckInvoices.TabIndex = 8;
            this.btnCheckInvoices.Text = "Revisar Facturas";
            this.btnCheckInvoices.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCheckInvoices.UseVisualStyleBackColor = true;
            this.btnCheckInvoices.Click += new System.EventHandler(this.btnCheckInvoices_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 473);
            this.Controls.Add(this.btnCheckInvoices);
            this.Controls.Add(this.receivedSuccess);
            this.Controls.Add(this.btnLoadExpenses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IncomeSuccess);
            this.Controls.Add(this.btnLoadIncome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Declaración Iva";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoadIncome;
        private System.Windows.Forms.Label IncomeSuccess;
        private System.Windows.Forms.Label receivedSuccess;
        private System.Windows.Forms.Button btnLoadExpenses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCheckInvoices;
    }
}