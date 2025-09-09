namespace WinFormMatrizMulti_2026_I
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
            txtbMatrix1 = new TextBox();
            txtbMatrix2 = new TextBox();
            lbMatrix1 = new Label();
            lbMatrix2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbResult = new Label();
            label6 = new Label();
            label7 = new Label();
            btnPlus = new Button();
            btnMinus = new Button();
            btnTimes = new Button();
            btnSin = new Button();
            rdbDeg = new RadioButton();
            rdbRad = new RadioButton();
            SuspendLayout();
            // 
            // txtbMatrix1
            // 
            txtbMatrix1.Location = new Point(136, 145);
            txtbMatrix1.Name = "txtbMatrix1";
            txtbMatrix1.Size = new Size(190, 31);
            txtbMatrix1.TabIndex = 0;
            // 
            // txtbMatrix2
            // 
            txtbMatrix2.Location = new Point(516, 145);
            txtbMatrix2.Name = "txtbMatrix2";
            txtbMatrix2.Size = new Size(190, 31);
            txtbMatrix2.TabIndex = 0;
            // 
            // lbMatrix1
            // 
            lbMatrix1.Location = new Point(136, 245);
            lbMatrix1.Name = "lbMatrix1";
            lbMatrix1.Size = new Size(190, 127);
            lbMatrix1.TabIndex = 1;
            lbMatrix1.Text = "label1";
            // 
            // lbMatrix2
            // 
            lbMatrix2.Location = new Point(516, 245);
            lbMatrix2.Name = "lbMatrix2";
            lbMatrix2.Size = new Size(190, 127);
            lbMatrix2.TabIndex = 1;
            lbMatrix2.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 145);
            label3.Name = "label3";
            label3.Size = new Size(24, 25);
            label3.TabIndex = 2;
            label3.Tag = "";
            label3.Text = "+";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(784, 151);
            label4.Name = "label4";
            label4.Size = new Size(24, 25);
            label4.TabIndex = 2;
            label4.Tag = "";
            label4.Text = "=";
            // 
            // lbResult
            // 
            lbResult.Location = new Point(854, 135);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(190, 127);
            lbResult.TabIndex = 1;
            lbResult.Text = "label1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(136, 208);
            label6.Name = "label6";
            label6.Size = new Size(76, 25);
            label6.TabIndex = 2;
            label6.Tag = "";
            label6.Text = "Matriz 1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(516, 208);
            label7.Name = "label7";
            label7.Size = new Size(76, 25);
            label7.TabIndex = 2;
            label7.Tag = "";
            label7.Text = "Matriz 2";
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(127, 452);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(120, 80);
            btnPlus.TabIndex = 3;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(335, 452);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(120, 80);
            btnMinus.TabIndex = 3;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnTimes
            // 
            btnTimes.Location = new Point(529, 453);
            btnTimes.Name = "btnTimes";
            btnTimes.Size = new Size(120, 80);
            btnTimes.TabIndex = 3;
            btnTimes.Text = "*";
            btnTimes.UseVisualStyleBackColor = true;
            // 
            // btnSin
            // 
            btnSin.Location = new Point(715, 452);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(120, 80);
            btnSin.TabIndex = 3;
            btnSin.Text = "Seno";
            btnSin.UseVisualStyleBackColor = true;
            btnSin.Click += btnSin_Click;
            // 
            // rdbDeg
            // 
            rdbDeg.AutoSize = true;
            rdbDeg.Location = new Point(185, 51);
            rdbDeg.Name = "rdbDeg";
            rdbDeg.Size = new Size(70, 29);
            rdbDeg.TabIndex = 4;
            rdbDeg.TabStop = true;
            rdbDeg.Text = "Deg";
            rdbDeg.UseVisualStyleBackColor = true;
            // 
            // rdbRad
            // 
            rdbRad.AutoSize = true;
            rdbRad.Location = new Point(516, 51);
            rdbRad.Name = "rdbRad";
            rdbRad.Size = new Size(68, 29);
            rdbRad.TabIndex = 4;
            rdbRad.TabStop = true;
            rdbRad.Text = "Rad";
            rdbRad.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 777);
            Controls.Add(rdbRad);
            Controls.Add(rdbDeg);
            Controls.Add(btnSin);
            Controls.Add(btnTimes);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(lbResult);
            Controls.Add(lbMatrix2);
            Controls.Add(lbMatrix1);
            Controls.Add(txtbMatrix2);
            Controls.Add(txtbMatrix1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbMatrix1;
        private TextBox txtbMatrix2;
        private Label lbMatrix1;
        private Label lbMatrix2;
        private Label label3;
        private Label label4;
        private Label lbResult;
        private Label label6;
        private Label label7;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnTimes;
        private Button btnSin;
        private RadioButton rdbDeg;
        private RadioButton rdbRad;
    }
}
