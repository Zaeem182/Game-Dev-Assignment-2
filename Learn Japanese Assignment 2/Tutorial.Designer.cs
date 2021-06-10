
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
            this.btb1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btb1
            // 
            this.btb1.Location = new System.Drawing.Point(12, 24);
            this.btb1.Name = "btb1";
            this.btb1.Size = new System.Drawing.Size(183, 284);
            this.btb1.TabIndex = 0;
            this.btb1.Text = "Tutorial";
            this.btb1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(252, 24);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(183, 284);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Start Learning";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 338);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btb1);
            this.Name = "Tutorial";
            this.Text = "Tutorial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btb1;
        private System.Windows.Forms.Button btn2;
    }
}