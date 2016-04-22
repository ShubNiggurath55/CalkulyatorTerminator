namespace ForCalkEg
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
            this.entry = new System.Windows.Forms.TextBox();
            this.conclusion = new System.Windows.Forms.TextBox();
            this.sub = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.divis = new System.Windows.Forms.Button();
            this.entrytwo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // entry
            // 
            this.entry.Location = new System.Drawing.Point(12, 25);
            this.entry.Name = "entry";
            this.entry.Size = new System.Drawing.Size(256, 20);
            this.entry.TabIndex = 0;
            // 
            // conclusion
            // 
            this.conclusion.Location = new System.Drawing.Point(12, 90);
            this.conclusion.Name = "conclusion";
            this.conclusion.Size = new System.Drawing.Size(256, 20);
            this.conclusion.TabIndex = 2;
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(80, 132);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(46, 23);
            this.sub.TabIndex = 3;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(12, 132);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(46, 23);
            this.sum.TabIndex = 4;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(151, 132);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(46, 23);
            this.mul.TabIndex = 5;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // divis
            // 
            this.divis.Location = new System.Drawing.Point(222, 132);
            this.divis.Name = "divis";
            this.divis.Size = new System.Drawing.Size(46, 23);
            this.divis.TabIndex = 6;
            this.divis.Text = ":";
            this.divis.UseVisualStyleBackColor = true;
            this.divis.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // entrytwo
            // 
            this.entrytwo.Location = new System.Drawing.Point(12, 51);
            this.entrytwo.Name = "entrytwo";
            this.entrytwo.Size = new System.Drawing.Size(256, 20);
            this.entrytwo.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.entrytwo);
            this.Controls.Add(this.divis);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.conclusion);
            this.Controls.Add(this.entry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox entry;
        private System.Windows.Forms.TextBox conclusion;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button divis;
        private System.Windows.Forms.TextBox entrytwo;
    }
}

