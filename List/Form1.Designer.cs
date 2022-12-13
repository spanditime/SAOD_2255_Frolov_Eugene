namespace List
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
            this.ValueTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IdxTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PrependBTN = new System.Windows.Forms.Button();
            this.AppendBTN = new System.Windows.Forms.Button();
            this.RemoveBTN = new System.Windows.Forms.Button();
            this.RemoveAtBTN = new System.Windows.Forms.Button();
            this.FindBTN = new System.Windows.Forms.Button();
            this.AtBTN = new System.Windows.Forms.Button();
            this.SortBTN = new System.Windows.Forms.Button();
            this.OutputTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ValueTB
            // 
            this.ValueTB.Location = new System.Drawing.Point(13, 38);
            this.ValueTB.Name = "ValueTB";
            this.ValueTB.Size = new System.Drawing.Size(100, 22);
            this.ValueTB.TabIndex = 0;
            this.ValueTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "value";
            // 
            // IdxTB
            // 
            this.IdxTB.Location = new System.Drawing.Point(119, 38);
            this.IdxTB.Name = "IdxTB";
            this.IdxTB.Size = new System.Drawing.Size(100, 22);
            this.IdxTB.TabIndex = 2;
            this.IdxTB.TextChanged += new System.EventHandler(this.IdxTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "idx";
            // 
            // PrependBTN
            // 
            this.PrependBTN.Location = new System.Drawing.Point(226, 38);
            this.PrependBTN.Name = "PrependBTN";
            this.PrependBTN.Size = new System.Drawing.Size(75, 23);
            this.PrependBTN.TabIndex = 5;
            this.PrependBTN.Text = "Prepend";
            this.PrependBTN.UseVisualStyleBackColor = true;
            this.PrependBTN.Click += new System.EventHandler(this.PrependBTN_Click);
            // 
            // AppendBTN
            // 
            this.AppendBTN.Location = new System.Drawing.Point(226, 13);
            this.AppendBTN.Name = "AppendBTN";
            this.AppendBTN.Size = new System.Drawing.Size(75, 23);
            this.AppendBTN.TabIndex = 6;
            this.AppendBTN.Text = "Append";
            this.AppendBTN.UseVisualStyleBackColor = true;
            this.AppendBTN.Click += new System.EventHandler(this.AppendBTN_Click);
            // 
            // RemoveBTN
            // 
            this.RemoveBTN.Location = new System.Drawing.Point(307, 13);
            this.RemoveBTN.Name = "RemoveBTN";
            this.RemoveBTN.Size = new System.Drawing.Size(88, 23);
            this.RemoveBTN.TabIndex = 8;
            this.RemoveBTN.Text = "Remove";
            this.RemoveBTN.UseVisualStyleBackColor = true;
            this.RemoveBTN.Click += new System.EventHandler(this.RemoveBTN_Click);
            // 
            // RemoveAtBTN
            // 
            this.RemoveAtBTN.Location = new System.Drawing.Point(307, 38);
            this.RemoveAtBTN.Name = "RemoveAtBTN";
            this.RemoveAtBTN.Size = new System.Drawing.Size(88, 23);
            this.RemoveAtBTN.TabIndex = 7;
            this.RemoveAtBTN.Text = "RemoveAt";
            this.RemoveAtBTN.UseVisualStyleBackColor = true;
            this.RemoveAtBTN.Click += new System.EventHandler(this.RemoveAtBTN_Click);
            // 
            // FindBTN
            // 
            this.FindBTN.Location = new System.Drawing.Point(401, 13);
            this.FindBTN.Name = "FindBTN";
            this.FindBTN.Size = new System.Drawing.Size(75, 23);
            this.FindBTN.TabIndex = 10;
            this.FindBTN.Text = "FInd";
            this.FindBTN.UseVisualStyleBackColor = true;
            this.FindBTN.Click += new System.EventHandler(this.FindBTN_Click);
            // 
            // AtBTN
            // 
            this.AtBTN.Location = new System.Drawing.Point(401, 38);
            this.AtBTN.Name = "AtBTN";
            this.AtBTN.Size = new System.Drawing.Size(75, 23);
            this.AtBTN.TabIndex = 9;
            this.AtBTN.Text = "At";
            this.AtBTN.UseVisualStyleBackColor = true;
            this.AtBTN.Click += new System.EventHandler(this.AtBTN_Click);
            // 
            // SortBTN
            // 
            this.SortBTN.Location = new System.Drawing.Point(482, 13);
            this.SortBTN.Name = "SortBTN";
            this.SortBTN.Size = new System.Drawing.Size(80, 47);
            this.SortBTN.TabIndex = 12;
            this.SortBTN.Text = "Sort";
            this.SortBTN.UseVisualStyleBackColor = true;
            // 
            // OutputTB
            // 
            this.OutputTB.Location = new System.Drawing.Point(13, 67);
            this.OutputTB.Name = "OutputTB";
            this.OutputTB.Size = new System.Drawing.Size(549, 22);
            this.OutputTB.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 102);
            this.Controls.Add(this.OutputTB);
            this.Controls.Add(this.SortBTN);
            this.Controls.Add(this.FindBTN);
            this.Controls.Add(this.AtBTN);
            this.Controls.Add(this.RemoveBTN);
            this.Controls.Add(this.RemoveAtBTN);
            this.Controls.Add(this.AppendBTN);
            this.Controls.Add(this.PrependBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdxTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValueTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ValueTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdxTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PrependBTN;
        private System.Windows.Forms.Button AppendBTN;
        private System.Windows.Forms.Button RemoveBTN;
        private System.Windows.Forms.Button RemoveAtBTN;
        private System.Windows.Forms.Button FindBTN;
        private System.Windows.Forms.Button AtBTN;
        private System.Windows.Forms.Button SortBTN;
        private System.Windows.Forms.TextBox OutputTB;
    }
}

