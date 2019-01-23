namespace GitExercice
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
            this.BtnQtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnQtn
            // 
            this.BtnQtn.Location = new System.Drawing.Point(13, 13);
            this.BtnQtn.Name = "BtnQtn";
            this.BtnQtn.Size = new System.Drawing.Size(165, 46);
            this.BtnQtn.TabIndex = 0;
            this.BtnQtn.Text = "Quentin";
            this.BtnQtn.UseVisualStyleBackColor = true;
            this.BtnQtn.Click += new System.EventHandler(this.BtnQtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnQtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnQtn;
    }
}

