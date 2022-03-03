﻿
namespace Air_Tany_App
{
    partial class MainLayout
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.OptConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.OptDeconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.OptExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOperations = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDocuments = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.OptCreateTables = new System.Windows.Forms.ToolStripMenuItem();
            this.OptFillTables = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFile,
            this.MnuStaff,
            this.MnuProducts,
            this.MnuOperations,
            this.MnuDocuments,
            this.MnuAdmin,
            this.MnuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuFile
            // 
            this.MnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptConnect,
            this.OptDeconnect,
            this.OptExit});
            this.MnuFile.Name = "MnuFile";
            this.MnuFile.Size = new System.Drawing.Size(66, 24);
            this.MnuFile.Text = "Fichier";
            // 
            // OptConnect
            // 
            this.OptConnect.Name = "OptConnect";
            this.OptConnect.Size = new System.Drawing.Size(191, 26);
            this.OptConnect.Text = "Connexion";
            this.OptConnect.Click += new System.EventHandler(this.OptConnect_Click);
            // 
            // OptDeconnect
            // 
            this.OptDeconnect.Name = "OptDeconnect";
            this.OptDeconnect.Size = new System.Drawing.Size(191, 26);
            this.OptDeconnect.Text = "Déconnexion";
            // 
            // OptExit
            // 
            this.OptExit.Name = "OptExit";
            this.OptExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.OptExit.Size = new System.Drawing.Size(191, 26);
            this.OptExit.Text = "Quitter";
            this.OptExit.Click += new System.EventHandler(this.OptExit_Click);
            // 
            // MnuStaff
            // 
            this.MnuStaff.Name = "MnuStaff";
            this.MnuStaff.Size = new System.Drawing.Size(86, 24);
            this.MnuStaff.Text = "Personnel";
            // 
            // MnuProducts
            // 
            this.MnuProducts.Name = "MnuProducts";
            this.MnuProducts.Size = new System.Drawing.Size(77, 24);
            this.MnuProducts.Text = "Produits";
            // 
            // MnuOperations
            // 
            this.MnuOperations.Name = "MnuOperations";
            this.MnuOperations.Size = new System.Drawing.Size(96, 24);
            this.MnuOperations.Text = "Opérations";
            // 
            // MnuDocuments
            // 
            this.MnuDocuments.Name = "MnuDocuments";
            this.MnuDocuments.Size = new System.Drawing.Size(98, 24);
            this.MnuDocuments.Text = "Documents";
            // 
            // MnuAdmin
            // 
            this.MnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptCreateTables,
            this.OptFillTables});
            this.MnuAdmin.Name = "MnuAdmin";
            this.MnuAdmin.Size = new System.Drawing.Size(121, 24);
            this.MnuAdmin.Text = "Administration";
            // 
            // OptCreateTables
            // 
            this.OptCreateTables.Name = "OptCreateTables";
            this.OptCreateTables.Size = new System.Drawing.Size(224, 26);
            this.OptCreateTables.Text = "Création des tables";
            // 
            // OptFillTables
            // 
            this.OptFillTables.Name = "OptFillTables";
            this.OptFillTables.Size = new System.Drawing.Size(224, 26);
            this.OptFillTables.Text = "Remplir les tables";
            // 
            // MnuAbout
            // 
            this.MnuAbout.Name = "MnuAbout";
            this.MnuAbout.Size = new System.Drawing.Size(84, 24);
            this.MnuAbout.Text = "A propos";
            // 
            // MainLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 364);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainLayout";
            this.Text = "AirTany";
            this.Load += new System.EventHandler(this.MainLayout_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuFile;
        private System.Windows.Forms.ToolStripMenuItem OptConnect;
        private System.Windows.Forms.ToolStripMenuItem OptDeconnect;
        private System.Windows.Forms.ToolStripMenuItem OptExit;
        private System.Windows.Forms.ToolStripMenuItem MnuStaff;
        private System.Windows.Forms.ToolStripMenuItem MnuProducts;
        private System.Windows.Forms.ToolStripMenuItem MnuOperations;
        private System.Windows.Forms.ToolStripMenuItem MnuDocuments;
        private System.Windows.Forms.ToolStripMenuItem MnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem OptCreateTables;
        private System.Windows.Forms.ToolStripMenuItem OptFillTables;
        private System.Windows.Forms.ToolStripMenuItem MnuAbout;
    }
}

