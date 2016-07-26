namespace BMICalculatorApp
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
            this.INFOHOLDER = new System.Windows.Forms.TableLayoutPanel();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.MetricBtn = new System.Windows.Forms.RadioButton();
            this.ImperialBtn = new System.Windows.Forms.RadioButton();
            this.ftTxtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inchesTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.INFOHOLDER.SuspendLayout();
            this.SuspendLayout();
            // 
            // INFOHOLDER
            // 
            this.INFOHOLDER.ColumnCount = 3;
            this.INFOHOLDER.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.95781F));
            this.INFOHOLDER.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.37131F));
            this.INFOHOLDER.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.88186F));
            this.INFOHOLDER.Controls.Add(this.ftTxtbx, 1, 0);
            this.INFOHOLDER.Controls.Add(this.label1, 1, 1);
            this.INFOHOLDER.Controls.Add(this.inchesTxtBx, 2, 0);
            this.INFOHOLDER.Controls.Add(this.label2, 2, 1);
            this.INFOHOLDER.Controls.Add(this.WeightLabel, 0, 2);
            this.INFOHOLDER.Controls.Add(this.MetricBtn, 1, 4);
            this.INFOHOLDER.Controls.Add(this.ImperialBtn, 2, 4);
            this.INFOHOLDER.Controls.Add(this.textBox1, 1, 2);
            this.INFOHOLDER.Controls.Add(this.label3, 1, 3);
            this.INFOHOLDER.Controls.Add(this.HeightLabel, 0, 0);
            this.INFOHOLDER.Location = new System.Drawing.Point(74, 151);
            this.INFOHOLDER.Name = "INFOHOLDER";
            this.INFOHOLDER.RowCount = 5;
            this.INFOHOLDER.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.29412F));
            this.INFOHOLDER.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.70588F));
            this.INFOHOLDER.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.INFOHOLDER.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.INFOHOLDER.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.INFOHOLDER.Size = new System.Drawing.Size(474, 211);
            this.INFOHOLDER.TabIndex = 0;
            this.INFOHOLDER.Paint += new System.Windows.Forms.PaintEventHandler(this.INFOHOLDER_Paint);
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HeightLabel.Location = new System.Drawing.Point(3, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(114, 38);
            this.HeightLabel.TabIndex = 0;
            this.HeightLabel.Text = "Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HeightLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(3, 72);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(118, 38);
            this.WeightLabel.TabIndex = 1;
            this.WeightLabel.Text = "Weight";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WeightLabel.Click += new System.EventHandler(this.WeightLabel_Click);
            // 
            // MetricBtn
            // 
            this.MetricBtn.AutoSize = true;
            this.MetricBtn.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricBtn.Location = new System.Drawing.Point(144, 174);
            this.MetricBtn.Name = "MetricBtn";
            this.MetricBtn.Size = new System.Drawing.Size(112, 34);
            this.MetricBtn.TabIndex = 5;
            this.MetricBtn.TabStop = true;
            this.MetricBtn.Text = "Metric";
            this.MetricBtn.UseVisualStyleBackColor = true;
            // 
            // ImperialBtn
            // 
            this.ImperialBtn.AutoSize = true;
            this.ImperialBtn.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialBtn.Location = new System.Drawing.Point(268, 174);
            this.ImperialBtn.Name = "ImperialBtn";
            this.ImperialBtn.Size = new System.Drawing.Size(141, 34);
            this.ImperialBtn.TabIndex = 4;
            this.ImperialBtn.TabStop = true;
            this.ImperialBtn.Text = "Imperial";
            this.ImperialBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ImperialBtn.UseVisualStyleBackColor = true;
            // 
            // ftTxtbx
            // 
            this.ftTxtbx.Location = new System.Drawing.Point(144, 3);
            this.ftTxtbx.Name = "ftTxtbx";
            this.ftTxtbx.Size = new System.Drawing.Size(100, 38);
            this.ftTxtbx.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "FT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inchesTxtBx
            // 
            this.inchesTxtBx.Location = new System.Drawing.Point(268, 3);
            this.inchesTxtBx.Name = "inchesTxtBx";
            this.inchesTxtBx.Size = new System.Drawing.Size(100, 38);
            this.inchesTxtBx.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "IN";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 38);
            this.textBox1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "KG";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 1057);
            this.Controls.Add(this.INFOHOLDER);
            this.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI CALCULATOR";
            this.INFOHOLDER.ResumeLayout(false);
            this.INFOHOLDER.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel INFOHOLDER;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.RadioButton MetricBtn;
        private System.Windows.Forms.RadioButton ImperialBtn;
        private System.Windows.Forms.TextBox ftTxtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inchesTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}

