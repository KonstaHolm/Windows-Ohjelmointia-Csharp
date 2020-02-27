namespace Harjoitus_3._2
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
            this.print_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.author_textbox = new System.Windows.Forms.TextBox();
            this.bookName_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // print_button
            // 
            this.print_button.Location = new System.Drawing.Point(329, 384);
            this.print_button.Name = "print_button";
            this.print_button.Size = new System.Drawing.Size(75, 23);
            this.print_button.TabIndex = 0;
            this.print_button.Text = "Print";
            this.print_button.UseVisualStyleBackColor = true;
            this.print_button.Click += new System.EventHandler(this.print_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(329, 139);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 1;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // author_textbox
            // 
            this.author_textbox.Location = new System.Drawing.Point(68, 139);
            this.author_textbox.Name = "author_textbox";
            this.author_textbox.Size = new System.Drawing.Size(213, 20);
            this.author_textbox.TabIndex = 2;
            // 
            // bookName_textbox
            // 
            this.bookName_textbox.Location = new System.Drawing.Point(68, 53);
            this.bookName_textbox.Name = "bookName_textbox";
            this.bookName_textbox.Size = new System.Drawing.Size(213, 20);
            this.bookName_textbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Book name";
            // 
            // printBox
            // 
            this.printBox.Location = new System.Drawing.Point(68, 208);
            this.printBox.Multiline = true;
            this.printBox.Name = "printBox";
            this.printBox.Size = new System.Drawing.Size(336, 113);
            this.printBox.TabIndex = 6;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(329, 59);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 13);
            this.infoLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 453);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.printBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookName_textbox);
            this.Controls.Add(this.author_textbox);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.print_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button print_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.TextBox author_textbox;
        private System.Windows.Forms.TextBox bookName_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox printBox;
        private System.Windows.Forms.Label infoLabel;
    }
}

