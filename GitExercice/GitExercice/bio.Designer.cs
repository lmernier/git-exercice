namespace GitExercice
{
    partial class bio
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.Nb1 = new System.Windows.Forms.TextBox();
            this.Nb2 = new System.Windows.Forms.TextBox();
            this.Rep = new System.Windows.Forms.TextBox();
            this.Compute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(582, 373);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(126, 60);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nb1
            // 
            this.Nb1.Location = new System.Drawing.Point(269, 98);
            this.Nb1.Name = "Nb1";
            this.Nb1.Size = new System.Drawing.Size(35, 20);
            this.Nb1.TabIndex = 1;
            // 
            // Nb2
            // 
            this.Nb2.Location = new System.Drawing.Point(269, 145);
            this.Nb2.Name = "Nb2";
            this.Nb2.Size = new System.Drawing.Size(35, 20);
            this.Nb2.TabIndex = 2;
            // 
            // Rep
            // 
            this.Rep.Location = new System.Drawing.Point(426, 125);
            this.Rep.Name = "Rep";
            this.Rep.Size = new System.Drawing.Size(130, 20);
            this.Rep.TabIndex = 3;
            // 
            // Compute
            // 
            this.Compute.Location = new System.Drawing.Point(334, 119);
            this.Compute.Name = "Compute";
            this.Compute.Size = new System.Drawing.Size(64, 30);
            this.Compute.TabIndex = 4;
            this.Compute.Text = "Addition";
            this.Compute.UseVisualStyleBackColor = true;
            this.Compute.Click += new System.EventHandler(this.Compute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "nombre un";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "nombre deux";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "resultat";
            // 
            // bio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Compute);
            this.Controls.Add(this.Rep);
            this.Controls.Add(this.Nb2);
            this.Controls.Add(this.Nb1);
            this.Controls.Add(this.BtnClose);
            this.Name = "bio";
            this.Text = "bio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox Nb1;
        private System.Windows.Forms.TextBox Nb2;
        private System.Windows.Forms.TextBox Rep;
        private System.Windows.Forms.Button Compute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}