
namespace GRAPHEDITOR0._2._0
{
    partial class EditCanvas
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.h = new System.Windows.Forms.NumericUpDown();
            this.w = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBlue = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGreen = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRed = new System.Windows.Forms.NumericUpDown();
            this.OtherColors = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Ok_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BlueBarr = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.GreenBarr = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.RedBarr = new System.Windows.Forms.HScrollBar();
            this.label7 = new System.Windows.Forms.Label();
            this.theme_numeric = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Color_Pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.h)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.w)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theme_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Color_Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label6.Location = new System.Drawing.Point(283, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 24);
            this.label6.TabIndex = 56;
            this.label6.Text = "AutoSize:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.Location = new System.Drawing.Point(203, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(203, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "Width";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(287, 246);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(80, 17);
            this.radioButton3.TabIndex = 53;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "450x200 px";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(287, 223);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 17);
            this.radioButton2.TabIndex = 52;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "600x400 px";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(287, 200);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 17);
            this.radioButton1.TabIndex = 51;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "300x300 px";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // h
            // 
            this.h.Location = new System.Drawing.Point(203, 243);
            this.h.Maximum = new decimal(new int[] {
            426,
            0,
            0,
            0});
            this.h.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(52, 20);
            this.h.TabIndex = 50;
            this.h.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.h.ValueChanged += new System.EventHandler(this.h_ValueChanged);
            // 
            // w
            // 
            this.w.Location = new System.Drawing.Point(203, 180);
            this.w.Maximum = new decimal(new int[] {
            649,
            0,
            0,
            0});
            this.w.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(52, 20);
            this.w.TabIndex = 49;
            this.w.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.w.ValueChanged += new System.EventHandler(this.w_ValueChanged);
            // 
            // numericUpDownBlue
            // 
            this.numericUpDownBlue.Location = new System.Drawing.Point(269, 94);
            this.numericUpDownBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBlue.Name = "numericUpDownBlue";
            this.numericUpDownBlue.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownBlue.TabIndex = 47;
            this.numericUpDownBlue.ValueChanged += new System.EventHandler(this.numericUpDownBlue_ValueChanged);
            // 
            // numericUpDownGreen
            // 
            this.numericUpDownGreen.Location = new System.Drawing.Point(269, 50);
            this.numericUpDownGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownGreen.Name = "numericUpDownGreen";
            this.numericUpDownGreen.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownGreen.TabIndex = 46;
            this.numericUpDownGreen.ValueChanged += new System.EventHandler(this.numericUpDownGreen_ValueChanged);
            // 
            // numericUpDownRed
            // 
            this.numericUpDownRed.Location = new System.Drawing.Point(269, 12);
            this.numericUpDownRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRed.Name = "numericUpDownRed";
            this.numericUpDownRed.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownRed.TabIndex = 45;
            this.numericUpDownRed.ValueChanged += new System.EventHandler(this.numericUpDownRed_ValueChanged);
            // 
            // OtherColors
            // 
            this.OtherColors.Location = new System.Drawing.Point(356, 121);
            this.OtherColors.Name = "OtherColors";
            this.OtherColors.Size = new System.Drawing.Size(75, 23);
            this.OtherColors.TabIndex = 44;
            this.OtherColors.Text = "Other Color";
            this.OtherColors.UseVisualStyleBackColor = true;
            this.OtherColors.Click += new System.EventHandler(this.OtherColors_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(88, 324);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_btn.TabIndex = 43;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Ok_btn
            // 
            this.Ok_btn.Location = new System.Drawing.Point(7, 324);
            this.Ok_btn.Name = "Ok_btn";
            this.Ok_btn.Size = new System.Drawing.Size(75, 23);
            this.Ok_btn.TabIndex = 42;
            this.Ok_btn.Text = "Ok";
            this.Ok_btn.UseVisualStyleBackColor = true;
            this.Ok_btn.Click += new System.EventHandler(this.Ok_btn_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(4, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Blue";
            // 
            // BlueBarr
            // 
            this.BlueBarr.LargeChange = 1;
            this.BlueBarr.Location = new System.Drawing.Point(63, 94);
            this.BlueBarr.Maximum = 255;
            this.BlueBarr.Name = "BlueBarr";
            this.BlueBarr.Size = new System.Drawing.Size(192, 21);
            this.BlueBarr.TabIndex = 39;
            this.BlueBarr.ValueChanged += new System.EventHandler(this.BlueBarr_ValueChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Green";
            // 
            // GreenBarr
            // 
            this.GreenBarr.LargeChange = 1;
            this.GreenBarr.Location = new System.Drawing.Point(63, 50);
            this.GreenBarr.Maximum = 255;
            this.GreenBarr.Name = "GreenBarr";
            this.GreenBarr.Size = new System.Drawing.Size(192, 21);
            this.GreenBarr.TabIndex = 37;
            this.GreenBarr.ValueChanged += new System.EventHandler(this.GreenBarr_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Red";
            // 
            // RedBarr
            // 
            this.RedBarr.LargeChange = 1;
            this.RedBarr.Location = new System.Drawing.Point(63, 12);
            this.RedBarr.Maximum = 255;
            this.RedBarr.Name = "RedBarr";
            this.RedBarr.Size = new System.Drawing.Size(192, 21);
            this.RedBarr.TabIndex = 35;
            this.RedBarr.ValueChanged += new System.EventHandler(this.RedBarr_ValueChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label7.Location = new System.Drawing.Point(12, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 24);
            this.label7.TabIndex = 57;
            this.label7.Text = "Theme:";
            // 
            // theme_numeric
            // 
            this.theme_numeric.Location = new System.Drawing.Point(88, 294);
            this.theme_numeric.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.theme_numeric.Name = "theme_numeric";
            this.theme_numeric.Size = new System.Drawing.Size(120, 20);
            this.theme_numeric.TabIndex = 58;
            this.theme_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.theme_numeric.ValueChanged += new System.EventHandler(this.theme_numeric_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 26);
            this.label8.TabIndex = 59;
            this.label8.Text = "1 - light theme \r\n2 - dark theme";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 109);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // Color_Pic
            // 
            this.Color_Pic.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Color_Pic.Location = new System.Drawing.Point(327, 16);
            this.Color_Pic.Name = "Color_Pic";
            this.Color_Pic.Size = new System.Drawing.Size(100, 99);
            this.Color_Pic.TabIndex = 41;
            this.Color_Pic.TabStop = false;
            // 
            // EditCanvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 359);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.theme_numeric);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.h);
            this.Controls.Add(this.w);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericUpDownBlue);
            this.Controls.Add(this.numericUpDownGreen);
            this.Controls.Add(this.numericUpDownRed);
            this.Controls.Add(this.OtherColors);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Ok_btn);
            this.Controls.Add(this.Color_Pic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BlueBarr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GreenBarr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RedBarr);
            this.Name = "EditCanvas";
            this.Text = "EditCanvas";
            this.Load += new System.EventHandler(this.EditCanvas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.h)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.w)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theme_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Color_Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.NumericUpDown h;
        private System.Windows.Forms.NumericUpDown w;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownBlue;
        private System.Windows.Forms.NumericUpDown numericUpDownGreen;
        private System.Windows.Forms.NumericUpDown numericUpDownRed;
        private System.Windows.Forms.Button OtherColors;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button Ok_btn;
        private System.Windows.Forms.PictureBox Color_Pic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar BlueBarr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar GreenBarr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar RedBarr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown theme_numeric;
        private System.Windows.Forms.Label label8;
    }
}