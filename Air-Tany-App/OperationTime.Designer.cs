namespace Air_Tany_App
{
    partial class OperationTime
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
            this.budgetTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgTitre = new System.Windows.Forms.DataGridView();
            this.dtgOperation = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTitre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOperation)).BeginInit();
            this.SuspendLayout();
            // 
            // budgetTotal
            // 
            this.budgetTotal.AutoSize = true;
            this.budgetTotal.Location = new System.Drawing.Point(216, 581);
            this.budgetTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.budgetTotal.Name = "budgetTotal";
            this.budgetTotal.Size = new System.Drawing.Size(14, 16);
            this.budgetTotal.TabIndex = 21;
            this.budgetTotal.Text = "0";
            this.budgetTotal.Click += new System.EventHandler(this.budgetTotal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 581);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Budget Total :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1255, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Titres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Portefeuille";
            // 
            // dtgTitre
            // 
            this.dtgTitre.AllowUserToAddRows = false;
            this.dtgTitre.AllowUserToDeleteRows = false;
            this.dtgTitre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTitre.Location = new System.Drawing.Point(868, 105);
            this.dtgTitre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgTitre.Name = "dtgTitre";
            this.dtgTitre.ReadOnly = true;
            this.dtgTitre.RowHeadersWidth = 51;
            this.dtgTitre.RowTemplate.Height = 24;
            this.dtgTitre.Size = new System.Drawing.Size(779, 385);
            this.dtgTitre.TabIndex = 15;
            this.dtgTitre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTitre_CellContentClick);
            this.dtgTitre.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgTitre_RowHeaderMouseDoubleClick);
            // 
            // dtgOperation
            // 
            this.dtgOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOperation.Location = new System.Drawing.Point(76, 105);
            this.dtgOperation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgOperation.Name = "dtgOperation";
            this.dtgOperation.RowHeadersWidth = 51;
            this.dtgOperation.RowTemplate.Height = 24;
            this.dtgOperation.Size = new System.Drawing.Size(769, 385);
            this.dtgOperation.TabIndex = 14;
            // 
            // OperationTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1724, 656);
            this.Controls.Add(this.budgetTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgTitre);
            this.Controls.Add(this.dtgOperation);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OperationTime";
            this.Text = "OperationTime";
            this.Load += new System.EventHandler(this.OperationTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTitre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOperation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label budgetTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgTitre;
        private System.Windows.Forms.DataGridView dtgOperation;
    }
}