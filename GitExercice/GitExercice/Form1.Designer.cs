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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.univerBtn = new System.Windows.Forms.Button();
            this.BtnQtn = new System.Windows.Forms.Button();
            this.cringe = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonOui = new System.Windows.Forms.Button();
            this.Btn_GoToHK = new System.Windows.Forms.Button();
            this.GuyGuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // univerBtn
            // 
            this.univerBtn.Location = new System.Drawing.Point(2, 330);
            this.univerBtn.Name = "univerBtn";
            this.univerBtn.Size = new System.Drawing.Size(176, 60);
            this.univerBtn.TabIndex = 0;
            this.univerBtn.Text = "Univer";
            this.univerBtn.UseVisualStyleBackColor = true;
            this.univerBtn.Click += new System.EventHandler(this.univerBtn_Click);
            // 
            // BtnQtn
            // 
            this.BtnQtn.Location = new System.Drawing.Point(2, 264);
            this.BtnQtn.Name = "BtnQtn";
            this.BtnQtn.Size = new System.Drawing.Size(176, 60);
            this.BtnQtn.TabIndex = 0;
            this.BtnQtn.Text = "Quentin";
            this.BtnQtn.UseVisualStyleBackColor = true;
            this.BtnQtn.Click += new System.EventHandler(this.BtnQtn_Click);
            // 
            // cringe
            // 
            this.cringe.Location = new System.Drawing.Point(2, 68);
            this.cringe.Name = "cringe";
            this.cringe.Size = new System.Drawing.Size(176, 60);
            this.cringe.TabIndex = 0;
            this.cringe.Text = "cringe";
            this.cringe.UseVisualStyleBackColor = true;
            this.cringe.Click += new System.EventHandler(this.cringe_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Marie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOui
            // 
            this.buttonOui.Location = new System.Drawing.Point(184, 2);
            this.buttonOui.Name = "buttonOui";
            this.buttonOui.Size = new System.Drawing.Size(176, 60);
            this.buttonOui.TabIndex = 0;
            this.buttonOui.Text = "oui.";
            this.buttonOui.UseVisualStyleBackColor = true;
            this.buttonOui.Click += new System.EventHandler(this.buttonOui_Click);
            // 
            // Btn_GoToHK
            // 
            this.Btn_GoToHK.Location = new System.Drawing.Point(2, 134);
            this.Btn_GoToHK.Name = "Btn_GoToHK";
            this.Btn_GoToHK.Size = new System.Drawing.Size(176, 60);
            this.Btn_GoToHK.TabIndex = 2;
            this.Btn_GoToHK.Text = "Go to HK";
            this.Btn_GoToHK.Click += new System.EventHandler(this.Btn_GoToHK_Click);
            // 
            // GuyGuy
            // 
            this.GuyGuy.Location = new System.Drawing.Point(2, 2);
            this.GuyGuy.Name = "GuyGuy";
            this.GuyGuy.Size = new System.Drawing.Size(176, 60);
            this.GuyGuy.TabIndex = 1;
            this.GuyGuy.Text = "Guy Guy²";
            this.GuyGuy.UseVisualStyleBackColor = true;
            this.GuyGuy.Click += new System.EventHandler(this.GuyGuy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(544, 394);
            this.Controls.Add(this.BtnQtn);
            this.Controls.Add(this.univerBtn);
            this.Controls.Add(this.cringe);
            this.Controls.Add(this.buttonOui);
            this.Controls.Add(this.GuyGuy);
            this.Controls.Add(this.Btn_GoToHK);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Choosing";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button univerBtn;
        private System.Windows.Forms.Button cringe;
        private System.Windows.Forms.Button buttonOui;
        private System.Windows.Forms.Button Btn_GoToHK;
        private System.Windows.Forms.Button GuyGuy;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button BtnQtn;
    }
}