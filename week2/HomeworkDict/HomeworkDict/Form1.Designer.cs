namespace HomeworkDict
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
            this.tbxEnglish = new System.Windows.Forms.TextBox();
            this.tbxElbanian = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "English";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elbanian";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbxEnglish
            // 
            this.tbxEnglish.BackColor = System.Drawing.SystemColors.Info;
            this.tbxEnglish.Location = new System.Drawing.Point(46, 124);
            this.tbxEnglish.Name = "tbxEnglish";
            this.tbxEnglish.Size = new System.Drawing.Size(222, 41);
            this.tbxEnglish.TabIndex = 2;
            // 
            // tbxElbanian
            // 
            this.tbxElbanian.BackColor = System.Drawing.SystemColors.Info;
            this.tbxElbanian.Location = new System.Drawing.Point(363, 124);
            this.tbxElbanian.Name = "tbxElbanian";
            this.tbxElbanian.Size = new System.Drawing.Size(222, 41);
            this.tbxElbanian.TabIndex = 3;
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.Gainsboro;
            this.btnResult.Location = new System.Drawing.Point(197, 220);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(238, 84);
            this.btnResult.TabIndex = 4;
            this.btnResult.Text = "Translate";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 404);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.tbxElbanian);
            this.Controls.Add(this.tbxEnglish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "En-EL Dict";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxEnglish;
        private System.Windows.Forms.TextBox tbxElbanian;
        private System.Windows.Forms.Button btnResult;
    }
}

