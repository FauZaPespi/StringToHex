namespace P_UTF_8_HEX
{
    partial class Frm_StringHex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_StringHex));
            this.tbxString = new System.Windows.Forms.TextBox();
            this.tbxHex = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxString
            // 
            this.tbxString.Location = new System.Drawing.Point(12, 12);
            this.tbxString.Multiline = true;
            this.tbxString.Name = "tbxString";
            this.tbxString.Size = new System.Drawing.Size(776, 96);
            this.tbxString.TabIndex = 0;
            this.tbxString.TextChanged += new System.EventHandler(this.tbxString_TextChanged);
            // 
            // tbxHex
            // 
            this.tbxHex.Location = new System.Drawing.Point(12, 224);
            this.tbxHex.Multiline = true;
            this.tbxHex.Name = "tbxHex";
            this.tbxHex.ReadOnly = true;
            this.tbxHex.Size = new System.Drawing.Size(776, 96);
            this.tbxHex.TabIndex = 1;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(271, 145);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(259, 42);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Convertir Hex";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_StringHex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 333);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.tbxHex);
            this.Controls.Add(this.tbxString);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 372);
            this.MinimumSize = new System.Drawing.Size(816, 372);
            this.Name = "Frm_StringHex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convertiseur de text en hexadécimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxString;
        private System.Windows.Forms.TextBox tbxHex;
        private System.Windows.Forms.Label lblInfo;
    }
}

