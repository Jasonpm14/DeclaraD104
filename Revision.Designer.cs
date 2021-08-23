namespace DeclaraSummary
{
    partial class Revision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Revision));
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvExpense = new System.Windows.Forms.DataGridView();
            this.btnDeclaracion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIncomeReaded = new System.Windows.Forms.Label();
            this.lblExpenseReaded = new System.Windows.Forms.Label();
            this.btnBackToMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIncome
            // 
            this.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncome.Location = new System.Drawing.Point(35, 116);
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.Size = new System.Drawing.Size(1073, 183);
            this.dgvIncome.TabIndex = 0;
            this.dgvIncome.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIncome_CellContentClick);
            this.dgvIncome.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIncome_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(613, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Por favor revise que la información de las facturas sea correcta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Facturas Emitidas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Facturas Recibidas:";
            // 
            // dgvExpense
            // 
            this.dgvExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpense.Location = new System.Drawing.Point(35, 363);
            this.dgvExpense.Name = "dgvExpense";
            this.dgvExpense.Size = new System.Drawing.Size(1073, 183);
            this.dgvExpense.TabIndex = 3;
            this.dgvExpense.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpense_CellContentClick);
            this.dgvExpense.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpense_CellValueChanged);
            // 
            // btnDeclaracion
            // 
            this.btnDeclaracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeclaracion.Image = ((System.Drawing.Image)(resources.GetObject("btnDeclaracion.Image")));
            this.btnDeclaracion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeclaracion.Location = new System.Drawing.Point(469, 573);
            this.btnDeclaracion.Name = "btnDeclaracion";
            this.btnDeclaracion.Size = new System.Drawing.Size(159, 39);
            this.btnDeclaracion.TabIndex = 5;
            this.btnDeclaracion.Text = "Ir a Declaración";
            this.btnDeclaracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeclaracion.UseVisualStyleBackColor = true;
            this.btnDeclaracion.Click += new System.EventHandler(this.btnDeclaracion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(572, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 38);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Facturas Cargadas";
            // 
            // lblIncomeReaded
            // 
            this.lblIncomeReaded.AutoSize = true;
            this.lblIncomeReaded.Location = new System.Drawing.Point(922, 94);
            this.lblIncomeReaded.Name = "lblIncomeReaded";
            this.lblIncomeReaded.Size = new System.Drawing.Size(35, 13);
            this.lblIncomeReaded.TabIndex = 8;
            this.lblIncomeReaded.Text = "label5";
            // 
            // lblExpenseReaded
            // 
            this.lblExpenseReaded.AutoSize = true;
            this.lblExpenseReaded.Location = new System.Drawing.Point(922, 341);
            this.lblExpenseReaded.Name = "lblExpenseReaded";
            this.lblExpenseReaded.Size = new System.Drawing.Size(35, 13);
            this.lblExpenseReaded.TabIndex = 9;
            this.lblExpenseReaded.Text = "label5";
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMain.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToMain.Image")));
            this.btnBackToMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackToMain.Location = new System.Drawing.Point(37, 575);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(84, 39);
            this.btnBackToMain.TabIndex = 10;
            this.btnBackToMain.Text = "Atrás";
            this.btnBackToMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // Revision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 642);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.lblExpenseReaded);
            this.Controls.Add(this.lblIncomeReaded);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDeclaracion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvExpense);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIncome);
            this.Name = "Revision";
            this.Text = "Revision";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Revision_FormClosed);
            this.Load += new System.EventHandler(this.Revision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIncome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvExpense;
        private System.Windows.Forms.Button btnDeclaracion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIncomeReaded;
        private System.Windows.Forms.Label lblExpenseReaded;
        private System.Windows.Forms.Button btnBackToMain;
    }
}