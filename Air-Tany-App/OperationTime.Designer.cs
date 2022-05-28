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
            this.budgetTotal.Location = new System.Drawing.Point(162, 472);
            this.budgetTotal.Name = "budgetTotal";
            this.budgetTotal.Size = new System.Drawing.Size(13, 13);
            this.budgetTotal.TabIndex = 21;
            this.budgetTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Budget Total :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(941, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Titres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Portefeuille";
            // 
            // dtgTitre
            // 
            this.dtgTitre.AllowUserToAddRows = false;
            this.dtgTitre.AllowUserToDeleteRows = false;
            this.dtgTitre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTitre.Location = new System.Drawing.Point(654, 85);
            this.dtgTitre.Name = "dtgTitre";
            this.dtgTitre.ReadOnly = true;
            this.dtgTitre.RowHeadersWidth = 51;
            this.dtgTitre.RowTemplate.Height = 24;
            this.dtgTitre.Size = new System.Drawing.Size(584, 313);
            this.dtgTitre.TabIndex = 15;
            this.dtgTitre.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgTitre_RowHeaderMouseDoubleClick);
            // 
            // dtgOperation
            // 
            this.dtgOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOperation.Location = new System.Drawing.Point(57, 85);
            this.dtgOperation.Name = "dtgOperation";
            this.dtgOperation.RowHeadersWidth = 51;
            this.dtgOperation.RowTemplate.Height = 24;
            this.dtgOperation.Size = new System.Drawing.Size(577, 313);
            this.dtgOperation.TabIndex = 14;
            this.dtgOperation.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgOperation_RowHeaderMouseDoubleClick);
            // 
            // OperationTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 533);
            this.Controls.Add(this.budgetTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgTitre);
            this.Controls.Add(this.dtgOperation);
            this.Name = "OperationTime";
            this.Text = "OperationTime";
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