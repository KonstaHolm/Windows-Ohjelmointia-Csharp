namespace Koe2
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
            this.ympyraButton = new System.Windows.Forms.Button();
            this.NelioButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tulostaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ympyraButton
            // 
            this.ympyraButton.Location = new System.Drawing.Point(116, 85);
            this.ympyraButton.Name = "ympyraButton";
            this.ympyraButton.Size = new System.Drawing.Size(75, 23);
            this.ympyraButton.TabIndex = 0;
            this.ympyraButton.Text = "Ympyrä";
            this.ympyraButton.UseVisualStyleBackColor = true;
            this.ympyraButton.Click += new System.EventHandler(this.ympyraButton_Click);
            // 
            // NelioButton
            // 
            this.NelioButton.Location = new System.Drawing.Point(327, 85);
            this.NelioButton.Name = "NelioButton";
            this.NelioButton.Size = new System.Drawing.Size(75, 23);
            this.NelioButton.TabIndex = 1;
            this.NelioButton.Text = "Neliö";
            this.NelioButton.UseVisualStyleBackColor = true;
            this.NelioButton.Click += new System.EventHandler(this.NelioButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 142);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 230);
            this.textBox1.TabIndex = 2;
            // 
            // tulostaButton
            // 
            this.tulostaButton.Location = new System.Drawing.Point(388, 349);
            this.tulostaButton.Name = "tulostaButton";
            this.tulostaButton.Size = new System.Drawing.Size(75, 23);
            this.tulostaButton.TabIndex = 3;
            this.tulostaButton.Text = "Tulosta";
            this.tulostaButton.UseVisualStyleBackColor = true;
            this.tulostaButton.Click += new System.EventHandler(this.tulostaButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tulostaButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NelioButton);
            this.Controls.Add(this.ympyraButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ympyraButton;
        private System.Windows.Forms.Button NelioButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button tulostaButton;
    }
}

