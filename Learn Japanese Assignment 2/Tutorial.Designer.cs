
namespace Learn_Japanese_Assignment_2
{
    partial class Tutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutorial));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.btnPerson = new System.Windows.Forms.Button();
            this.btnAnimal = new System.Windows.Forms.Button();
            this.btnPeople = new System.Windows.Forms.Button();
            this.btnEarth = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(28, 387);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(123, 387);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMute
            // 
            this.btnMute.Location = new System.Drawing.Point(344, 387);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(75, 23);
            this.btnMute.TabIndex = 2;
            this.btnMute.Text = "Mute";
            this.btnMute.UseVisualStyleBackColor = true;
            // 
            // btnPerson
            // 
            this.btnPerson.Location = new System.Drawing.Point(38, 258);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Size = new System.Drawing.Size(160, 47);
            this.btnPerson.TabIndex = 3;
            this.btnPerson.Text = "Person";
            this.btnPerson.UseVisualStyleBackColor = true;
            this.btnPerson.Click += new System.EventHandler(this.btnPerson_Click);
            // 
            // btnAnimal
            // 
            this.btnAnimal.Location = new System.Drawing.Point(259, 258);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(160, 47);
            this.btnAnimal.TabIndex = 4;
            this.btnAnimal.Text = "Animal";
            this.btnAnimal.UseVisualStyleBackColor = true;
            this.btnAnimal.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnPeople
            // 
            this.btnPeople.Location = new System.Drawing.Point(38, 311);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(160, 45);
            this.btnPeople.TabIndex = 5;
            this.btnPeople.Text = "People";
            this.btnPeople.UseVisualStyleBackColor = true;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // btnEarth
            // 
            this.btnEarth.Location = new System.Drawing.Point(259, 311);
            this.btnEarth.Name = "btnEarth";
            this.btnEarth.Size = new System.Drawing.Size(160, 45);
            this.btnEarth.TabIndex = 6;
            this.btnEarth.Text = "Earth";
            this.btnEarth.UseVisualStyleBackColor = true;
            this.btnEarth.Click += new System.EventHandler(this.btnEarth_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(205, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(42, 15);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "Nouns";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 203);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 424);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnEarth);
            this.Controls.Add(this.btnPeople);
            this.Controls.Add(this.btnAnimal);
            this.Controls.Add(this.btnPerson);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Name = "Tutorial";
            this.Text = "Tutorial";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Button btnPerson;
        private System.Windows.Forms.Button btnAnimal;
        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.Button btnEarth;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}