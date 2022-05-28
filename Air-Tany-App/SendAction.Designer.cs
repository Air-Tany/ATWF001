namespace Air_Tany_App
{
    partial class SendAction
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.nudSend = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSend)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Crimson;
            this.btnReturn.Location = new System.Drawing.Point(47, 119);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Retour";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Lime;
            this.btnOk.Location = new System.Drawing.Point(186, 119);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Valider";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // nudSend
            // 
            this.nudSend.Location = new System.Drawing.Point(89, 69);
            this.nudSend.Name = "nudSend";
            this.nudSend.Size = new System.Drawing.Size(120, 20);
            this.nudSend.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quantité de vente";
            // 
            // SendAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 178);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.nudSend);
            this.Controls.Add(this.label1);
            this.Name = "SendAction";
            this.Text = "SendAction";
            ((System.ComponentModel.ISupportInitialize)(this.nudSend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.NumericUpDown nudSend;
        private System.Windows.Forms.Label label1;
    }
}