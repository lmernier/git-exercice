namespace GitExercice
{
    partial class Form1
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
            this.univerBtn = new System.Windows.Forms.Button();
            this.BtnQtn = new System.Windows.Forms.Button();
            this.cringe = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonOui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // univerBtn
            // 
            this.univerBtn.Location = new System.Drawing.Point(2, 238);
            this.univerBtn.Name = "univerBtn";
            this.univerBtn.Size = new System.Drawing.Size(180, 60);
            this.univerBtn.TabIndex = 0;
            this.univerBtn.Text = "Univer";
            this.univerBtn.UseVisualStyleBackColor = true;
            this.univerBtn.Click += new System.EventHandler(this.univerBtn_Click);
            // 
            // BtnQtn
            // 
            this.BtnQtn.Location = new System.Drawing.Point(2, 67);
            this.BtnQtn.Name = "BtnQtn";
            this.BtnQtn.Size = new System.Drawing.Size(180, 52);
            this.BtnQtn.TabIndex = 0;
            this.BtnQtn.Text = "Quentin";
            this.BtnQtn.UseVisualStyleBackColor = true;
            this.BtnQtn.Click += new System.EventHandler(this.BtnQtn_Click);
            // 
            // cringe
            // 
            this.cringe.Location = new System.Drawing.Point(2, 182);
            this.cringe.Name = "cringe";
            this.cringe.Size = new System.Drawing.Size(180, 50);
            this.cringe.TabIndex = 0;
            this.cringe.Text = "cringe";
            this.cringe.UseVisualStyleBackColor = true;
            this.cringe.Click += new System.EventHandler(this.cringe_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Marie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOui
            // 
            this.buttonOui.Location = new System.Drawing.Point(2, 12);
            this.buttonOui.Name = "buttonOui";
            this.buttonOui.Size = new System.Drawing.Size(180, 49);
            this.buttonOui.TabIndex = 0;
            this.buttonOui.Text = "oui.";
            this.buttonOui.UseVisualStyleBackColor = true;
            this.buttonOui.Click += new System.EventHandler(this.buttonOui_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnQtn);
            this.Controls.Add(this.univerBtn);
            this.Controls.Add(this.cringe);
            this.Controls.Add(this.buttonOui);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button univerBtn;
        private System.Windows.Forms.Button cringe;
        private System.Windows.Forms.Button buttonOui;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button BtnQtn;
    }
}