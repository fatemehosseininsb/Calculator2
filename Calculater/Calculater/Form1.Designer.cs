namespace Calculater
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
            this.EnterNumber1 = new System.Windows.Forms.Label();
            this.EnterNumber2 = new System.Windows.Forms.Label();
            this.GetNum1 = new System.Windows.Forms.NumericUpDown();
            this.GetNum2 = new System.Windows.Forms.NumericUpDown();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GetNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetNum2)).BeginInit();
            this.SuspendLayout();
            // 
            // EnterNumber1
            // 
            this.EnterNumber1.AutoSize = true;
            this.EnterNumber1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.EnterNumber1.Location = new System.Drawing.Point(392, 9);
            this.EnterNumber1.Name = "EnterNumber1";
            this.EnterNumber1.Padding = new System.Windows.Forms.Padding(3);
            this.EnterNumber1.Size = new System.Drawing.Size(108, 19);
            this.EnterNumber1.TabIndex = 0;
            this.EnterNumber1.Text = "عدد اول را وارد کنید:";
            // 
            // EnterNumber2
            // 
            this.EnterNumber2.AutoSize = true;
            this.EnterNumber2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.EnterNumber2.Location = new System.Drawing.Point(392, 38);
            this.EnterNumber2.Name = "EnterNumber2";
            this.EnterNumber2.Padding = new System.Windows.Forms.Padding(3);
            this.EnterNumber2.Size = new System.Drawing.Size(108, 19);
            this.EnterNumber2.TabIndex = 1;
            this.EnterNumber2.Text = "عدد دوم را وارد کنید:";
            // 
            // GetNum1
            // 
            this.GetNum1.Location = new System.Drawing.Point(145, 9);
            this.GetNum1.Name = "GetNum1";
            this.GetNum1.Size = new System.Drawing.Size(241, 20);
            this.GetNum1.TabIndex = 2;
            this.GetNum1.ValueChanged += new System.EventHandler(this.GetNum1_ValueChanged);
            // 
            // GetNum2
            // 
            this.GetNum2.Location = new System.Drawing.Point(145, 37);
            this.GetNum2.Name = "GetNum2";
            this.GetNum2.Size = new System.Drawing.Size(241, 20);
            this.GetNum2.TabIndex = 3;
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMinus.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(12, 12);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(46, 41);
            this.btnMinus.TabIndex = 4;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPlus.Location = new System.Drawing.Point(64, 12);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(46, 41);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMultiple
            // 
            this.btnMultiple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnMultiple.Location = new System.Drawing.Point(12, 59);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(46, 41);
            this.btnMultiple.TabIndex = 4;
            this.btnMultiple.Text = "*";
            this.btnMultiple.UseVisualStyleBackColor = false;
            this.btnMultiple.Click += new System.EventHandler(this.btnMultiple_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDivide.Location = new System.Drawing.Point(64, 59);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(46, 41);
            this.btnDivide.TabIndex = 4;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 112);
            this.Controls.Add(this.btnMultiple);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.GetNum2);
            this.Controls.Add(this.GetNum1);
            this.Controls.Add(this.EnterNumber2);
            this.Controls.Add(this.EnterNumber1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ماشین حساب من";
            ((System.ComponentModel.ISupportInitialize)(this.GetNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetNum2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterNumber1;
        private System.Windows.Forms.Label EnterNumber2;
        private System.Windows.Forms.NumericUpDown GetNum1;
        private System.Windows.Forms.NumericUpDown GetNum2;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Button btnDivide;
    }
}

