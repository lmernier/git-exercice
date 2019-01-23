namespace GitExercice
{
    partial class FormMarie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMarie));
            this.txtQuestionsMath = new System.Windows.Forms.TextBox();
            this.lst = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQuestionsMath
            // 
            this.txtQuestionsMath.BackColor = System.Drawing.Color.Gainsboro;
            this.txtQuestionsMath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuestionsMath.HideSelection = false;
            this.txtQuestionsMath.Location = new System.Drawing.Point(91, 21);
            this.txtQuestionsMath.Name = "txtQuestionsMath";
            this.txtQuestionsMath.ReadOnly = true;
            this.txtQuestionsMath.Size = new System.Drawing.Size(599, 13);
            this.txtQuestionsMath.TabIndex = 0;
            this.txtQuestionsMath.Text = "Combien font 1 + 1 ?";
            this.txtQuestionsMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lst
            // 
            this.lst.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 55;
            this.lst.Location = new System.Drawing.Point(295, 190);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(196, 59);
            this.lst.TabIndex = 1;
            this.lst.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "La réponse est :";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMarie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.txtQuestionsMath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMarie";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.Button button1;
        protected System.Windows.Forms.TextBox txtQuestionsMath;
    }
}

