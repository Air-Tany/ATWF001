namespace Air_Tany_App
{
    partial class ModifStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifStaff));
            this.Sup = new System.Windows.Forms.Button();
            this.Modify = new System.Windows.Forms.Button();
            this.cbxJob = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Sup
            // 
            this.Sup.BackColor = System.Drawing.Color.Red;
            this.Sup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sup.Location = new System.Drawing.Point(21, 132);
            this.Sup.Margin = new System.Windows.Forms.Padding(2);
            this.Sup.Name = "Sup";
            this.Sup.Size = new System.Drawing.Size(108, 40);
            this.Sup.TabIndex = 0;
            this.Sup.Text = "Supprimer utilisateur";
            this.Sup.UseVisualStyleBackColor = false;
            this.Sup.Click += new System.EventHandler(this.Sup_Click);
            // 
            // Modify
            // 
            this.Modify.BackColor = System.Drawing.Color.ForestGreen;
            this.Modify.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Modify.Location = new System.Drawing.Point(175, 132);
            this.Modify.Margin = new System.Windows.Forms.Padding(2);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(101, 40);
            this.Modify.TabIndex = 1;
            this.Modify.Text = "Modifier utilisateur";
            this.Modify.UseVisualStyleBackColor = false;
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // cbxJob
            // 
            this.cbxJob.FormattingEnabled = true;
            this.cbxJob.Items.AddRange(new object[] {
            "Administrateur",
            "Responsable",
            "Trader"});
            this.cbxJob.Location = new System.Drawing.Point(21, 74);
            this.cbxJob.Margin = new System.Windows.Forms.Padding(2);
            this.cbxJob.Name = "cbxJob";
            this.cbxJob.Size = new System.Drawing.Size(255, 21);
            this.cbxJob.TabIndex = 18;
            // 
            // ModifStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 202);
            this.Controls.Add(this.cbxJob);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.Sup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModifStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ModifStaff";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sup;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.ComboBox cbxJob;
    }
}