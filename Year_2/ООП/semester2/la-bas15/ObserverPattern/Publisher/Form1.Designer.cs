﻿namespace Publisher
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newspaperRB = new System.Windows.Forms.RadioButton();
            this.magazineRB = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pubsListBox = new System.Windows.Forms.ListBox();
            this.subsListBox = new System.Windows.Forms.ListBox();
            this.subButton = new System.Windows.Forms.Button();
            this.unsubBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(801, 223);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.magazineRB);
            this.groupBox1.Controls.Add(this.newspaperRB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(11, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Новое издание";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 20);
            this.textBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Назание";
            // 
            // newspaperRB
            // 
            this.newspaperRB.Location = new System.Drawing.Point(6, 52);
            this.newspaperRB.Name = "newspaperRB";
            this.newspaperRB.Size = new System.Drawing.Size(104, 24);
            this.newspaperRB.TabIndex = 2;
            this.newspaperRB.TabStop = true;
            this.newspaperRB.Text = "Газета";
            this.newspaperRB.UseVisualStyleBackColor = true;
            // 
            // magazineRB
            // 
            this.magazineRB.Location = new System.Drawing.Point(169, 52);
            this.magazineRB.Name = "magazineRB";
            this.magazineRB.Size = new System.Drawing.Size(104, 24);
            this.magazineRB.TabIndex = 3;
            this.magazineRB.TabStop = true;
            this.magazineRB.Text = "Журналъ";
            this.magazineRB.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Запилить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pubsListBox
            // 
            this.pubsListBox.FormattingEnabled = true;
            this.pubsListBox.Location = new System.Drawing.Point(15, 360);
            this.pubsListBox.Name = "pubsListBox";
            this.pubsListBox.Size = new System.Drawing.Size(278, 212);
            this.pubsListBox.TabIndex = 2;
            // 
            // subsListBox
            // 
            this.subsListBox.FormattingEnabled = true;
            this.subsListBox.Location = new System.Drawing.Point(510, 360);
            this.subsListBox.Name = "subsListBox";
            this.subsListBox.Size = new System.Drawing.Size(278, 212);
            this.subsListBox.TabIndex = 3;
            // 
            // subButton
            // 
            this.subButton.Location = new System.Drawing.Point(323, 369);
            this.subButton.Name = "subButton";
            this.subButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subButton.Size = new System.Drawing.Size(139, 24);
            this.subButton.TabIndex = 4;
            this.subButton.Text = "Подписать";
            this.subButton.UseVisualStyleBackColor = true;
            // 
            // unsubBtn
            // 
            this.unsubBtn.Location = new System.Drawing.Point(323, 399);
            this.unsubBtn.Name = "unsubBtn";
            this.unsubBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.unsubBtn.Size = new System.Drawing.Size(139, 24);
            this.unsubBtn.TabIndex = 5;
            this.unsubBtn.Text = "Дизлайк отписка";
            this.unsubBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.unsubBtn);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.subsListBox);
            this.Controls.Add(this.pubsListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Публишор";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton magazineRB;
        private System.Windows.Forms.RadioButton newspaperRB;
        private System.Windows.Forms.ListBox pubsListBox;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.ListBox subsListBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button unsubBtn;

        #endregion
    }
}