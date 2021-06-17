
namespace Learn_Japanese_Assignment_2
{
    partial class VerbsLvl1Learn
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
            this.VLvl1Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(500, 460);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(80, 37);
            this.NextBtn.TabIndex = 11;
            this.NextBtn.Text = "Next>";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(763, 460);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(85, 37);
            this.ExitBtn.TabIndex = 10;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MuteBtn
            // 
            this.MuteBtn.Location = new System.Drawing.Point(670, 460);
            this.MuteBtn.Name = "MuteBtn";
            this.MuteBtn.Size = new System.Drawing.Size(55, 38);
            this.MuteBtn.TabIndex = 9;
            this.MuteBtn.Text = "Mute";
            this.MuteBtn.UseVisualStyleBackColor = true;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(23, 460);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(74, 38);
            this.BackBtn.TabIndex = 8;
            this.BackBtn.Text = "<Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // NounLvl1instructionLbl
            // 
            this.NounLvl1instructionLbl.AutoSize = true;
            this.NounLvl1instructionLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NounLvl1instructionLbl.Location = new System.Drawing.Point(23, 93);
            this.NounLvl1instructionLbl.Name = "NounLvl1instructionLbl";
            this.NounLvl1instructionLbl.Size = new System.Drawing.Size(723, 32);
            this.NounLvl1instructionLbl.TabIndex = 7;
            this.NounLvl1instructionLbl.Text = "Study the following, then click the \"Next>\" Button to start the test:";
            // 
            // VLvl1Lbl
            // 
            this.VLvl1Lbl.AutoSize = true;
            this.VLvl1Lbl.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VLvl1Lbl.Location = new System.Drawing.Point(310, -2);
            this.VLvl1Lbl.Name = "VLvl1Lbl";
            this.VLvl1Lbl.Size = new System.Drawing.Size(236, 47);
            this.VLvl1Lbl.TabIndex = 6;
            this.VLvl1Lbl.Text = "Verbs Level 1";
            // 
            // VerbsLvl1Learn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 523);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.MuteBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.NounLvl1instructionLbl);
            this.Controls.Add(this.VLvl1Lbl);
            this.Name = "VerbsLvl1Learn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerbsLvl1Learn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MuteBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label NounLvl1instructionLbl;
        private System.Windows.Forms.Label VLvl1Lbl;
    }
}