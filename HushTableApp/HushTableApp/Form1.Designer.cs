namespace HushTableApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.isbnToAddTextBox = new System.Windows.Forms.TextBox();
            this.bookDetailsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.isbnToSearchTextBox = new System.Windows.Forms.TextBox();
            this.bookDetailsToSearchTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.seachButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Details";
            // 
            // isbnToAddTextBox
            // 
            this.isbnToAddTextBox.Location = new System.Drawing.Point(138, 56);
            this.isbnToAddTextBox.Name = "isbnToAddTextBox";
            this.isbnToAddTextBox.Size = new System.Drawing.Size(100, 20);
            this.isbnToAddTextBox.TabIndex = 2;
            // 
            // bookDetailsTextBox
            // 
            this.bookDetailsTextBox.Location = new System.Drawing.Point(138, 98);
            this.bookDetailsTextBox.Multiline = true;
            this.bookDetailsTextBox.Name = "bookDetailsTextBox";
            this.bookDetailsTextBox.Size = new System.Drawing.Size(100, 53);
            this.bookDetailsTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "BooK Details";
            // 
            // isbnToSearchTextBox
            // 
            this.isbnToSearchTextBox.Location = new System.Drawing.Point(138, 200);
            this.isbnToSearchTextBox.Name = "isbnToSearchTextBox";
            this.isbnToSearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.isbnToSearchTextBox.TabIndex = 6;
            // 
            // bookDetailsToSearchTextBox
            // 
            this.bookDetailsToSearchTextBox.Location = new System.Drawing.Point(138, 271);
            this.bookDetailsToSearchTextBox.Multiline = true;
            this.bookDetailsToSearchTextBox.Name = "bookDetailsToSearchTextBox";
            this.bookDetailsToSearchTextBox.Size = new System.Drawing.Size(100, 50);
            this.bookDetailsToSearchTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addButton_Click);
            // 
            // seachButton
            // 
            this.seachButton.Location = new System.Drawing.Point(306, 200);
            this.seachButton.Name = "seachButton";
            this.seachButton.Size = new System.Drawing.Size(75, 23);
            this.seachButton.TabIndex = 9;
            this.seachButton.Text = "Search";
            this.seachButton.UseVisualStyleBackColor = true;
            this.seachButton.Click += new System.EventHandler(this.seachButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 420);
            this.Controls.Add(this.seachButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bookDetailsToSearchTextBox);
            this.Controls.Add(this.isbnToSearchTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookDetailsTextBox);
            this.Controls.Add(this.isbnToAddTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox isbnToAddTextBox;
        private System.Windows.Forms.TextBox bookDetailsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox isbnToSearchTextBox;
        private System.Windows.Forms.TextBox bookDetailsToSearchTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button seachButton;
    }
}

