namespace GitExercice
{
    partial class FormZozie
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
            this.rndBtnRien = new System.Windows.Forms.RadioButton();
            this.rndBtnQuoi = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rndBtnRien
            // 
            this.rndBtnRien.AutoSize = true;
            this.rndBtnRien.Location = new System.Drawing.Point(294, 64);
            this.rndBtnRien.Name = "rndBtnRien";
            this.rndBtnRien.Size = new System.Drawing.Size(31, 17);
            this.rndBtnRien.TabIndex = 0;
            this.rndBtnRien.TabStop = true;
            this.rndBtnRien.Text = "1";
            this.rndBtnRien.UseVisualStyleBackColor = true;
            this.rndBtnRien.CheckedChanged += new System.EventHandler(this.rndBtnRien_CheckedChanged);
            // 
            // rndBtnQuoi
            // 
            this.rndBtnQuoi.AutoSize = true;
            this.rndBtnQuoi.Location = new System.Drawing.Point(294, 138);
            this.rndBtnQuoi.Name = "rndBtnQuoi";
            this.rndBtnQuoi.Size = new System.Drawing.Size(31, 17);
            this.rndBtnQuoi.TabIndex = 1;
            this.rndBtnQuoi.TabStop = true;
            this.rndBtnQuoi.Text = "2";
            this.rndBtnQuoi.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormZozie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rndBtnQuoi);
            this.Controls.Add(this.rndBtnRien);
            this.Name = "FormZozie";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rndBtnRien;
        private System.Windows.Forms.RadioButton rndBtnQuoi;
        private System.Windows.Forms.Button button1;
    }
}