namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btnClear = new Button();
            btnPlusMinus = new Button();
            btnPerc = new Button();
            btnDiv = new Button();
            btnMult = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnMinus = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnPlus = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnEql = new Button();
            btnCom = new Button();
            btn0 = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtDisplay.BackColor = SystemColors.MenuText;
            txtDisplay.BorderStyle = BorderStyle.None;
            txtDisplay.Font = new Font("Microsoft Tai Le", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.ForeColor = SystemColors.Window;
            txtDisplay.Location = new Point(1, 12);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.RightToLeft = RightToLeft.No;
            txtDisplay.Size = new Size(415, 175);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.TextChanged += textBox1_TextChanged;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.AppWorkspace;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnClear.Location = new Point(12, 193);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 77);
            btnClear.TabIndex = 1;
            btnClear.Text = "AC";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.BackColor = SystemColors.AppWorkspace;
            btnPlusMinus.FlatAppearance.BorderSize = 0;
            btnPlusMinus.FlatStyle = FlatStyle.Flat;
            btnPlusMinus.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnPlusMinus.Location = new Point(112, 193);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(94, 77);
            btnPlusMinus.TabIndex = 2;
            btnPlusMinus.Text = "±";
            btnPlusMinus.UseVisualStyleBackColor = false;
            // 
            // btnPerc
            // 
            btnPerc.BackColor = SystemColors.AppWorkspace;
            btnPerc.FlatAppearance.BorderSize = 0;
            btnPerc.FlatStyle = FlatStyle.Flat;
            btnPerc.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnPerc.Location = new Point(212, 193);
            btnPerc.Name = "btnPerc";
            btnPerc.Size = new Size(94, 77);
            btnPerc.TabIndex = 3;
            btnPerc.Text = "%";
            btnPerc.UseVisualStyleBackColor = false;
            btnPerc.Click += btnPerc_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.Orange;
            btnDiv.FlatAppearance.BorderSize = 0;
            btnDiv.FlatStyle = FlatStyle.Flat;
            btnDiv.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDiv.ForeColor = SystemColors.ControlLightLight;
            btnDiv.Location = new Point(312, 193);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(94, 77);
            btnDiv.TabIndex = 4;
            btnDiv.Text = "÷";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnProced;
            // 
            // btnMult
            // 
            btnMult.BackColor = Color.Orange;
            btnMult.FlatAppearance.BorderSize = 0;
            btnMult.FlatStyle = FlatStyle.Flat;
            btnMult.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnMult.ForeColor = SystemColors.ControlLightLight;
            btnMult.Location = new Point(312, 276);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(94, 77);
            btnMult.TabIndex = 8;
            btnMult.Text = "×";
            btnMult.UseVisualStyleBackColor = false;
            btnMult.Click += btnProced;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(64, 64, 64);
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn9.ForeColor = SystemColors.ControlLightLight;
            btn9.Location = new Point(212, 276);
            btn9.Name = "btn9";
            btn9.Size = new Size(94, 77);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn0_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(64, 64, 64);
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn8.ForeColor = SystemColors.ControlLightLight;
            btn8.Location = new Point(112, 276);
            btn8.Name = "btn8";
            btn8.Size = new Size(94, 77);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn0_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(64, 64, 64);
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn7.ForeColor = SystemColors.ControlLightLight;
            btn7.Location = new Point(12, 276);
            btn7.Name = "btn7";
            btn7.Size = new Size(94, 77);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn0_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.Orange;
            btnMinus.FlatAppearance.BorderSize = 0;
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnMinus.ForeColor = SystemColors.ControlLightLight;
            btnMinus.Location = new Point(312, 359);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(94, 77);
            btnMinus.TabIndex = 12;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnProced;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(64, 64, 64);
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn6.ForeColor = SystemColors.ControlLightLight;
            btn6.Location = new Point(212, 359);
            btn6.Name = "btn6";
            btn6.Size = new Size(94, 77);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn0_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(64, 64, 64);
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn5.ForeColor = SystemColors.ControlLightLight;
            btn5.Location = new Point(112, 359);
            btn5.Name = "btn5";
            btn5.Size = new Size(94, 77);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn0_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(64, 64, 64);
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn4.ForeColor = SystemColors.ControlLightLight;
            btn4.Location = new Point(12, 359);
            btn4.Name = "btn4";
            btn4.Size = new Size(94, 77);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn0_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.Orange;
            btnPlus.FlatAppearance.BorderSize = 0;
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnPlus.ForeColor = SystemColors.ControlLightLight;
            btnPlus.Location = new Point(312, 442);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(94, 77);
            btnPlus.TabIndex = 16;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnProced;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(64, 64, 64);
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn3.ForeColor = SystemColors.ControlLightLight;
            btn3.Location = new Point(212, 442);
            btn3.Name = "btn3";
            btn3.Size = new Size(94, 77);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn0_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(64, 64, 64);
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn2.ForeColor = SystemColors.ControlLightLight;
            btn2.Location = new Point(112, 442);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 77);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn0_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(64, 64, 64);
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn1.ForeColor = SystemColors.ControlLightLight;
            btn1.Location = new Point(12, 442);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 77);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn0_Click;
            // 
            // btnEql
            // 
            btnEql.BackColor = Color.Orange;
            btnEql.FlatAppearance.BorderSize = 0;
            btnEql.FlatStyle = FlatStyle.Flat;
            btnEql.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnEql.ForeColor = SystemColors.ControlLightLight;
            btnEql.Location = new Point(312, 525);
            btnEql.Name = "btnEql";
            btnEql.Size = new Size(94, 77);
            btnEql.TabIndex = 20;
            btnEql.Text = "=";
            btnEql.UseVisualStyleBackColor = false;
            btnEql.Click += btnEql_Click;
            // 
            // btnCom
            // 
            btnCom.BackColor = Color.FromArgb(64, 64, 64);
            btnCom.FlatAppearance.BorderSize = 0;
            btnCom.FlatStyle = FlatStyle.Flat;
            btnCom.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCom.ForeColor = SystemColors.ControlLightLight;
            btnCom.Location = new Point(212, 525);
            btnCom.Name = "btnCom";
            btnCom.Size = new Size(94, 77);
            btnCom.TabIndex = 19;
            btnCom.Text = ",";
            btnCom.UseVisualStyleBackColor = false;
            btnCom.Click += btn0_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(64, 64, 64);
            btn0.FlatAppearance.BorderColor = SystemColors.WindowText;
            btn0.FlatAppearance.BorderSize = 0;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn0.ForeColor = SystemColors.ControlLightLight;
            btn0.Location = new Point(12, 525);
            btn0.Name = "btn0";
            btn0.Size = new Size(194, 77);
            btn0.TabIndex = 18;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(417, 615);
            Controls.Add(btnEql);
            Controls.Add(btnCom);
            Controls.Add(btn0);
            Controls.Add(btnPlus);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnMinus);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnMult);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnDiv);
            Controls.Add(btnPerc);
            Controls.Add(btnPlusMinus);
            Controls.Add(btnClear);
            Controls.Add(txtDisplay);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btnClear;
        private Button btnPlusMinus;
        private Button btnPerc;
        private Button btnDiv;
        private Button btnMult;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnMinus;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnPlus;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnEql;
        private Button btnCom;
        private Button btn0;
    }
}
