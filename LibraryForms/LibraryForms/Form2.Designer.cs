﻿namespace LibraryForms
{
    partial class Form2
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
            Janr = new ListBox();
            Author = new ListBox();
            label1 = new Label();
            label2 = new Label();
            BookName = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // Janr
            // 
            Janr.FormattingEnabled = true;
            Janr.ItemHeight = 20;
            Janr.Location = new Point(122, 32);
            Janr.Name = "Janr";
            Janr.Size = new Size(150, 104);
            Janr.TabIndex = 0;
            // 
            // Author
            // 
            Author.FormattingEnabled = true;
            Author.ItemHeight = 20;
            Author.Location = new Point(337, 32);
            Author.Name = "Author";
            Author.Size = new Size(150, 104);
            Author.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 215);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 2;
            label1.Text = "Choose book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 276);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 2;
            label2.Text = "Enter Book Name";
            // 
            // BookName
            // 
            BookName.FormattingEnabled = true;
            BookName.ItemHeight = 20;
            BookName.Location = new Point(549, 32);
            BookName.Name = "BookName";
            BookName.Size = new Size(150, 104);
            BookName.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(151, 151);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(372, 151);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Show";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(584, 151);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "Show";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(324, 269);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 27);
            textBox1.TabIndex = 6;
            // 
            // button4
            // 
            button4.Location = new Point(178, 332);
            button4.Name = "button4";
            button4.Size = new Size(115, 29);
            button4.TabIndex = 7;
            button4.Text = "Take Book";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(178, 396);
            button5.Name = "button5";
            button5.Size = new Size(115, 29);
            button5.TabIndex = 7;
            button5.Text = "Return Book";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 9);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 2;
            label3.Text = "Janr";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 9);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 2;
            label4.Text = "Author";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(549, 9);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 2;
            label5.Text = "Book Name";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BookName);
            Controls.Add(Author);
            Controls.Add(Janr);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Janr;
        private ListBox Author;
        private Label label1;
        private Label label2;
        private ListBox BookName;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Button button4;
        private Button button5;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}