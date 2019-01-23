namespace GitExercice
{
    partial class UniverForm
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
            this.lorbtn = new System.Windows.Forms.Button();
            this.starwarsbtn = new System.Windows.Forms.Button();
            this.wowbtn = new System.Windows.Forms.Button();
            this.narniabtn = new System.Windows.Forms.Button();
            this.Univers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lorbtn
            // 
            this.lorbtn.Location = new System.Drawing.Point(413, 320);
            this.lorbtn.Name = "lorbtn";
            this.lorbtn.Size = new System.Drawing.Size(208, 77);
            this.lorbtn.TabIndex = 0;
            this.lorbtn.Text = "Le Seigneur Des Anneaux";
            this.lorbtn.UseVisualStyleBackColor = true;
            this.lorbtn.Click += new System.EventHandler(this.lorbtn_Click);
            // 
            // starwarsbtn
            // 
            this.starwarsbtn.Location = new System.Drawing.Point(89, 320);
            this.starwarsbtn.Name = "starwarsbtn";
            this.starwarsbtn.Size = new System.Drawing.Size(207, 78);
            this.starwarsbtn.TabIndex = 1;
            this.starwarsbtn.Text = "Star Wars";
            this.starwarsbtn.UseVisualStyleBackColor = true;
            this.starwarsbtn.Click += new System.EventHandler(this.starwarsbtn_Click);
            // 
            // wowbtn
            // 
            this.wowbtn.Location = new System.Drawing.Point(413, 180);
            this.wowbtn.Name = "wowbtn";
            this.wowbtn.Size = new System.Drawing.Size(205, 75);
            this.wowbtn.TabIndex = 2;
            this.wowbtn.Text = "World Of Warcraft";
            this.wowbtn.UseVisualStyleBackColor = true;
            this.wowbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // narniabtn
            // 
            this.narniabtn.Location = new System.Drawing.Point(89, 183);
            this.narniabtn.Name = "narniabtn";
            this.narniabtn.Size = new System.Drawing.Size(207, 72);
            this.narniabtn.TabIndex = 3;
            this.narniabtn.Text = "Narnia";
            this.narniabtn.UseVisualStyleBackColor = true;
            this.narniabtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // Univers
            // 
            this.Univers.AutoSize = true;
            this.Univers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Univers.ForeColor = System.Drawing.Color.DarkRed;
            this.Univers.Location = new System.Drawing.Point(12, 94);
            this.Univers.Name = "Univers";
            this.Univers.Size = new System.Drawing.Size(449, 37);
            this.Univers.TabIndex = 4;
            this.Univers.Text = "Quel est votre Univer préféré ?";
            this.Univers.Click += new System.EventHandler(this.label1_Click);
            // 
            // UniverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Univers);
            this.Controls.Add(this.narniabtn);
            this.Controls.Add(this.wowbtn);
            this.Controls.Add(this.starwarsbtn);
            this.Controls.Add(this.lorbtn);
            this.Name = "UniverForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lorbtn;
        private System.Windows.Forms.Button starwarsbtn;
        private System.Windows.Forms.Button wowbtn;
        private System.Windows.Forms.Button narniabtn;
        private System.Windows.Forms.Label Univers;
    }
}

