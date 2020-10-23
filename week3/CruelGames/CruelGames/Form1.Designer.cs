namespace CruelGames
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
            this.rbtnYoung = new System.Windows.Forms.RadioButton();
            this.rbtnMiddle = new System.Windows.Forms.RadioButton();
            this.rbtnOld = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is yout age?";
            // 
            // rbtnYoung
            // 
            this.rbtnYoung.AutoSize = true;
            this.rbtnYoung.Location = new System.Drawing.Point(70, 91);
            this.rbtnYoung.Name = "rbtnYoung";
            this.rbtnYoung.Size = new System.Drawing.Size(72, 29);
            this.rbtnYoung.TabIndex = 1;
            this.rbtnYoung.TabStop = true;
            this.rbtnYoung.Text = "< 21";
            this.rbtnYoung.UseVisualStyleBackColor = true;
            // 
            // rbtnMiddle
            // 
            this.rbtnMiddle.AutoSize = true;
            this.rbtnMiddle.Location = new System.Drawing.Point(70, 126);
            this.rbtnMiddle.Name = "rbtnMiddle";
            this.rbtnMiddle.Size = new System.Drawing.Size(103, 29);
            this.rbtnMiddle.TabIndex = 2;
            this.rbtnMiddle.TabStop = true;
            this.rbtnMiddle.Text = "21 to 35";
            this.rbtnMiddle.UseVisualStyleBackColor = true;
            // 
            // rbtnOld
            // 
            this.rbtnOld.AutoSize = true;
            this.rbtnOld.Location = new System.Drawing.Point(70, 161);
            this.rbtnOld.Name = "rbtnOld";
            this.rbtnOld.Size = new System.Drawing.Size(72, 29);
            this.rbtnOld.TabIndex = 3;
            this.rbtnOld.TabStop = true;
            this.rbtnOld.Text = "> 35";
            this.rbtnOld.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(23, 231);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(277, 47);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start the game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 303);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rbtnOld);
            this.Controls.Add(this.rbtnMiddle);
            this.Controls.Add(this.rbtnYoung);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Cruel Games";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnYoung;
        private System.Windows.Forms.RadioButton rbtnMiddle;
        private System.Windows.Forms.RadioButton rbtnOld;
        private System.Windows.Forms.Button btnStart;
    }
}

