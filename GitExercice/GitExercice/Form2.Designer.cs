﻿namespace GitExercice
{
    partial class Form2
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
            this.nou = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nou
            // 
            this.nou.Location = new System.Drawing.Point(210, 91);
            this.nou.Name = "nou";
            this.nou.Size = new System.Drawing.Size(244, 146);
            this.nou.TabIndex = 0;
            this.nou.Text = "nou";
            this.nou.UseVisualStyleBackColor = true;
            this.nou.Click += new System.EventHandler(this.nou_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nou);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nou;
    }
}