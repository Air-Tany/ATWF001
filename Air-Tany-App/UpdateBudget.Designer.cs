namespace Air_Tany_App
{
    partial class UpdateBudget
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
            this.txbBudget = new System.Windows.Forms.TextBox();
            this.Modif = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbBudget
            // 
            this.txbBudget.Location = new System.Drawing.Point(61, 78);
            this.txbBudget.Name = "txbBudget";
            this.txbBudget.Size = new System.Drawing.Size(197, 20);
            this.txbBudget.TabIndex = 0;
            // 
            // Modif
            // 
            this.Modif.BackColor = System.Drawing.Color.Lime;
            this.Modif.Location = new System.Drawing.Point(204, 136);
            this.Modif.Name = "Modif";
            this.Modif.Size = new System.Drawing.Size(96, 22);
            this.Modif.TabIndex = 1;
            this.Modif.Text = "Validation ";
            this.Modif.UseVisualStyleBackColor = false;
            this.Modif.Click += new System.EventHandler(this.Modif_Click);
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.Color.Crimson;
            this.Return.Location = new System.Drawing.Point(12, 136);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(96, 22);
            this.Return.TabIndex = 2;
            this.Return.Text = "Retour";
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UpdateBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 192);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Modif);
            this.Controls.Add(this.txbBudget);
            this.Name = "UpdateBudget";
            this.Text = "UpdateBudget";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbBudget;
        private System.Windows.Forms.Button Modif;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label label1;
    }
}