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
            this.Btn_GoToHK = new System.Windows.Forms.Button();
            this.buttonOui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_GoToHK
            // 
            this.Btn_GoToHK.Location = new System.Drawing.Point(612, 378);
            this.Btn_GoToHK.Name = "Btn_GoToHK";
            this.Btn_GoToHK.Size = new System.Drawing.Size(176, 60);
            this.Btn_GoToHK.TabIndex = 0;
            this.Btn_GoToHK.Text = "Hugo Kinif";
            this.Btn_GoToHK.UseVisualStyleBackColor = true;
            this.Btn_GoToHK.Click += new System.EventHandler(this.Btn_GoToHK_Click);
            // 
            // buttonOui
            // 
            this.buttonOui.Location = new System.Drawing.Point(612, 63);
            this.buttonOui.Name = "buttonOui";
            this.buttonOui.Size = new System.Drawing.Size(75, 23);
            this.buttonOui.TabIndex = 1;
            this.buttonOui.Text = "Oui.";
            this.buttonOui.UseVisualStyleBackColor = true;
            this.buttonOui.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOui);
            this.Controls.Add(this.Btn_GoToHK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_GoToHK;
        private System.Windows.Forms.Button buttonOui;
    }
}

