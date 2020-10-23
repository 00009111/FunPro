namespace LeapYear
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
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.btnResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.SuspendLayout();
            // 
            // nudYear
            // 
            this.nudYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.nudYear.Location = new System.Drawing.Point(259, 92);
            this.nudYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudYear.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(180, 41);
            this.nudYear.TabIndex = 0;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(28, 220);
            this.btnResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(527, 57);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "Check";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(22, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insert the year";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.nudYear);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Leap Year ";
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label label1;
    }
}

