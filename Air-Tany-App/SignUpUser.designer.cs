
namespace Air_Tany_App
{
    partial class SignUpUser
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
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.pnlTextfield = new System.Windows.Forms.Panel();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.txbFirstname = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cbxEndDate = new System.Windows.Forms.CheckBox();
            this.cbxJob = new System.Windows.Forms.ComboBox();
            this.pnlTextfield.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(651, 219);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(237, 22);
            this.dtpStartDate.TabIndex = 6;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(567, 223);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(75, 17);
            this.lblStartDate.TabIndex = 7;
            this.lblStartDate.Text = "Depuis le :";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarForeColor = System.Drawing.Color.DimGray;
            this.dtpEndDate.CalendarMonthBackground = System.Drawing.Color.DarkGray;
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Location = new System.Drawing.Point(651, 271);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(237, 22);
            this.dtpEndDate.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = " Jusqu\'au :";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(155, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(797, 396);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 14;
            this.btnValidate.Text = "Valider";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // pnlTextfield
            // 
            this.pnlTextfield.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTextfield.Controls.Add(this.txbUsername);
            this.pnlTextfield.Controls.Add(this.lblUsername);
            this.pnlTextfield.Controls.Add(this.txbMail);
            this.pnlTextfield.Controls.Add(this.txbFirstname);
            this.pnlTextfield.Controls.Add(this.txbName);
            this.pnlTextfield.Controls.Add(this.lblMail);
            this.pnlTextfield.Controls.Add(this.lblFirstname);
            this.pnlTextfield.Controls.Add(this.lblName);
            this.pnlTextfield.Location = new System.Drawing.Point(109, 12);
            this.pnlTextfield.Name = "pnlTextfield";
            this.pnlTextfield.Size = new System.Drawing.Size(804, 172);
            this.pnlTextfield.TabIndex = 15;
            // 
            // txbUsername
            // 
            this.txbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbUsername.Location = new System.Drawing.Point(216, 132);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(458, 22);
            this.txbUsername.TabIndex = 20;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(70, 135);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(121, 17);
            this.lblUsername.TabIndex = 19;
            this.lblUsername.Text = "Nom d\'utilisateur :";
            // 
            // txbMail
            // 
            this.txbMail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMail.Location = new System.Drawing.Point(216, 92);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(458, 22);
            this.txbMail.TabIndex = 18;
            // 
            // txbFirstname
            // 
            this.txbFirstname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbFirstname.Location = new System.Drawing.Point(216, 53);
            this.txbFirstname.Name = "txbFirstname";
            this.txbFirstname.Size = new System.Drawing.Size(458, 22);
            this.txbFirstname.TabIndex = 17;
            // 
            // txbName
            // 
            this.txbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbName.Location = new System.Drawing.Point(216, 14);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(458, 22);
            this.txbName.TabIndex = 16;
            // 
            // lblMail
            // 
            this.lblMail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(136, 95);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(55, 17);
            this.lblMail.TabIndex = 15;
            this.lblMail.Text = "E-mail :";
            // 
            // lblFirstname
            // 
            this.lblFirstname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(126, 56);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(65, 17);
            this.lblFirstname.TabIndex = 14;
            this.lblFirstname.Text = "Prénom :";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(146, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Nom :";
            // 
            // cbxEndDate
            // 
            this.cbxEndDate.AutoSize = true;
            this.cbxEndDate.Location = new System.Drawing.Point(678, 314);
            this.cbxEndDate.Name = "cbxEndDate";
            this.cbxEndDate.Size = new System.Drawing.Size(174, 21);
            this.cbxEndDate.TabIndex = 16;
            this.cbxEndDate.Text = "Ajouter une date de fin";
            this.cbxEndDate.UseVisualStyleBackColor = true;
            this.cbxEndDate.CheckedChanged += new System.EventHandler(this.cbxEndDate_CheckedChanged);
            // 
            // cbxJob
            // 
            this.cbxJob.FormattingEnabled = true;
            this.cbxJob.Items.AddRange(new object[] {
            "Administrateur",
            "Responsable",
            "Trader"});
            this.cbxJob.Location = new System.Drawing.Point(191, 264);
            this.cbxJob.Name = "cbxJob";
            this.cbxJob.Size = new System.Drawing.Size(205, 24);
            this.cbxJob.TabIndex = 17;
            // 
            // SignUpUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 505);
            this.Controls.Add(this.cbxJob);
            this.Controls.Add(this.cbxEndDate);
            this.Controls.Add(this.pnlTextfield);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpStartDate);
            this.Name = "SignUpUser";
            this.Text = "SignUpUser";
            this.pnlTextfield.ResumeLayout(false);
            this.pnlTextfield.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Panel pnlTextfield;
        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.TextBox txbFirstname;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox cbxEndDate;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox cbxJob;
    }
}