
namespace Learn_Japanese_Assignment_2
{
    partial class NounsLvl1Learn
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
            this.NLvl1Lbl = new System.Windows.Forms.Label();
            this.NounLvl1instructionLbl = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.MuteBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NLvl1Lbl
            // 
            this.NLvl1Lbl.AutoSize = true;
            this.NLvl1Lbl.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NLvl1Lbl.Location = new System.Drawing.Point(332, 9);
            this.NLvl1Lbl.Name = "NLvl1Lbl";
            this.NLvl1Lbl.Size = new System.Drawing.Size(251, 47);
            this.NLvl1Lbl.TabIndex = 0;
            this.NLvl1Lbl.Text = "Nouns Level 1";
            // 
            // NounLvl1instructionLbl
            // 
            this.NounLvl1instructionLbl.AutoSize = true;
            this.NounLvl1instructionLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NounLvl1instructionLbl.Location = new System.Drawing.Point(45, 104);
            this.NounLvl1instructionLbl.Name = "NounLvl1instructionLbl";
            this.NounLvl1instructionLbl.Size = new System.Drawing.Size(723, 32);
            this.NounLvl1instructionLbl.TabIndex = 1;
            this.NounLvl1instructionLbl.Text = "Study the following, then click the \"Next>\" Button to start the test:";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(61, 503);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(74, 38);
            this.BackBtn.TabIndex = 2;
            this.BackBtn.Text = "<Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // MuteBtn
            // 
            this.MuteBtn.Location = new System.Drawing.Point(708, 503);
            this.MuteBtn.Name = "MuteBtn";
            this.MuteBtn.Size = new System.Drawing.Size(55, 38);
            this.MuteBtn.TabIndex = 3;
            this.MuteBtn.Text = "Mute";
            this.MuteBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(801, 503);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(85, 37);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(538, 503);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(80, 37);
            this.NextBtn.TabIndex = 5;
            this.NextBtn.Text = "Next>";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // NounsLvl1Learn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.MuteBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.NounLvl1instructionLbl);
            this.Controls.Add(this.NLvl1Lbl);
            this.MinimizeBox = false;
            this.Name = "NounsLvl1Learn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NounsLvl1Learn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NLvl1Lbl;
        private System.Windows.Forms.Label NounLvl1instructionLbl;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button MuteBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button NextBtn;
    }
}