
namespace Learn_Japanese_Assignment_2
{
    partial class PronounsLvl1Learn
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
            this.NextBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MuteBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.NounLvl1instructionLbl = new System.Windows.Forms.Label();
            this.PLvl1Lbl = new System.Windows.Forms.Label();
            this.PQ1Study1 = new System.Windows.Forms.Label();
            this.PronounLvl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(489, 464);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(80, 37);
            this.NextBtn.TabIndex = 17;
            this.NextBtn.Text = "Next>";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(752, 464);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(85, 37);
            this.ExitBtn.TabIndex = 16;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MuteBtn
            // 
            this.MuteBtn.Location = new System.Drawing.Point(659, 464);
            this.MuteBtn.Name = "MuteBtn";
            this.MuteBtn.Size = new System.Drawing.Size(55, 38);
            this.MuteBtn.TabIndex = 15;
            this.MuteBtn.Text = "Mute";
            this.MuteBtn.UseVisualStyleBackColor = true;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 464);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(74, 38);
            this.BackBtn.TabIndex = 14;
            this.BackBtn.Text = "<Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // NounLvl1instructionLbl
            // 
            this.NounLvl1instructionLbl.AutoSize = true;
            this.NounLvl1instructionLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NounLvl1instructionLbl.Location = new System.Drawing.Point(12, 97);
            this.NounLvl1instructionLbl.Name = "NounLvl1instructionLbl";
            this.NounLvl1instructionLbl.Size = new System.Drawing.Size(723, 32);
            this.NounLvl1instructionLbl.TabIndex = 13;
            this.NounLvl1instructionLbl.Text = "Study the following, then click the \"Next>\" Button to start the test:";
            // 
            // PLvl1Lbl
            // 
            this.PLvl1Lbl.AutoSize = true;
            this.PLvl1Lbl.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PLvl1Lbl.Location = new System.Drawing.Point(299, 2);
            this.PLvl1Lbl.Name = "PLvl1Lbl";
            this.PLvl1Lbl.Size = new System.Drawing.Size(301, 47);
            this.PLvl1Lbl.TabIndex = 12;
            this.PLvl1Lbl.Text = "Pronouns Level 1";
            // 
            // PQ1Study1
            // 
            this.PQ1Study1.AutoSize = true;
            this.PQ1Study1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.PQ1Study1.Location = new System.Drawing.Point(29, 198);
            this.PQ1Study1.Name = "PQ1Study1";
            this.PQ1Study1.Size = new System.Drawing.Size(170, 30);
            this.PQ1Study1.TabIndex = 18;
            this.PQ1Study1.Text = "I = Watashi \"私\"";
            // 
            // PronounLvl1
            // 
            this.PronounLvl1.AutoSize = true;
            this.PronounLvl1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PronounLvl1.Location = new System.Drawing.Point(29, 145);
            this.PronounLvl1.Name = "PronounLvl1";
            this.PronounLvl1.Size = new System.Drawing.Size(199, 30);
            this.PronounLvl1.TabIndex = 19;
            this.PronounLvl1.Text = "English = Japanese";
            // 
            // PronounsLvl1Learn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 508);
            this.Controls.Add(this.PronounLvl1);
            this.Controls.Add(this.PQ1Study1);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.MuteBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.NounLvl1instructionLbl);
            this.Controls.Add(this.PLvl1Lbl);
            this.Name = "PronounsLvl1Learn";
            this.Text = "PronounsLvl1Learn";
            this.Load += new System.EventHandler(this.PronounsLvl1Learn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MuteBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label NounLvl1instructionLbl;
        private System.Windows.Forms.Label PLvl1Lbl;
        private System.Windows.Forms.Label PQ1Study1;
        private System.Windows.Forms.Label PronounLvl1;
    }
}