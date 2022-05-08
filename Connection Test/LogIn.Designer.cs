
namespace Connection_Test
{
    partial class LogIn
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxStayLogIn = new System.Windows.Forms.CheckBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(518, 359);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(130, 23);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Connexion";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(83, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbxStayLogIn
            // 
            this.cbxStayLogIn.AutoSize = true;
            this.cbxStayLogIn.Location = new System.Drawing.Point(279, 217);
            this.cbxStayLogIn.Name = "cbxStayLogIn";
            this.cbxStayLogIn.Size = new System.Drawing.Size(151, 21);
            this.cbxStayLogIn.TabIndex = 11;
            this.cbxStayLogIn.Text = "Se souvenir de moi";
            this.cbxStayLogIn.UseVisualStyleBackColor = true;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(229, 138);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(456, 22);
            this.txbPassword.TabIndex = 10;
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(265, 69);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(456, 22);
            this.txbUsername.TabIndex = 9;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(80, 143);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 17);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password :";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(80, 69);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(121, 17);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Nom d\'utilisateur :";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbxStayLogIn);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbxStayLogIn;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
    }
}