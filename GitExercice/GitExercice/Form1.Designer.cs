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
<<<<<<< HEAD
            this.univerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // univerBtn
            // 
            this.univerBtn.Location = new System.Drawing.Point(567, 143);
            this.univerBtn.Name = "univerBtn";
            this.univerBtn.Size = new System.Drawing.Size(179, 68);
            this.univerBtn.TabIndex = 0;
            this.univerBtn.Text = "Univer";
            this.univerBtn.UseVisualStyleBackColor = true;
            this.univerBtn.Click += new System.EventHandler(this.univerBtn_Click);
=======
            this.cringe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cringe
            // 
            this.cringe.Location = new System.Drawing.Point(245, 106);
            this.cringe.Name = "cringe";
            this.cringe.Size = new System.Drawing.Size(332, 135);
            this.cringe.TabIndex = 0;
            this.cringe.Text = "cringe";
            this.cringe.UseVisualStyleBackColor = true;
            this.cringe.Click += new System.EventHandler(this.cringe_Click);
            this.buttonOui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOui
            // 
            this.buttonOui.Location = new System.Drawing.Point(2, 12);
            this.buttonOui.Name = "buttonOui";
            this.buttonOui.Size = new System.Drawing.Size(75, 23);
            this.buttonOui.TabIndex = 0;
            this.buttonOui.Text = "oui.";
            this.buttonOui.UseVisualStyleBackColor = true;
            this.buttonOui.Click += new System.EventHandler(this.buttonOui_Click);
>>>>>>> bfd60c546fb22d123513cf20f180fb040956c244
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
<<<<<<< HEAD
            this.Controls.Add(this.univerBtn);
=======
            this.Controls.Add(this.cringe);
            this.Controls.Add(this.buttonOui);
>>>>>>> bfd60c546fb22d123513cf20f180fb040956c244
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.Button univerBtn;
=======
        private System.Windows.Forms.Button cringe;
        private System.Windows.Forms.Button buttonOui;
>>>>>>> bfd60c546fb22d123513cf20f180fb040956c244
    }
}

