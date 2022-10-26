namespace couleurs
{
    partial class Form1
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
            this.list_couleur = new System.Windows.Forms.ListBox();
            this.ajouter = new System.Windows.Forms.Button();
            this.couleurc = new System.Windows.Forms.Button();
            this.supprimers = new System.Windows.Forms.Button();
            this.supprimerc = new System.Windows.Forms.Button();
            this.couleuradd = new System.Windows.Forms.TextBox();
            this.couleur = new System.Windows.Forms.Label();
            this.lscouleurs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list_couleur
            // 
            this.list_couleur.FormattingEnabled = true;
            this.list_couleur.Location = new System.Drawing.Point(260, 154);
            this.list_couleur.Name = "list_couleur";
            this.list_couleur.Size = new System.Drawing.Size(286, 160);
            this.list_couleur.TabIndex = 0;
            // 
            // ajouter
            // 
            this.ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ajouter.Location = new System.Drawing.Point(260, 339);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(228, 27);
            this.ajouter.TabIndex = 1;
            this.ajouter.Text = "Ajouter une couleur";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.btnAjouterCouleur_Click);
            // 
            // couleurc
            // 
            this.couleurc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.couleurc.Location = new System.Drawing.Point(260, 381);
            this.couleurc.Name = "couleurc";
            this.couleurc.Size = new System.Drawing.Size(228, 27);
            this.couleurc.TabIndex = 2;
            this.couleurc.Text = "Couleurs choisies";
            this.couleurc.UseVisualStyleBackColor = true;
            this.couleurc.Click += new System.EventHandler(this.btncouleurchosie_Click);
            // 
            // supprimers
            // 
            this.supprimers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.supprimers.Location = new System.Drawing.Point(260, 422);
            this.supprimers.Name = "supprimers";
            this.supprimers.Size = new System.Drawing.Size(228, 27);
            this.supprimers.TabIndex = 3;
            this.supprimers.Text = "Supprimer sélection";
            this.supprimers.UseVisualStyleBackColor = true;
            this.supprimers.Click += new System.EventHandler(this.btnsupprimerselection_Click);
            // 
            // supprimerc
            // 
            this.supprimerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.supprimerc.Location = new System.Drawing.Point(260, 465);
            this.supprimerc.Name = "supprimerc";
            this.supprimerc.Size = new System.Drawing.Size(228, 29);
            this.supprimerc.TabIndex = 4;
            this.supprimerc.Text = "Supprimer couleur(s)";
            this.supprimerc.UseVisualStyleBackColor = true;
            // 
            // couleuradd
            // 
            this.couleuradd.Location = new System.Drawing.Point(260, 59);
            this.couleuradd.Name = "couleuradd";
            this.couleuradd.Size = new System.Drawing.Size(294, 20);
            this.couleuradd.TabIndex = 5;
            // 
            // couleur
            // 
            this.couleur.AutoSize = true;
            this.couleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.couleur.Location = new System.Drawing.Point(257, 22);
            this.couleur.Name = "couleur";
            this.couleur.Size = new System.Drawing.Size(109, 31);
            this.couleur.TabIndex = 6;
            this.couleur.Text = "Couleur";
            // 
            // lscouleurs
            // 
            this.lscouleurs.AutoSize = true;
            this.lscouleurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lscouleurs.Location = new System.Drawing.Point(257, 108);
            this.lscouleurs.Name = "lscouleurs";
            this.lscouleurs.Size = new System.Drawing.Size(233, 31);
            this.lscouleurs.TabIndex = 7;
            this.lscouleurs.Text = "Liste des couleurs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 553);
            this.Controls.Add(this.lscouleurs);
            this.Controls.Add(this.couleur);
            this.Controls.Add(this.couleuradd);
            this.Controls.Add(this.supprimerc);
            this.Controls.Add(this.supprimers);
            this.Controls.Add(this.couleurc);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.list_couleur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_couleur;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button couleurc;
        private System.Windows.Forms.Button supprimers;
        private System.Windows.Forms.Button supprimerc;
        private System.Windows.Forms.TextBox couleuradd;
        private System.Windows.Forms.Label couleur;
        private System.Windows.Forms.Label lscouleurs;
    }
}

