namespace GitExercice
{
    partial class HK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HK));
            this.CB_add = new System.Windows.Forms.CheckBox();
            this.CB_soustract = new System.Windows.Forms.CheckBox();
            this.CB_multiply = new System.Windows.Forms.CheckBox();
            this.CB_divide = new System.Windows.Forms.CheckBox();
            this.CB_modulo = new System.Windows.Forms.CheckBox();
            this.NUD_first = new System.Windows.Forms.NumericUpDown();
            this.NUD_second = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_result = new System.Windows.Forms.TextBox();
            this.BTN_calculate = new System.Windows.Forms.Button();
            this.BTN_return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_first)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_second)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_add
            // 
            this.CB_add.AutoSize = true;
            this.CB_add.Checked = true;
            this.CB_add.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_add.Location = new System.Drawing.Point(138, 47);
            this.CB_add.Name = "CB_add";
            this.CB_add.Size = new System.Drawing.Size(64, 17);
            this.CB_add.TabIndex = 0;
            this.CB_add.Text = "Addition";
            this.CB_add.UseVisualStyleBackColor = true;
            this.CB_add.CheckedChanged += new System.EventHandler(this.CB_add_CheckedChanged);
            // 
            // CB_soustract
            // 
            this.CB_soustract.AutoSize = true;
            this.CB_soustract.Location = new System.Drawing.Point(138, 70);
            this.CB_soustract.Name = "CB_soustract";
            this.CB_soustract.Size = new System.Drawing.Size(85, 17);
            this.CB_soustract.TabIndex = 1;
            this.CB_soustract.Text = "Soustraction";
            this.CB_soustract.UseVisualStyleBackColor = true;
            this.CB_soustract.CheckedChanged += new System.EventHandler(this.CB_soustract_CheckedChanged);
            // 
            // CB_multiply
            // 
            this.CB_multiply.AutoSize = true;
            this.CB_multiply.Location = new System.Drawing.Point(138, 93);
            this.CB_multiply.Name = "CB_multiply";
            this.CB_multiply.Size = new System.Drawing.Size(87, 17);
            this.CB_multiply.TabIndex = 2;
            this.CB_multiply.Text = "Multiplication";
            this.CB_multiply.UseVisualStyleBackColor = true;
            this.CB_multiply.CheckedChanged += new System.EventHandler(this.CB_multiply_CheckedChanged);
            // 
            // CB_divide
            // 
            this.CB_divide.AutoSize = true;
            this.CB_divide.Location = new System.Drawing.Point(138, 116);
            this.CB_divide.Name = "CB_divide";
            this.CB_divide.Size = new System.Drawing.Size(63, 17);
            this.CB_divide.TabIndex = 3;
            this.CB_divide.Text = "Division";
            this.CB_divide.UseVisualStyleBackColor = true;
            this.CB_divide.CheckedChanged += new System.EventHandler(this.CB_Divide_CheckedChanged);
            // 
            // CB_modulo
            // 
            this.CB_modulo.AutoSize = true;
            this.CB_modulo.Location = new System.Drawing.Point(138, 139);
            this.CB_modulo.Name = "CB_modulo";
            this.CB_modulo.Size = new System.Drawing.Size(61, 17);
            this.CB_modulo.TabIndex = 4;
            this.CB_modulo.Text = "Modulo";
            this.CB_modulo.UseVisualStyleBackColor = true;
            this.CB_modulo.CheckedChanged += new System.EventHandler(this.CB_modulo_CheckedChanged);
            // 
            // NUD_first
            // 
            this.NUD_first.Location = new System.Drawing.Point(12, 44);
            this.NUD_first.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NUD_first.Name = "NUD_first";
            this.NUD_first.Size = new System.Drawing.Size(120, 20);
            this.NUD_first.TabIndex = 5;
            // 
            // NUD_second
            // 
            this.NUD_second.Location = new System.Drawing.Point(228, 44);
            this.NUD_second.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NUD_second.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_second.Name = "NUD_second";
            this.NUD_second.Size = new System.Drawing.Size(120, 20);
            this.NUD_second.TabIndex = 6;
            this.NUD_second.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Premier nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Deuxième nombre";
            // 
            // TB_result
            // 
            this.TB_result.Enabled = false;
            this.TB_result.Location = new System.Drawing.Point(7, 166);
            this.TB_result.Name = "TB_result";
            this.TB_result.Size = new System.Drawing.Size(155, 20);
            this.TB_result.TabIndex = 9;
            this.TB_result.Text = "0";
            // 
            // BTN_calculate
            // 
            this.BTN_calculate.Location = new System.Drawing.Point(230, 75);
            this.BTN_calculate.Name = "BTN_calculate";
            this.BTN_calculate.Size = new System.Drawing.Size(117, 41);
            this.BTN_calculate.TabIndex = 10;
            this.BTN_calculate.Text = "Calculer";
            this.BTN_calculate.UseVisualStyleBackColor = true;
            this.BTN_calculate.Click += new System.EventHandler(this.BTN_calculate_Click);
            // 
            // BTN_return
            // 
            this.BTN_return.Location = new System.Drawing.Point(263, 157);
            this.BTN_return.Name = "BTN_return";
            this.BTN_return.Size = new System.Drawing.Size(84, 28);
            this.BTN_return.TabIndex = 11;
            this.BTN_return.Text = "Retour";
            this.BTN_return.UseVisualStyleBackColor = true;
            this.BTN_return.Click += new System.EventHandler(this.BTN_return_Click);
            // 
            // HK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 196);
            this.Controls.Add(this.BTN_return);
            this.Controls.Add(this.BTN_calculate);
            this.Controls.Add(this.TB_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUD_second);
            this.Controls.Add(this.NUD_first);
            this.Controls.Add(this.CB_modulo);
            this.Controls.Add(this.CB_divide);
            this.Controls.Add(this.CB_multiply);
            this.Controls.Add(this.CB_soustract);
            this.Controls.Add(this.CB_add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HK";
            this.Text = "HK-Calculate";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_first)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_second)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CB_add;
        private System.Windows.Forms.CheckBox CB_soustract;
        private System.Windows.Forms.CheckBox CB_multiply;
        private System.Windows.Forms.CheckBox CB_divide;
        private System.Windows.Forms.CheckBox CB_modulo;
        private System.Windows.Forms.NumericUpDown NUD_first;
        private System.Windows.Forms.NumericUpDown NUD_second;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_result;
        private System.Windows.Forms.Button BTN_calculate;
        private System.Windows.Forms.Button BTN_return;
    }
}