namespace Databinding
{
    partial class Databinding
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
            this.dgvArtiste = new System.Windows.Forms.DataGridView();
            this.dgvChanson = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtiste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChanson)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtiste
            // 
            this.dgvArtiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtiste.Location = new System.Drawing.Point(13, 13);
            this.dgvArtiste.Name = "dgvArtiste";
            this.dgvArtiste.RowHeadersWidth = 51;
            this.dgvArtiste.RowTemplate.Height = 24;
            this.dgvArtiste.Size = new System.Drawing.Size(260, 376);
            this.dgvArtiste.TabIndex = 0;
            // 
            // dgvChanson
            // 
            this.dgvChanson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChanson.Location = new System.Drawing.Point(279, 13);
            this.dgvChanson.Name = "dgvChanson";
            this.dgvChanson.RowHeadersWidth = 51;
            this.dgvChanson.RowTemplate.Height = 24;
            this.dgvChanson.Size = new System.Drawing.Size(260, 376);
            this.dgvChanson.TabIndex = 1;
            // 
            // Databinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvChanson);
            this.Controls.Add(this.dgvArtiste);
            this.Name = "Databinding";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtiste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChanson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtiste;
        private System.Windows.Forms.DataGridView dgvChanson;
    }
}

