namespace Forum_client_lourd
{
    partial class Visiteur
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
            this.grpBxReponse = new System.Windows.Forms.GroupBox();
            this.btQuit = new System.Windows.Forms.Button();
            this.dataGridViewRub = new System.Windows.Forms.DataGridView();
            this.dataGridViewRep = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBxRubriques.SuspendLayout();
            this.grpBxReponse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRep)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBxRubriques
            // 
            this.grpBxRubriques.Controls.Add(this.dataGridViewRub);
            this.grpBxRubriques.Location = new System.Drawing.Point(12, 68);
            this.grpBxRubriques.Name = "grpBxRubriques";
            this.grpBxRubriques.Size = new System.Drawing.Size(984, 181);
            this.grpBxRubriques.TabIndex = 0;
            this.grpBxRubriques.TabStop = false;
            this.grpBxRubriques.Text = "Rubriques";
            // 
            // grpBxReponse
            // 
            this.grpBxReponse.Controls.Add(this.dataGridViewRep);
            this.grpBxReponse.Location = new System.Drawing.Point(12, 275);
            this.grpBxReponse.Name = "grpBxReponse";
            this.grpBxReponse.Size = new System.Drawing.Size(984, 403);
            this.grpBxReponse.TabIndex = 1;
            this.grpBxReponse.TabStop = false;
            this.grpBxReponse.Text = "Réponse(s)";
            // 
            // btQuit
            // 
            this.btQuit.Location = new System.Drawing.Point(921, 694);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(75, 23);
            this.btQuit.TabIndex = 2;
            this.btQuit.Text = "Quitter";
            this.btQuit.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRub
            // 
            this.dataGridViewRub.AllowUserToAddRows = false;
            this.dataGridViewRub.AllowUserToDeleteRows = false;
            this.dataGridViewRub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRub.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewRub.Name = "dataGridViewRub";
            this.dataGridViewRub.ReadOnly = true;
            this.dataGridViewRub.Size = new System.Drawing.Size(978, 162);
            this.dataGridViewRub.TabIndex = 0;
            // 
            // dataGridViewRep
            // 
            this.dataGridViewRep.AllowUserToAddRows = false;
            this.dataGridViewRep.AllowUserToDeleteRows = false;
            this.dataGridViewRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRep.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewRep.Name = "dataGridViewRep";
            this.dataGridViewRep.ReadOnly = true;
            this.dataGridViewRep.Size = new System.Drawing.Size(978, 384);
            this.dataGridViewRep.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consultation du forum de 2ISA";
            // 
            // Visiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.grpBxReponse);
            this.Controls.Add(this.grpBxRubriques);
            this.Name = "Visiteur";
            this.Text = "Visiteur";
            this.grpBxRubriques.ResumeLayout(false);
            this.grpBxReponse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxRubriques;
        private System.Windows.Forms.GroupBox grpBxReponse;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.DataGridView dataGridViewRub;
        private System.Windows.Forms.DataGridView dataGridViewRep;
        private System.Windows.Forms.Label label1;
    }
}