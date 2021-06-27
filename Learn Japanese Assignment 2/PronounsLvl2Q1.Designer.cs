
namespace Learn_Japanese_Assignment_2
{
    partial class PronounsLvl2Q1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PLvl1Q1Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(285, 230);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(225, 46);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "kare-ra(彼等)";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(285, 307);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(480, 307);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(27, 405);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Cancel";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(698, 405);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(91, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Type the English translation into the textbox below";
            // 
            // PLvl1Q1Lbl
            // 
            this.PLvl1Q1Lbl.AutoSize = true;
            this.PLvl1Q1Lbl.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PLvl1Q1Lbl.Location = new System.Drawing.Point(243, 35);
            this.PLvl1Q1Lbl.Name = "PLvl1Q1Lbl";
            this.PLvl1Q1Lbl.Size = new System.Drawing.Size(301, 47);
            this.PLvl1Q1Lbl.TabIndex = 23;
            this.PLvl1Q1Lbl.Text = "Pronouns Level 2";
            // 
            // PronounsLvl2Q1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(160)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PLvl1Q1Lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl1);
            this.Name = "PronounsLvl2Q1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProunounsLvl2Learn";
            this.Load += new System.EventHandler(this.ProunounsLvl2Learn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PLvl1Q1Lbl;
    }
}