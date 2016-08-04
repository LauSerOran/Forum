namespace Forum_client_lourd
{
    partial class Administrateur
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
            this.lbTitre = new System.Windows.Forms.Label();
            this.tabCtrlAdm = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpBxReponse = new System.Windows.Forms.GroupBox();
            this.btEnvoiReponse = new System.Windows.Forms.Button();
            this.riTxtBxReponse = new System.Windows.Forms.RichTextBox();
            this.lbVotreReponse = new System.Windows.Forms.Label();
            this.dataGrdViRep = new System.Windows.Forms.DataGridView();
            this.grpBxRubriques = new System.Windows.Forms.GroupBox();
            this.txtBxRubrique = new System.Windows.Forms.TextBox();
            this.lbAjoutRubrique = new System.Windows.Forms.Label();
            this.btAjoutImage = new System.Windows.Forms.Button();
            this.btEnvoiSujet = new System.Windows.Forms.Button();
            this.txtBxDescription = new System.Windows.Forms.TextBox();
            this.txtBxSujet = new System.Windows.Forms.TextBox();
            this.lbDescSujet = new System.Windows.Forms.Label();
            this.lbSujetRub = new System.Windows.Forms.Label();
            this.dataGrdViRub = new System.Windows.Forms.DataGridView();
            this.tabPgModif = new System.Windows.Forms.TabPage();
            this.grpBxModifAdm = new System.Windows.Forms.GroupBox();
            this.txtBxModifRubAdm = new System.Windows.Forms.TextBox();
            this.lbModifRubAdm = new System.Windows.Forms.Label();
            this.chkBxModSupprAdm = new System.Windows.Forms.CheckBox();
            this.btModEnrg = new System.Windows.Forms.Button();
            this.lbDescRepAdm = new System.Windows.Forms.Label();
            this.lbModifTitreAdm = new System.Windows.Forms.Label();
            this.ritxtBxDescRepAdm = new System.Windows.Forms.RichTextBox();
            this.txtBxModifTitreAdm = new System.Windows.Forms.TextBox();
            this.grpBxElementCtrlAdm = new System.Windows.Forms.GroupBox();
            this.lbRubAdm = new System.Windows.Forms.Label();
            this.dataGrdViRubrique = new System.Windows.Forms.DataGridView();
            this.lbRepAdm = new System.Windows.Forms.Label();
            this.lbSujetAdm = new System.Windows.Forms.Label();
            this.dataGrdViReponse = new System.Windows.Forms.DataGridView();
            this.dataGrdViSujet = new System.Windows.Forms.DataGridView();
            this.tabCtrlAdm.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpBxReponse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdViRep)).BeginInit();
            this.grpBxRubriques.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdViRub)).BeginInit();
            this.tabPgModif.SuspendLayout();
            this.grpBxModifAdm.SuspendLayout();
            this.grpBxElementCtrlAdm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdViRubrique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdViReponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdViSujet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitre
            // 
            this.lbTitre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.Location = new System.Drawing.Point(411, 13);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(228, 36);
            this.lbTitre.TabIndex = 7;
            this.lbTitre.Text = "Forum de 2ISA";
            // 
            // tabCtrlAdm
            // 
            this.tabCtrlAdm.Controls.Add(this.tabPage1);
            this.tabCtrlAdm.Controls.Add(this.tabPgModif);
            this.tabCtrlAdm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabCtrlAdm.Location = new System.Drawing.Point(0, 66);
            this.tabCtrlAdm.Name = "tabCtrlAdm";
            this.tabCtrlAdm.SelectedIndex = 0;
            this.tabCtrlAdm.Size = new System.Drawing.Size(1008, 663);
            this.tabCtrlAdm.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpBxReponse);
            this.tabPage1.Controls.Add(this.grpBxRubriques);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 637);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consultation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpBxReponse
            // 
            this.grpBxReponse.Controls.Add(this.btEnvoiReponse);
            this.grpBxReponse.Controls.Add(this.riTxtBxReponse);
            this.grpBxReponse.Controls.Add(this.lbVotreReponse);
            this.grpBxReponse.Controls.Add(this.dataGrdViRep);
            this.grpBxReponse.Location = new System.Drawing.Point(10, 288);
            this.grpBxReponse.Name = "grpBxReponse";
            this.grpBxReponse.Size = new System.Drawing.Size(984, 341);
            this.grpBxReponse.TabIndex = 3;
            this.grpBxReponse.TabStop = false;
            this.grpBxReponse.Text = "Réponse(s)";
            // 
            // btEnvoiReponse
            // 
            this.btEnvoiReponse.Location = new System.Drawing.Point(910, 268);
            this.btEnvoiReponse.Name = "btEnvoiReponse";
            this.btEnvoiReponse.Size = new System.Drawing.Size(72, 67);
            this.btEnvoiReponse.TabIndex = 6;
            this.btEnvoiReponse.Text = "Envoyer";
            this.btEnvoiReponse.UseVisualStyleBackColor = true;
            // 
            // riTxtBxReponse
            // 
            this.riTxtBxReponse.Location = new System.Drawing.Point(9, 268);
            this.riTxtBxReponse.Name = "riTxtBxReponse";
            this.riTxtBxReponse.Size = new System.Drawing.Size(893, 67);
            this.riTxtBxReponse.TabIndex = 2;
            this.riTxtBxReponse.Text = "";
            // 
            // lbVotreReponse
            // 
            this.lbVotreReponse.AutoSize = true;
            this.lbVotreReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVotreReponse.Location = new System.Drawing.Point(6, 248);
            this.lbVotreReponse.Name = "lbVotreReponse";
            this.lbVotreReponse.Size = new System.Drawing.Size(106, 17);
            this.lbVotreReponse.TabIndex = 1;
            this.lbVotreReponse.Text = "Votre réponse :";
            // 
            // dataGrdViRep
            // 
            this.dataGrdViRep.AllowUserToAddRows = false;
            this.dataGrdViRep.AllowUserToDeleteRows = false;
            this.dataGrdViRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrdViRep.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGrdViRep.Location = new System.Drawing.Point(3, 16);
            this.dataGrdViRep.Name = "dataGrdViRep";
            this.dataGrdViRep.ReadOnly = true;
            this.dataGrdViRep.Size = new System.Drawing.Size(978, 229);
            this.dataGrdViRep.TabIndex = 0;
            // 
            // grpBxRubriques
            // 
            this.grpBxRubriques.Controls.Add(this.txtBxRubrique);
            this.grpBxRubriques.Controls.Add(this.lbAjoutRubrique);
            this.grpBxRubriques.Controls.Add(this.btAjoutImage);
            this.grpBxRubriques.Controls.Add(this.btEnvoiSujet);
            this.grpBxRubriques.Controls.Add(this.txtBxDescription);
            this.grpBxRubriques.Controls.Add(this.txtBxSujet);
            this.grpBxRubriques.Controls.Add(this.lbDescSujet);
            this.grpBxRubriques.Controls.Add(this.lbSujetRub);
            this.grpBxRubriques.Controls.Add(this.dataGrdViRub);
            this.grpBxRubriques.Location = new System.Drawing.Point(10, 16);
            this.grpBxRubriques.Name = "grpBxRubriques";
            this.grpBxRubriques.Size = new System.Drawing.Size(984, 266);
            this.grpBxRubriques.TabIndex = 2;
            this.grpBxRubriques.TabStop = false;
            this.grpBxRubriques.Text = "Rubriques";
            // 
            // txtBxRubrique
            // 
            this.txtBxRubrique.Location = new System.Drawing.Point(86, 190);
            this.txtBxRubrique.Multiline = true;
            this.txtBxRubrique.Name = "txtBxRubrique";
            this.txtBxRubrique.Size = new System.Drawing.Size(257, 32);
            this.txtBxRubrique.TabIndex = 8;
            // 
            // lbAjoutRubrique
            // 
            this.lbAjoutRubrique.AutoSize = true;
            this.lbAjoutRubrique.Location = new System.Drawing.Point(0, 181);
            this.lbAjoutRubrique.Name = "lbAjoutRubrique";
            this.lbAjoutRubrique.Size = new System.Drawing.Size(79, 13);
            this.lbAjoutRubrique.TabIndex = 7;
            this.lbAjoutRubrique.Text = "Votre rubrique :";
            // 
            // btAjoutImage
            // 
            this.btAjoutImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btAjoutImage.Location = new System.Drawing.Point(349, 237);
            this.btAjoutImage.Name = "btAjoutImage";
            this.btAjoutImage.Size = new System.Drawing.Size(165, 23);
            this.btAjoutImage.TabIndex = 6;
            this.btAjoutImage.Text = "Ajouter une image";
            this.btAjoutImage.UseVisualStyleBackColor = false;
            // 
            // btEnvoiSujet
            // 
            this.btEnvoiSujet.Location = new System.Drawing.Point(906, 198);
            this.btEnvoiSujet.Name = "btEnvoiSujet";
            this.btEnvoiSujet.Size = new System.Drawing.Size(72, 62);
            this.btEnvoiSujet.TabIndex = 5;
            this.btEnvoiSujet.Text = "Envoyer";
            this.btEnvoiSujet.UseVisualStyleBackColor = true;
            // 
            // txtBxDescription
            // 
            this.txtBxDescription.Location = new System.Drawing.Point(520, 198);
            this.txtBxDescription.Multiline = true;
            this.txtBxDescription.Name = "txtBxDescription";
            this.txtBxDescription.Size = new System.Drawing.Size(382, 62);
            this.txtBxDescription.TabIndex = 4;
            // 
            // txtBxSujet
            // 
            this.txtBxSujet.Location = new System.Drawing.Point(86, 228);
            this.txtBxSujet.Multiline = true;
            this.txtBxSujet.Name = "txtBxSujet";
            this.txtBxSujet.Size = new System.Drawing.Size(257, 32);
            this.txtBxSujet.TabIndex = 3;
            // 
            // lbDescSujet
            // 
            this.lbDescSujet.AutoSize = true;
            this.lbDescSujet.Location = new System.Drawing.Point(448, 198);
            this.lbDescSujet.Name = "lbDescSujet";
            this.lbDescSujet.Size = new System.Drawing.Size(66, 13);
            this.lbDescSujet.TabIndex = 2;
            this.lbDescSujet.Text = "Description :";
            // 
            // lbSujetRub
            // 
            this.lbSujetRub.AutoSize = true;
            this.lbSujetRub.Location = new System.Drawing.Point(0, 228);
            this.lbSujetRub.Name = "lbSujetRub";
            this.lbSujetRub.Size = new System.Drawing.Size(63, 13);
            this.lbSujetRub.TabIndex = 1;
            this.lbSujetRub.Text = "Votre sujet :";
            // 
            // dataGrdViRub
            // 
            this.dataGrdViRub.AllowUserToAddRows = false;
            this.dataGrdViRub.AllowUserToDeleteRows = false;
            this.dataGrdViRub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrdViRub.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGrdViRub.Location = new System.Drawing.Point(3, 16);
            this.dataGrdViRub.Name = "dataGrdViRub";
            this.dataGrdViRub.ReadOnly = true;
            this.dataGrdViRub.Size = new System.Drawing.Size(978, 162);
            this.dataGrdViRub.TabIndex = 0;
            // 
            // tabPgModif
            // 
            this.tabPgModif.Controls.Add(this.grpBxModifAdm);
            this.tabPgModif.Controls.Add(this.grpBxElementCtrlAdm);
            this.tabPgModif.Location = new System.Drawing.Point(4, 22);
            this.tabPgModif.Name = "tabPgModif";
            this.tabPgModif.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgModif.Size = new System.Drawing.Size(1000, 637);
            this.tabPgModif.TabIndex = 1;
            this.tabPgModif.Text = "Modération";
            this.tabPgModif.UseVisualStyleBackColor = true;
            // 
            // grpBxModifAdm
            // 
            this.grpBxModifAdm.Controls.Add(this.txtBxModifRubAdm);
            this.grpBxModifAdm.Controls.Add(this.lbModifRubAdm);
            this.grpBxModifAdm.Controls.Add(this.chkBxModSupprAdm);
            this.grpBxModifAdm.Controls.Add(this.btModEnrg);
            this.grpBxModifAdm.Controls.Add(this.lbDescRepAdm);
            this.grpBxModifAdm.Controls.Add(this.lbModifTitreAdm);
            this.grpBxModifAdm.Controls.Add(this.ritxtBxDescRepAdm);
            this.grpBxModifAdm.Controls.Add(this.txtBxModifTitreAdm);
            this.grpBxModifAdm.Location = new System.Drawing.Point(8, 389);
            this.grpBxModifAdm.Name = "grpBxModifAdm";
            this.grpBxModifAdm.Size = new System.Drawing.Size(973, 240);
            this.grpBxModifAdm.TabIndex = 1;
            this.grpBxModifAdm.TabStop = false;
            this.grpBxModifAdm.Text = "Validation/modification/suppression";
            // 
            // txtBxModifRubAdm
            // 
            this.txtBxModifRubAdm.Location = new System.Drawing.Point(125, 44);
            this.txtBxModifRubAdm.Multiline = true;
            this.txtBxModifRubAdm.Name = "txtBxModifRubAdm";
            this.txtBxModifRubAdm.Size = new System.Drawing.Size(718, 41);
            this.txtBxModifRubAdm.TabIndex = 7;
            // 
            // lbModifRubAdm
            // 
            this.lbModifRubAdm.AutoSize = true;
            this.lbModifRubAdm.Location = new System.Drawing.Point(23, 44);
            this.lbModifRubAdm.Name = "lbModifRubAdm";
            this.lbModifRubAdm.Size = new System.Drawing.Size(50, 13);
            this.lbModifRubAdm.TabIndex = 6;
            this.lbModifRubAdm.Text = "Rubrique";
            // 
            // chkBxModSupprAdm
            // 
            this.chkBxModSupprAdm.AutoSize = true;
            this.chkBxModSupprAdm.BackColor = System.Drawing.Color.DarkRed;
            this.chkBxModSupprAdm.ForeColor = System.Drawing.Color.Yellow;
            this.chkBxModSupprAdm.Location = new System.Drawing.Point(883, 151);
            this.chkBxModSupprAdm.Name = "chkBxModSupprAdm";
            this.chkBxModSupprAdm.Size = new System.Drawing.Size(84, 17);
            this.chkBxModSupprAdm.TabIndex = 5;
            this.chkBxModSupprAdm.Text = "Suppression";
            this.chkBxModSupprAdm.UseVisualStyleBackColor = false;
            // 
            // btModEnrg
            // 
            this.btModEnrg.Location = new System.Drawing.Point(850, 186);
            this.btModEnrg.Name = "btModEnrg";
            this.btModEnrg.Size = new System.Drawing.Size(117, 38);
            this.btModEnrg.TabIndex = 4;
            this.btModEnrg.Text = "Enregistrer";
            this.btModEnrg.UseVisualStyleBackColor = true;
            this.btModEnrg.Click += new System.EventHandler(this.btModEnrg_Click);
            // 
            // lbDescRepAdm
            // 
            this.lbDescRepAdm.AutoSize = true;
            this.lbDescRepAdm.Location = new System.Drawing.Point(16, 140);
            this.lbDescRepAdm.Name = "lbDescRepAdm";
            this.lbDescRepAdm.Size = new System.Drawing.Size(103, 13);
            this.lbDescRepAdm.TabIndex = 3;
            this.lbDescRepAdm.Text = "Description/réponse";
            // 
            // lbModifTitreAdm
            // 
            this.lbModifTitreAdm.AutoSize = true;
            this.lbModifTitreAdm.Location = new System.Drawing.Point(16, 91);
            this.lbModifTitreAdm.Name = "lbModifTitreAdm";
            this.lbModifTitreAdm.Size = new System.Drawing.Size(31, 13);
            this.lbModifTitreAdm.TabIndex = 2;
            this.lbModifTitreAdm.Text = "Titre ";
            // 
            // ritxtBxDescRepAdm
            // 
            this.ritxtBxDescRepAdm.Location = new System.Drawing.Point(125, 137);
            this.ritxtBxDescRepAdm.Name = "ritxtBxDescRepAdm";
            this.ritxtBxDescRepAdm.Size = new System.Drawing.Size(719, 87);
            this.ritxtBxDescRepAdm.TabIndex = 1;
            this.ritxtBxDescRepAdm.Text = "";
            // 
            // txtBxModifTitreAdm
            // 
            this.txtBxModifTitreAdm.Location = new System.Drawing.Point(125, 91);
            this.txtBxModifTitreAdm.Multiline = true;
            this.txtBxModifTitreAdm.Name = "txtBxModifTitreAdm";
            this.txtBxModifTitreAdm.Size = new System.Drawing.Size(719, 40);
            this.txtBxModifTitreAdm.TabIndex = 0;
            // 
            // grpBxElementCtrlAdm
            // 
            this.grpBxElementCtrlAdm.Controls.Add(this.lbRubAdm);
            this.grpBxElementCtrlAdm.Controls.Add(this.dataGrdViRubrique);
            this.grpBxElementCtrlAdm.Controls.Add(this.lbRepAdm);
            this.grpBxElementCtrlAdm.Controls.Add(this.lbSujetAdm);
            this.grpBxElementCtrlAdm.Controls.Add(this.dataGrdViReponse);
            this.grpBxElementCtrlAdm.Controls.Add(this.dataGrdViSujet);
            this.grpBxElementCtrlAdm.Location = new System.Drawing.Point(8, 15);
            this.grpBxElementCtrlAdm.Name = "grpBxElementCtrlAdm";
            this.grpBxElementCtrlAdm.Size = new System.Drawing.Size(984, 352);
            this.grpBxElementCtrlAdm.TabIndex = 0;
            this.grpBxElementCtrlAdm.TabStop = false;
            this.grpBxElementCtrlAdm.Text = "Listes des éléments à contrôler";
            // 
            // lbRubAdm
            // 
            this.lbRubAdm.AutoSize = true;
            this.lbRubAdm.Location = new System.Drawing.Point(22, 44);
            this.lbRubAdm.Name = "lbRubAdm";
            this.lbRubAdm.Size = new System.Drawing.Size(61, 13);
            this.lbRubAdm.TabIndex = 5;
            this.lbRubAdm.Text = "Rubrique(s)";
            // 
            // dataGrdViRubrique
            // 
            this.dataGrdViRubrique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrdViRubrique.Location = new System.Drawing.Point(6, 61);
            this.dataGrdViRubrique.Name = "dataGrdViRubrique";
            this.dataGrdViRubrique.Size = new System.Drawing.Size(240, 285);
            this.dataGrdViRubrique.TabIndex = 4;
            this.dataGrdViRubrique.MouseHover += new System.EventHandler(this.dataGrdViRubrique_MouseHover);
            // 
            // lbRepAdm
            // 
            this.lbRepAdm.AutoSize = true;
            this.lbRepAdm.Location = new System.Drawing.Point(611, 42);
            this.lbRepAdm.Name = "lbRepAdm";
            this.lbRepAdm.Size = new System.Drawing.Size(64, 13);
            this.lbRepAdm.TabIndex = 3;
            this.lbRepAdm.Text = "Réponse(s) ";
            // 
            // lbSujetAdm
            // 
            this.lbSujetAdm.AutoSize = true;
            this.lbSujetAdm.Location = new System.Drawing.Point(249, 42);
            this.lbSujetAdm.Name = "lbSujetAdm";
            this.lbSujetAdm.Size = new System.Drawing.Size(45, 13);
            this.lbSujetAdm.TabIndex = 2;
            this.lbSujetAdm.Text = "Sujet(s) ";
            // 
            // dataGrdViReponse
            // 
            this.dataGrdViReponse.AllowUserToAddRows = false;
            this.dataGrdViReponse.AllowUserToDeleteRows = false;
            this.dataGrdViReponse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrdViReponse.Location = new System.Drawing.Point(614, 61);
            this.dataGrdViReponse.Name = "dataGrdViReponse";
            this.dataGrdViReponse.ReadOnly = true;
            this.dataGrdViReponse.Size = new System.Drawing.Size(359, 285);
            this.dataGrdViReponse.TabIndex = 1;
            this.dataGrdViReponse.MouseHover += new System.EventHandler(this.dataGrdViReponse_MouseHover);
            // 
            // dataGrdViSujet
            // 
            this.dataGrdViSujet.AllowUserToAddRows = false;
            this.dataGrdViSujet.AllowUserToDeleteRows = false;
            this.dataGrdViSujet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrdViSujet.Location = new System.Drawing.Point(252, 61);
            this.dataGrdViSujet.Name = "dataGrdViSujet";
            this.dataGrdViSujet.ReadOnly = true;
            this.dataGrdViSujet.Size = new System.Drawing.Size(356, 285);
            this.dataGrdViSujet.TabIndex = 0;
            this.dataGrdViSujet.MouseHover += new System.EventHandler(this.dataGrdViSujet_MouseHover);
            // 
            // Administrateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.lbTitre);
            this.Controls.Add(this.tabCtrlAdm);
            this.Name = "Administrateur";
            this.Text = "Administrateur";
            this.tabCtrlAdm.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpBxReponse.ResumeLayout(false);
            this.grpBxReponse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdViRep)).EndInit();
            this.grpBxRubriques.ResumeLayout(false);
            this.grpBxRubriques.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdViRub)).EndInit();
            this.tabPgModif.ResumeLayout(false);
            this.grpBxModifAdm.ResumeLayout(false);
            this.grpBxModifAdm.PerformLayout();
            this.grpBxElementCtrlAdm.ResumeLayout(false);
            this.grpBxElementCtrlAdm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdViRubrique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdViReponse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdViSujet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.TabControl tabCtrlAdm;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpBxReponse;
        private System.Windows.Forms.Button btEnvoiReponse;
        private System.Windows.Forms.RichTextBox riTxtBxReponse;
        private System.Windows.Forms.Label lbVotreReponse;
        private System.Windows.Forms.DataGridView dataGrdViRep;
        private System.Windows.Forms.GroupBox grpBxRubriques;
        private System.Windows.Forms.Button btAjoutImage;
        private System.Windows.Forms.Button btEnvoiSujet;
        private System.Windows.Forms.TextBox txtBxDescription;
        private System.Windows.Forms.TextBox txtBxSujet;
        private System.Windows.Forms.Label lbDescSujet;
        private System.Windows.Forms.Label lbSujetRub;
        private System.Windows.Forms.DataGridView dataGrdViRub;
        private System.Windows.Forms.TabPage tabPgModif;
        private System.Windows.Forms.GroupBox grpBxModifAdm;
        private System.Windows.Forms.CheckBox chkBxModSupprAdm;
        private System.Windows.Forms.Button btModEnrg;
        private System.Windows.Forms.Label lbDescRepAdm;
        private System.Windows.Forms.Label lbModifTitreAdm;
        private System.Windows.Forms.RichTextBox ritxtBxDescRepAdm;
        private System.Windows.Forms.TextBox txtBxModifTitreAdm;
        private System.Windows.Forms.GroupBox grpBxElementCtrlAdm;
        private System.Windows.Forms.Label lbRepAdm;
        private System.Windows.Forms.Label lbSujetAdm;
        private System.Windows.Forms.DataGridView dataGrdViReponse;
        private System.Windows.Forms.DataGridView dataGrdViSujet;
        private System.Windows.Forms.DataGridView dataGrdViRubrique;
        private System.Windows.Forms.Label lbRubAdm;
        private System.Windows.Forms.Label lbModifRubAdm;
        private System.Windows.Forms.TextBox txtBxModifRubAdm;
        private System.Windows.Forms.TextBox txtBxRubrique;
        private System.Windows.Forms.Label lbAjoutRubrique;
    }
}