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
            panel1 = new Panel();
            output = new TextBox();
            resetBtn = new Button();
            equalBtn = new Button();
            addBtn = new Button();
            subBtn = new Button();
            mulBtn = new Button();
            divBtn = new Button();
            deciBtn = new Button();
            zeroBtn = new Button();
            clearBtn = new Button();
            threeBtn = new Button();
            twoBtn = new Button();
            oneBtn = new Button();
            sixBtn = new Button();
            fiveBtn = new Button();
            fourBtn = new Button();
            nineBtn = new Button();
            eightBtn = new Button();
            sevenBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(output);
            panel1.Controls.Add(resetBtn);
            panel1.Controls.Add(equalBtn);
            panel1.Controls.Add(addBtn);
            panel1.Controls.Add(subBtn);
            panel1.Controls.Add(mulBtn);
            panel1.Controls.Add(divBtn);
            panel1.Controls.Add(deciBtn);
            panel1.Controls.Add(zeroBtn);
            panel1.Controls.Add(clearBtn);
            panel1.Controls.Add(threeBtn);
            panel1.Controls.Add(twoBtn);
            panel1.Controls.Add(oneBtn);
            panel1.Controls.Add(sixBtn);
            panel1.Controls.Add(fiveBtn);
            panel1.Controls.Add(fourBtn);
            panel1.Controls.Add(nineBtn);
            panel1.Controls.Add(eightBtn);
            panel1.Controls.Add(sevenBtn);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 449);
            panel1.TabIndex = 0;
            // 
            // output
            // 
            output.BackColor = Color.FromArgb(248, 244, 225);
            output.Cursor = Cursors.IBeam;
            output.Enabled = false;
            output.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            output.ForeColor = Color.FromArgb(182, 113, 98);
            output.Location = new Point(9, 12);
            output.Multiline = true;
            output.Name = "output";
            output.Size = new Size(316, 77);
            output.TabIndex = 20;
            output.Text = "0";
            output.TextAlign = HorizontalAlignment.Right;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.FromArgb(182, 113, 98);
            resetBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetBtn.ForeColor = Color.FromArgb(246, 230, 203);
            resetBtn.Location = new Point(333, 22);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(87, 56);
            resetBtn.TabIndex = 18;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.MouseClick += resetBtn_MouseClick;
            // 
            // equalBtn
            // 
            equalBtn.BackColor = Color.FromArgb(182, 113, 98);
            equalBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            equalBtn.ForeColor = Color.FromArgb(246, 230, 203);
            equalBtn.Location = new Point(324, 344);
            equalBtn.Name = "equalBtn";
            equalBtn.Size = new Size(99, 90);
            equalBtn.TabIndex = 17;
            equalBtn.Text = "=";
            equalBtn.UseVisualStyleBackColor = false;
            equalBtn.MouseClick += equalBtn_MouseClick;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(160, 147, 125);
            addBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            addBtn.ForeColor = Color.FromArgb(118, 69, 59);
            addBtn.Location = new Point(324, 282);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(99, 56);
            addBtn.TabIndex = 16;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.MouseClick += operatorBtn;
            // 
            // subBtn
            // 
            subBtn.BackColor = Color.FromArgb(160, 147, 125);
            subBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            subBtn.ForeColor = Color.FromArgb(118, 69, 59);
            subBtn.Location = new Point(324, 220);
            subBtn.Name = "subBtn";
            subBtn.Size = new Size(99, 56);
            subBtn.TabIndex = 15;
            subBtn.Text = "-";
            subBtn.UseVisualStyleBackColor = false;
            subBtn.MouseClick += operatorBtn;
            // 
            // mulBtn
            // 
            mulBtn.BackColor = Color.FromArgb(160, 147, 125);
            mulBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            mulBtn.ForeColor = Color.FromArgb(118, 69, 59);
            mulBtn.Location = new Point(324, 158);
            mulBtn.Name = "mulBtn";
            mulBtn.Size = new Size(99, 56);
            mulBtn.TabIndex = 14;
            mulBtn.Text = "*";
            mulBtn.UseVisualStyleBackColor = false;
            mulBtn.MouseClick += operatorBtn;
            // 
            // divBtn
            // 
            divBtn.BackColor = Color.FromArgb(160, 147, 125);
            divBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            divBtn.ForeColor = Color.FromArgb(118, 69, 59);
            divBtn.Location = new Point(324, 96);
            divBtn.Name = "divBtn";
            divBtn.Size = new Size(99, 56);
            divBtn.TabIndex = 13;
            divBtn.Text = "/";
            divBtn.UseVisualStyleBackColor = false;
            divBtn.MouseClick += operatorBtn;
            // 
            // deciBtn
            // 
            deciBtn.BackColor = Color.FromArgb(160, 147, 125);
            deciBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            deciBtn.ForeColor = Color.FromArgb(118, 69, 59);
            deciBtn.Location = new Point(219, 354);
            deciBtn.Name = "deciBtn";
            deciBtn.Size = new Size(99, 80);
            deciBtn.TabIndex = 11;
            deciBtn.Text = ".";
            deciBtn.UseVisualStyleBackColor = false;
            deciBtn.MouseClick += numBtn;
            // 
            // zeroBtn
            // 
            zeroBtn.BackColor = Color.FromArgb(160, 147, 125);
            zeroBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            zeroBtn.ForeColor = Color.FromArgb(118, 69, 59);
            zeroBtn.Location = new Point(114, 354);
            zeroBtn.Name = "zeroBtn";
            zeroBtn.Size = new Size(99, 80);
            zeroBtn.TabIndex = 10;
            zeroBtn.Text = "0";
            zeroBtn.UseVisualStyleBackColor = false;
            zeroBtn.MouseClick += numBtn;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.FromArgb(182, 113, 98);
            clearBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            clearBtn.ForeColor = Color.FromArgb(246, 230, 203);
            clearBtn.Location = new Point(9, 354);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(99, 80);
            clearBtn.TabIndex = 9;
            clearBtn.Text = "C";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.MouseClick += clearBtn_MouseClick;
            // 
            // threeBtn
            // 
            threeBtn.BackColor = Color.FromArgb(160, 147, 125);
            threeBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            threeBtn.ForeColor = Color.FromArgb(118, 69, 59);
            threeBtn.Location = new Point(219, 268);
            threeBtn.Name = "threeBtn";
            threeBtn.Size = new Size(99, 80);
            threeBtn.TabIndex = 8;
            threeBtn.Text = "3";
            threeBtn.UseVisualStyleBackColor = false;
            threeBtn.MouseClick += numBtn;
            // 
            // twoBtn
            // 
            twoBtn.BackColor = Color.FromArgb(160, 147, 125);
            twoBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            twoBtn.ForeColor = Color.FromArgb(118, 69, 59);
            twoBtn.Location = new Point(114, 268);
            twoBtn.Name = "twoBtn";
            twoBtn.Size = new Size(99, 80);
            twoBtn.TabIndex = 7;
            twoBtn.Text = "2";
            twoBtn.UseVisualStyleBackColor = false;
            twoBtn.MouseClick += numBtn;
            // 
            // oneBtn
            // 
            oneBtn.BackColor = Color.FromArgb(160, 147, 125);
            oneBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            oneBtn.ForeColor = Color.FromArgb(118, 69, 59);
            oneBtn.Location = new Point(9, 268);
            oneBtn.Name = "oneBtn";
            oneBtn.Size = new Size(99, 80);
            oneBtn.TabIndex = 6;
            oneBtn.Text = "1";
            oneBtn.UseVisualStyleBackColor = false;
            oneBtn.MouseClick += numBtn;
            // 
            // sixBtn
            // 
            sixBtn.BackColor = Color.FromArgb(160, 147, 125);
            sixBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            sixBtn.ForeColor = Color.FromArgb(118, 69, 59);
            sixBtn.Location = new Point(219, 182);
            sixBtn.Name = "sixBtn";
            sixBtn.Size = new Size(99, 80);
            sixBtn.TabIndex = 5;
            sixBtn.Text = "6";
            sixBtn.UseVisualStyleBackColor = false;
            sixBtn.MouseClick += numBtn;
            // 
            // fiveBtn
            // 
            fiveBtn.BackColor = Color.FromArgb(160, 147, 125);
            fiveBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            fiveBtn.ForeColor = Color.FromArgb(118, 69, 59);
            fiveBtn.Location = new Point(114, 182);
            fiveBtn.Name = "fiveBtn";
            fiveBtn.Size = new Size(99, 80);
            fiveBtn.TabIndex = 4;
            fiveBtn.Text = "5";
            fiveBtn.UseVisualStyleBackColor = false;
            fiveBtn.MouseClick += numBtn;
            // 
            // fourBtn
            // 
            fourBtn.BackColor = Color.FromArgb(160, 147, 125);
            fourBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            fourBtn.ForeColor = Color.FromArgb(118, 69, 59);
            fourBtn.Location = new Point(9, 182);
            fourBtn.Name = "fourBtn";
            fourBtn.Size = new Size(99, 80);
            fourBtn.TabIndex = 3;
            fourBtn.Text = "4";
            fourBtn.UseVisualStyleBackColor = false;
            fourBtn.MouseClick += numBtn;
            // 
            // nineBtn
            // 
            nineBtn.BackColor = Color.FromArgb(160, 147, 125);
            nineBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            nineBtn.ForeColor = Color.FromArgb(118, 69, 59);
            nineBtn.Location = new Point(219, 96);
            nineBtn.Name = "nineBtn";
            nineBtn.Size = new Size(99, 80);
            nineBtn.TabIndex = 2;
            nineBtn.Text = "9";
            nineBtn.UseVisualStyleBackColor = false;
            nineBtn.MouseClick += numBtn;
            // 
            // eightBtn
            // 
            eightBtn.BackColor = Color.FromArgb(160, 147, 125);
            eightBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            eightBtn.ForeColor = Color.FromArgb(118, 69, 59);
            eightBtn.Location = new Point(114, 96);
            eightBtn.Name = "eightBtn";
            eightBtn.Size = new Size(99, 80);
            eightBtn.TabIndex = 1;
            eightBtn.Text = "8";
            eightBtn.UseVisualStyleBackColor = false;
            eightBtn.MouseClick += numBtn;
            // 
            // sevenBtn
            // 
            sevenBtn.BackColor = Color.FromArgb(160, 147, 125);
            sevenBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            sevenBtn.ForeColor = Color.FromArgb(118, 69, 59);
            sevenBtn.Location = new Point(9, 96);
            sevenBtn.Name = "sevenBtn";
            sevenBtn.Size = new Size(99, 80);
            sevenBtn.TabIndex = 0;
            sevenBtn.Text = "7";
            sevenBtn.UseVisualStyleBackColor = false;
            sevenBtn.MouseClick += numBtn;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 230, 203);
            ClientSize = new Size(433, 443);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Klara's Calculator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button sevenBtn;
        private Button resetBtn;
        private Button equalBtn;
        private Button addBtn;
        private Button subBtn;
        private Button mulBtn;
        private Button divBtn;
        private Button deciBtn;
        private Button zeroBtn;
        private Button clearBtn;
        private Button threeBtn;
        private Button twoBtn;
        private Button oneBtn;
        private Button sixBtn;
        private Button fiveBtn;
        private Button fourBtn;
        private Button nineBtn;
        private Button eightBtn;
        private TextBox output;
    }
}
