namespace Air_Tany_App
{
    partial class BudgetTrd
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
            this.DtgBudget = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtgBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgBudget
            // 
            this.DtgBudget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgBudget.Location = new System.Drawing.Point(121, 12);
            this.DtgBudget.Name = "DtgBudget";
            this.DtgBudget.Size = new System.Drawing.Size(542, 426);
            this.DtgBudget.TabIndex = 0;
            this.DtgBudget.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgBudget_CellContentClick);
            this.DtgBudget.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AddBudget);
            // 
            // BudgetTrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DtgBudget);
            this.Name = "BudgetTrd";
            this.Text = "BudgetTrd";
            this.Load += new System.EventHandler(this.BudgetTrd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgBudget)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgBudget;
    }
}