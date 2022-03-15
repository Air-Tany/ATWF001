
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
            this.créerUnUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslLogIn = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(691, 24);
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
            this.MnuFile.Size = new System.Drawing.Size(54, 20);
            this.MnuFile.Text = "Fichier";
            // 
            // OptConnect
            // 
            this.OptConnect.Name = "OptConnect";
            this.OptConnect.Size = new System.Drawing.Size(153, 22);
            this.OptConnect.Text = "Connexion";
            this.OptConnect.Click += new System.EventHandler(this.OptConnect_Click);
            // 
            // OptDeconnect
            // 
            this.OptDeconnect.Name = "OptDeconnect";
            this.OptDeconnect.Size = new System.Drawing.Size(153, 22);
            this.OptDeconnect.Text = "Déconnexion";
            // 
            // OptExit
            // 
            this.OptExit.Name = "OptExit";
            this.OptExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.OptExit.Size = new System.Drawing.Size(153, 22);
            this.OptExit.Text = "Quitter";
            this.OptExit.Click += new System.EventHandler(this.OptExit_Click);
            // 
            // MnuStaff
            // 
            this.MnuStaff.Name = "MnuStaff";
            this.MnuStaff.Size = new System.Drawing.Size(71, 20);
            this.MnuStaff.Text = "Personnel";
            // 
            // MnuProducts
            // 
            this.MnuProducts.Name = "MnuProducts";
            this.MnuProducts.Size = new System.Drawing.Size(63, 20);
            this.MnuProducts.Text = "Produits";
            // 
            // MnuOperations
            // 
            this.MnuOperations.Name = "MnuOperations";
            this.MnuOperations.Size = new System.Drawing.Size(77, 20);
            this.MnuOperations.Text = "Opérations";
            // 
            // MnuDocuments
            // 
            this.MnuDocuments.Name = "MnuDocuments";
            this.MnuDocuments.Size = new System.Drawing.Size(80, 20);
            this.MnuDocuments.Text = "Documents";
            // 
            // MnuAdmin
            // 
            this.MnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptCreateTables,
            this.OptFillTables,
            this.créerUnUtilisateurToolStripMenuItem});
            this.MnuAdmin.Name = "MnuAdmin";
            this.MnuAdmin.Size = new System.Drawing.Size(98, 20);
            this.MnuAdmin.Text = "Administration";
            // 
            // OptCreateTables
            // 
            this.OptCreateTables.Name = "OptCreateTables";
            this.OptCreateTables.Size = new System.Drawing.Size(183, 22);
            this.OptCreateTables.Text = "Création des tables";
            // 
            // OptFillTables
            // 
            this.OptFillTables.Name = "OptFillTables";
            this.OptFillTables.Size = new System.Drawing.Size(183, 22);
            this.OptFillTables.Text = "Remplir les tables";
            // 
            // créerUnUtilisateurToolStripMenuItem
            // 
            this.créerUnUtilisateurToolStripMenuItem.Name = "créerUnUtilisateurToolStripMenuItem";
            this.créerUnUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.créerUnUtilisateurToolStripMenuItem.Text = "Créer un utilisateur...";
            this.créerUnUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.créerUnUtilisateurToolStripMenuItem_Click);
            // 
            // MnuAbout
            // 
            this.MnuAbout.Name = "MnuAbout";
            this.MnuAbout.Size = new System.Drawing.Size(67, 20);
            this.MnuAbout.Text = "A propos";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslLogIn});
            this.statusStrip1.Location = new System.Drawing.Point(0, 294);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(691, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslLogIn
            // 
            this.tsslLogIn.Name = "tsslLogIn";
            this.tsslLogIn.Size = new System.Drawing.Size(0, 17);
            // 
            // MainLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 316);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainLayout";
            this.Text = "AirTany";
            this.Load += new System.EventHandler(this.MainLayout_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem créerUnUtilisateurToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslLogIn;
    }
}

