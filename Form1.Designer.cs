﻿namespace AT3SprintOne
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.sortBtn = new System.Windows.Forms.Button();
            this.generateBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.binarySearchBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.MidExBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ModeBtn = new System.Windows.Forms.Button();
            this.AverageBtn = new System.Windows.Forms.Button();
            this.RangeBtn = new System.Windows.Forms.Button();
            this.statsBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SeqSearchBtn = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(127, 368);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(12, 12);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(127, 25);
            this.sortBtn.TabIndex = 3;
            this.sortBtn.Text = "SORT";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(12, 427);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(127, 30);
            this.generateBtn.TabIndex = 4;
            this.generateBtn.Text = "GENERATE";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(179, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input:";
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(310, 41);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(46, 23);
            this.editBtn.TabIndex = 6;
            this.editBtn.Text = "EDIT";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // binarySearchBtn
            // 
            this.binarySearchBtn.Location = new System.Drawing.Point(201, 93);
            this.binarySearchBtn.Name = "binarySearchBtn";
            this.binarySearchBtn.Size = new System.Drawing.Size(133, 23);
            this.binarySearchBtn.TabIndex = 6;
            this.binarySearchBtn.Text = "BINARY SEARCH";
            this.binarySearchBtn.UseVisualStyleBackColor = true;
            this.binarySearchBtn.Click += new System.EventHandler(this.binarySearchBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(374, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Status: ";
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(106, 17);
            this.Status.Text = "Program Initialized";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hourly Neutrinos";
            // 
            // MidExBtn
            // 
            this.MidExBtn.Location = new System.Drawing.Point(182, 255);
            this.MidExBtn.Name = "MidExBtn";
            this.MidExBtn.Size = new System.Drawing.Size(75, 23);
            this.MidExBtn.TabIndex = 9;
            this.MidExBtn.Text = "Mid-Extreme";
            this.MidExBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Statistics";
            // 
            // ModeBtn
            // 
            this.ModeBtn.Location = new System.Drawing.Point(182, 276);
            this.ModeBtn.Name = "ModeBtn";
            this.ModeBtn.Size = new System.Drawing.Size(75, 23);
            this.ModeBtn.TabIndex = 9;
            this.ModeBtn.Text = "Mode";
            this.ModeBtn.UseVisualStyleBackColor = true;
            // 
            // AverageBtn
            // 
            this.AverageBtn.Location = new System.Drawing.Point(182, 296);
            this.AverageBtn.Name = "AverageBtn";
            this.AverageBtn.Size = new System.Drawing.Size(75, 23);
            this.AverageBtn.TabIndex = 9;
            this.AverageBtn.Text = "Average";
            this.AverageBtn.UseVisualStyleBackColor = true;
            // 
            // RangeBtn
            // 
            this.RangeBtn.Location = new System.Drawing.Point(182, 316);
            this.RangeBtn.Name = "RangeBtn";
            this.RangeBtn.Size = new System.Drawing.Size(75, 23);
            this.RangeBtn.TabIndex = 9;
            this.RangeBtn.Text = "Range";
            this.RangeBtn.UseVisualStyleBackColor = true;
            // 
            // statsBox
            // 
            this.statsBox.Location = new System.Drawing.Point(182, 365);
            this.statsBox.Multiline = true;
            this.statsBox.Name = "statsBox";
            this.statsBox.Size = new System.Drawing.Size(152, 38);
            this.statsBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Stats Results:";
            // 
            // SeqSearchBtn
            // 
            this.SeqSearchBtn.Location = new System.Drawing.Point(201, 118);
            this.SeqSearchBtn.Name = "SeqSearchBtn";
            this.SeqSearchBtn.Size = new System.Drawing.Size(133, 23);
            this.SeqSearchBtn.TabIndex = 6;
            this.SeqSearchBtn.Text = "SEQUENTIAL SEARCH";
            this.SeqSearchBtn.UseVisualStyleBackColor = true;
            this.SeqSearchBtn.Click += new System.EventHandler(this.SeqSearchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 482);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statsBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RangeBtn);
            this.Controls.Add(this.AverageBtn);
            this.Controls.Add(this.ModeBtn);
            this.Controls.Add(this.MidExBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.SeqSearchBtn);
            this.Controls.Add(this.binarySearchBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Astronomical Processing";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button binarySearchBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MidExBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ModeBtn;
        private System.Windows.Forms.Button AverageBtn;
        private System.Windows.Forms.Button RangeBtn;
        private System.Windows.Forms.TextBox statsBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SeqSearchBtn;
    }
}

