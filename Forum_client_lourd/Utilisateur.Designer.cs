namespace Forum_client_lourd
{
    partial class Utilisateur
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
            this.grpBxRubriques = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btEnvoiSujet = new System.Windows.Forms.Button();
            this.txtBxDescription = new System.Windows.Forms.TextBox();
            this.txtBxSujet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewRub = new System.Windows.Forms.DataGridView();
            this.grpBxReponse = new System.Windows.Forms.GroupBox();
            this.btEnvoiReponse = new System.Windows.Forms.Button();
            this.riTxtBxReponse = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewRep = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpBxRubriques.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRub)).BeginInit();
            this.grpBxReponse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRep)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBxRubriques
            // 
            this.grpBxRubriques.Controls.Add(this.button3);
            this.grpBxRubriques.Controls.Add(this.btEnvoiSujet);
            this.grpBxRubriques.Controls.Add(this.txtBxDescription);
            this.grpBxRubriques.Controls.Add(this.txtBxSujet);
            this.grpBxRubriques.Controls.Add(this.label4);
            this.grpBxRubriques.Controls.Add(this.label3);
            this.grpBxRubriques.Controls.Add(this.dataGridViewRub);
            this.grpBxRubriques.Location = new System.Drawing.Point(12, 57);
            this.grpBxRubriques.Name = "grpBxRubriques";
            this.grpBxRubriques.Size = new System.Drawing.Size(984, 266);
            this.grpBxRubriques.TabIndex = 1;
            this.grpBxRubriques.TabStop = false;
            this.grpBxRubriques.Text = "Rubriques";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Location = new System.Drawing.Point(349, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Ajouter une image";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.txtBxSujet.Location = new System.Drawing.Point(66, 198);
            this.txtBxSujet.Multiline = true;
            this.txtBxSujet.Name = "txtBxSujet";
            this.txtBxSujet.Size = new System.Drawing.Size(277, 62);
            this.txtBxSujet.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Votre sujet :";
            // 
            // dataGridViewRub
            // 
            this.dataGridViewRub.AllowUserToAddRows = false;
            this.dataGridViewRub.AllowUserToDeleteRows = false;
            this.dataGridViewRub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRub.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewRub.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewRub.Name = "dataGridViewRub";
            this.dataGridViewRub.ReadOnly = true;
            this.dataGridViewRub.Size = new System.Drawing.Size(978, 162);
            this.dataGridViewRub.TabIndex = 0;
            // 
            // grpBxReponse
            // 
            this.grpBxReponse.Controls.Add(this.btEnvoiReponse);
            this.grpBxReponse.Controls.Add(this.riTxtBxReponse);
            this.grpBxReponse.Controls.Add(this.label1);
            this.grpBxReponse.Controls.Add(this.dataGridViewRep);
            this.grpBxReponse.Location = new System.Drawing.Point(15, 329);
            this.grpBxReponse.Name = "grpBxReponse";
            this.grpBxReponse.Size = new System.Drawing.Size(984, 384);
            this.grpBxReponse.TabIndex = 2;
            this.grpBxReponse.TabStop = false;
            this.grpBxReponse.Text = "Réponse(s)";
            // 
            // btEnvoiReponse
            // 
            this.btEnvoiReponse.Location = new System.Drawing.Point(903, 311);
            this.btEnvoiReponse.Name = "btEnvoiReponse";
            this.btEnvoiReponse.Size = new System.Drawing.Size(72, 67);
            this.btEnvoiReponse.TabIndex = 6;
            this.btEnvoiReponse.Text = "Envoyer";
            this.btEnvoiReponse.UseVisualStyleBackColor = true;
            // 
            // riTxtBxReponse
            // 
            this.riTxtBxReponse.Location = new System.Drawing.Point(6, 311);
            this.riTxtBxReponse.Name = "riTxtBxReponse";
            this.riTxtBxReponse.Size = new System.Drawing.Size(893, 67);
            this.riTxtBxReponse.TabIndex = 2;
            this.riTxtBxReponse.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Votre réponse :";
            // 
            // dataGridViewRep
            // 
            this.dataGridViewRep.AllowUserToAddRows = false;
            this.dataGridViewRep.AllowUserToDeleteRows = false;
            this.dataGridViewRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRep.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewRep.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewRep.Name = "dataGridViewRep";
            this.dataGridViewRep.ReadOnly = true;
            this.dataGridViewRep.Size = new System.Drawing.Size(978, 272);
            this.dataGridViewRep.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Forum de 2ISA";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Utilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 725);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpBxReponse);
            this.Controls.Add(this.grpBxRubriques);
            this.Name = "Utilisateur";
            this.Text = "Utilisateur";
            this.grpBxRubriques.ResumeLayout(false);
            this.grpBxRubriques.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRub)).EndInit();
            this.grpBxReponse.ResumeLayout(false);
            this.grpBxReponse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxRubriques;
        private System.Windows.Forms.DataGridView dataGridViewRub;
        private System.Windows.Forms.GroupBox grpBxReponse;
        private System.Windows.Forms.RichTextBox riTxtBxReponse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewRep;
        private System.Windows.Forms.TextBox txtBxDescription;
        private System.Windows.Forms.TextBox txtBxSujet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btEnvoiSujet;
        private System.Windows.Forms.Button btEnvoiReponse;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}