﻿namespace Forum_client_lourd
{
    partial class Accueil
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
            this.btConnect = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.lbMdp = new System.Windows.Forms.Label();
            this.txtBxIdentifiant = new System.Windows.Forms.TextBox();
            this.txtBxMotDePasse = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.chkBxVisiteur = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.BackColor = System.Drawing.Color.LimeGreen;
            this.btConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConnect.ForeColor = System.Drawing.Color.Yellow;
            this.btConnect.Location = new System.Drawing.Point(106, 184);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(91, 31);
            this.btConnect.TabIndex = 0;
            this.btConnect.Text = "Se connecter";
            this.btConnect.UseVisualStyleBackColor = false;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(47, 76);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(59, 13);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "Identifiant :";
            // 
            // lbMdp
            // 
            this.lbMdp.AutoSize = true;
            this.lbMdp.Location = new System.Drawing.Point(47, 124);
            this.lbMdp.Name = "lbMdp";
            this.lbMdp.Size = new System.Drawing.Size(77, 13);
            this.lbMdp.TabIndex = 2;
            this.lbMdp.Text = "Mot de passe :";
            // 
            // txtBxIdentifiant
            // 
            this.txtBxIdentifiant.Location = new System.Drawing.Point(142, 73);
            this.txtBxIdentifiant.Name = "txtBxIdentifiant";
            this.txtBxIdentifiant.Size = new System.Drawing.Size(100, 20);
            this.txtBxIdentifiant.TabIndex = 3;
            // 
            // txtBxMotDePasse
            // 
            this.txtBxMotDePasse.Location = new System.Drawing.Point(142, 121);
            this.txtBxMotDePasse.Name = "txtBxMotDePasse";
            this.txtBxMotDePasse.Size = new System.Drawing.Size(100, 20);
            this.txtBxMotDePasse.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "test2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chkBxVisiteur
            // 
            this.chkBxVisiteur.AutoSize = true;
            this.chkBxVisiteur.Location = new System.Drawing.Point(106, 161);
            this.chkBxVisiteur.Name = "chkBxVisiteur";
            this.chkBxVisiteur.Size = new System.Drawing.Size(60, 17);
            this.chkBxVisiteur.TabIndex = 8;
            this.chkBxVisiteur.Text = "Visiteur";
            this.chkBxVisiteur.UseVisualStyleBackColor = true;
            this.chkBxVisiteur.CheckedChanged += new System.EventHandler(this.chkBxVisiteur_CheckedChanged);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.chkBxVisiteur);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtBxMotDePasse);
            this.Controls.Add(this.txtBxIdentifiant);
            this.Controls.Add(this.lbMdp);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.btConnect);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbMdp;
        private System.Windows.Forms.TextBox txtBxIdentifiant;
        private System.Windows.Forms.TextBox txtBxMotDePasse;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox chkBxVisiteur;
    }
}

