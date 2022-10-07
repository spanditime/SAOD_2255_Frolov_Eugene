﻿namespace Stack
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
            this.push = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.pop = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // push
            // 
            this.push.Location = new System.Drawing.Point(119, 12);
            this.push.Name = "push";
            this.push.Size = new System.Drawing.Size(75, 23);
            this.push.TabIndex = 0;
            this.push.Text = "push";
            this.push.UseVisualStyleBackColor = true;
            this.push.Click += new System.EventHandler(this.push_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(13, 12);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 22);
            this.input.TabIndex = 1;
            this.input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pop
            // 
            this.pop.Location = new System.Drawing.Point(200, 12);
            this.pop.Name = "pop";
            this.pop.Size = new System.Drawing.Size(75, 23);
            this.pop.TabIndex = 2;
            this.pop.Text = "pop";
            this.pop.UseVisualStyleBackColor = true;
            this.pop.Click += new System.EventHandler(this.pop_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(281, 12);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 3;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(13, 61);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(343, 22);
            this.output.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 99);
            this.Controls.Add(this.output);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.pop);
            this.Controls.Add(this.input);
            this.Controls.Add(this.push);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button push;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button pop;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox output;
    }
}

