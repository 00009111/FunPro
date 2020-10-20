namespace interestCalculator
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txbName = new System.Windows.Forms.TextBox();
            this.nudRate = new System.Windows.Forms.NumericUpDown();
            this.nudDeposit = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeposit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(287, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(142, 137);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(117, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Enter Your Name";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(142, 187);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(156, 17);
            this.lblDeposit.TabIndex = 2;
            this.lblDeposit.Text = "Deposit Amount in USD";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(142, 250);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(120, 17);
            this.lblRate.TabIndex = 3;
            this.lblRate.Text = "Interest Rate in %";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(233, 325);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(169, 64);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(304, 132);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(120, 22);
            this.txbName.TabIndex = 5;
            this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
            // 
            // nudRate
            // 
            this.nudRate.DecimalPlaces = 2;
            this.nudRate.Location = new System.Drawing.Point(304, 248);
            this.nudRate.Name = "nudRate";
            this.nudRate.Size = new System.Drawing.Size(120, 22);
            this.nudRate.TabIndex = 6;
            // 
            // nudDeposit
            // 
            this.nudDeposit.DecimalPlaces = 2;
            this.nudDeposit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudDeposit.Location = new System.Drawing.Point(304, 182);
            this.nudDeposit.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.nudDeposit.Name = "nudDeposit";
            this.nudDeposit.Size = new System.Drawing.Size(120, 22);
            this.nudDeposit.TabIndex = 7;
            this.nudDeposit.ValueChanged += new System.EventHandler(this.nudDeposit_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudDeposit);
            this.Controls.Add(this.nudRate);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Interest Rate Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeposit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.NumericUpDown nudRate;
        private System.Windows.Forms.NumericUpDown nudDeposit;
    }
}

