namespace BMICalculatorApp
{
    partial class BMI_Form
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.Metric_Information = new System.Windows.Forms.GroupBox();
            this.KiloLbl = new System.Windows.Forms.Label();
            this.inchesLbl = new System.Windows.Forms.Label();
            this.KiloTextBox = new System.Windows.Forms.TextBox();
            this.InchesTextBox = new System.Windows.Forms.TextBox();
            this.WeightLbl = new System.Windows.Forms.Label();
            this.HeightLbl = new System.Windows.Forms.Label();
            this.Imperial_information = new System.Windows.Forms.GroupBox();
            this.LbsLbl = new System.Windows.Forms.Label();
            this.cmLbl = new System.Windows.Forms.Label();
            this.LblTxtBx = new System.Windows.Forms.TextBox();
            this.CmTxtBx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BMI_ResultLbl = new System.Windows.Forms.Label();
            this.ImperialButton = new System.Windows.Forms.RadioButton();
            this.MetricButton = new System.Windows.Forms.RadioButton();
            this.ResultTextBx = new System.Windows.Forms.TextBox();
            this.Metric_Information.SuspendLayout();
            this.Imperial_information.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(95, 481);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(172, 38);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "Calculate BMI";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(378, 481);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(172, 38);
            this.ClearBtn.TabIndex = 2;
            this.ClearBtn.Text = "Clear Form";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Metric_Information
            // 
            this.Metric_Information.BackColor = System.Drawing.Color.White;
            this.Metric_Information.Controls.Add(this.KiloLbl);
            this.Metric_Information.Controls.Add(this.inchesLbl);
            this.Metric_Information.Controls.Add(this.KiloTextBox);
            this.Metric_Information.Controls.Add(this.InchesTextBox);
            this.Metric_Information.Controls.Add(this.WeightLbl);
            this.Metric_Information.Controls.Add(this.HeightLbl);
            this.Metric_Information.Location = new System.Drawing.Point(95, 69);
            this.Metric_Information.Name = "Metric_Information";
            this.Metric_Information.Size = new System.Drawing.Size(477, 180);
            this.Metric_Information.TabIndex = 3;
            this.Metric_Information.TabStop = false;
            this.Metric_Information.UseCompatibleTextRendering = true;
            this.Metric_Information.UseWaitCursor = true;
            this.Metric_Information.Visible = false;
            this.Metric_Information.VisibleChanged += new System.EventHandler(this.Information_Enter);
            this.Metric_Information.Enter += new System.EventHandler(this.Information_Enter);
            // 
            // KiloLbl
            // 
            this.KiloLbl.AutoSize = true;
            this.KiloLbl.Location = new System.Drawing.Point(243, 97);
            this.KiloLbl.Name = "KiloLbl";
            this.KiloLbl.Size = new System.Drawing.Size(37, 31);
            this.KiloLbl.TabIndex = 7;
            this.KiloLbl.Text = "kg";
            this.KiloLbl.UseWaitCursor = true;
            // 
            // inchesLbl
            // 
            this.inchesLbl.AutoSize = true;
            this.inchesLbl.Location = new System.Drawing.Point(249, 42);
            this.inchesLbl.Name = "inchesLbl";
            this.inchesLbl.Size = new System.Drawing.Size(31, 31);
            this.inchesLbl.TabIndex = 6;
            this.inchesLbl.Text = "in";
            this.inchesLbl.UseWaitCursor = true;
            // 
            // KiloTextBox
            // 
            this.KiloTextBox.Location = new System.Drawing.Point(165, 90);
            this.KiloTextBox.Name = "KiloTextBox";
            this.KiloTextBox.Size = new System.Drawing.Size(72, 38);
            this.KiloTextBox.TabIndex = 4;
            this.KiloTextBox.UseWaitCursor = true;
            // 
            // InchesTextBox
            // 
            this.InchesTextBox.Location = new System.Drawing.Point(165, 35);
            this.InchesTextBox.Name = "InchesTextBox";
            this.InchesTextBox.Size = new System.Drawing.Size(72, 38);
            this.InchesTextBox.TabIndex = 3;
            this.InchesTextBox.UseWaitCursor = true;
            // 
            // WeightLbl
            // 
            this.WeightLbl.AutoSize = true;
            this.WeightLbl.Location = new System.Drawing.Point(25, 90);
            this.WeightLbl.Name = "WeightLbl";
            this.WeightLbl.Size = new System.Drawing.Size(123, 31);
            this.WeightLbl.TabIndex = 1;
            this.WeightLbl.Text = " My Weight";
            this.WeightLbl.UseWaitCursor = true;
            // 
            // HeightLbl
            // 
            this.HeightLbl.AutoSize = true;
            this.HeightLbl.Location = new System.Drawing.Point(19, 38);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(118, 31);
            this.HeightLbl.TabIndex = 0;
            this.HeightLbl.Text = " My Height";
            this.HeightLbl.UseWaitCursor = true;
            // 
            // Imperial_information
            // 
            this.Imperial_information.BackColor = System.Drawing.Color.White;
            this.Imperial_information.Controls.Add(this.LbsLbl);
            this.Imperial_information.Controls.Add(this.cmLbl);
            this.Imperial_information.Controls.Add(this.LblTxtBx);
            this.Imperial_information.Controls.Add(this.CmTxtBx);
            this.Imperial_information.Controls.Add(this.label5);
            this.Imperial_information.Controls.Add(this.label6);
            this.Imperial_information.Location = new System.Drawing.Point(105, 63);
            this.Imperial_information.Name = "Imperial_information";
            this.Imperial_information.Size = new System.Drawing.Size(477, 180);
            this.Imperial_information.TabIndex = 8;
            this.Imperial_information.TabStop = false;
            this.Imperial_information.UseCompatibleTextRendering = true;
            this.Imperial_information.UseWaitCursor = true;
            this.Imperial_information.Visible = false;
            this.Imperial_information.VisibleChanged += new System.EventHandler(this.Information_Enter);
            this.Imperial_information.Enter += new System.EventHandler(this.Information_Enter);
            // 
            // LbsLbl
            // 
            this.LbsLbl.AutoSize = true;
            this.LbsLbl.Location = new System.Drawing.Point(243, 97);
            this.LbsLbl.Name = "LbsLbl";
            this.LbsLbl.Size = new System.Drawing.Size(42, 31);
            this.LbsLbl.TabIndex = 7;
            this.LbsLbl.Text = "lbs";
            this.LbsLbl.UseWaitCursor = true;
            // 
            // cmLbl
            // 
            this.cmLbl.AutoSize = true;
            this.cmLbl.Location = new System.Drawing.Point(229, 44);
            this.cmLbl.Name = "cmLbl";
            this.cmLbl.Size = new System.Drawing.Size(43, 31);
            this.cmLbl.TabIndex = 5;
            this.cmLbl.Text = "cm";
            this.cmLbl.UseWaitCursor = true;
            this.cmLbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // LblTxtBx
            // 
            this.LblTxtBx.Location = new System.Drawing.Point(165, 90);
            this.LblTxtBx.Name = "LblTxtBx";
            this.LblTxtBx.Size = new System.Drawing.Size(72, 38);
            this.LblTxtBx.TabIndex = 4;
            this.LblTxtBx.UseWaitCursor = true;
            this.LblTxtBx.TextChanged += new System.EventHandler(this.LblTxtBx_TextChanged);
            // 
            // CmTxtBx
            // 
            this.CmTxtBx.AcceptsTab = true;
            this.CmTxtBx.HideSelection = false;
            this.CmTxtBx.Location = new System.Drawing.Point(165, 37);
            this.CmTxtBx.Name = "CmTxtBx";
            this.CmTxtBx.Size = new System.Drawing.Size(58, 38);
            this.CmTxtBx.TabIndex = 2;
            this.CmTxtBx.UseWaitCursor = true;
            this.CmTxtBx.TextChanged += new System.EventHandler(this.imp_info);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = " My Weight";
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = " My Height";
            this.label6.UseWaitCursor = true;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // BMI_ResultLbl
            // 
            this.BMI_ResultLbl.AutoSize = true;
            this.BMI_ResultLbl.Location = new System.Drawing.Point(68, 337);
            this.BMI_ResultLbl.Name = "BMI_ResultLbl";
            this.BMI_ResultLbl.Size = new System.Drawing.Size(273, 31);
            this.BMI_ResultLbl.TabIndex = 4;
            this.BMI_ResultLbl.Text = "Your Body Mass Index is : ";
            // 
            // ImperialButton
            // 
            this.ImperialButton.AutoSize = true;
            this.ImperialButton.Location = new System.Drawing.Point(170, 267);
            this.ImperialButton.Name = "ImperialButton";
            this.ImperialButton.Size = new System.Drawing.Size(109, 35);
            this.ImperialButton.TabIndex = 5;
            this.ImperialButton.TabStop = true;
            this.ImperialButton.Text = "Imperial";
            this.ImperialButton.UseVisualStyleBackColor = true;
            this.ImperialButton.CheckedChanged += new System.EventHandler(this.ImperialButton_CheckedChanged);
            // 
            // MetricButton
            // 
            this.MetricButton.AutoSize = true;
            this.MetricButton.Location = new System.Drawing.Point(323, 267);
            this.MetricButton.Name = "MetricButton";
            this.MetricButton.Size = new System.Drawing.Size(91, 35);
            this.MetricButton.TabIndex = 6;
            this.MetricButton.TabStop = true;
            this.MetricButton.Text = "Metric";
            this.MetricButton.UseVisualStyleBackColor = true;
            this.MetricButton.CheckedChanged += new System.EventHandler(this.MetricButton_CheckedChanged);
            // 
            // ResultTextBx
            // 
            this.ResultTextBx.Location = new System.Drawing.Point(105, 376);
            this.ResultTextBx.Name = "ResultTextBx";
            this.ResultTextBx.Size = new System.Drawing.Size(444, 38);
            this.ResultTextBx.TabIndex = 9;
            this.ResultTextBx.TextChanged += new System.EventHandler(this.ResultTextBx_TextChanged);
            // 
            // BMI_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 1057);
            this.Controls.Add(this.ResultTextBx);
            this.Controls.Add(this.Imperial_information);
            this.Controls.Add(this.MetricButton);
            this.Controls.Add(this.ImperialButton);
            this.Controls.Add(this.BMI_ResultLbl);
            this.Controls.Add(this.Metric_Information);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CalculateButton);
            this.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "BMI_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI CALCULATOR";
            this.Load += new System.EventHandler(this.BMI_Form_Load);
            this.Metric_Information.ResumeLayout(false);
            this.Metric_Information.PerformLayout();
            this.Imperial_information.ResumeLayout(false);
            this.Imperial_information.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.GroupBox Metric_Information;
        private System.Windows.Forms.Label HeightLbl;
        private System.Windows.Forms.Label WeightLbl;
        private System.Windows.Forms.Label KiloLbl;
        private System.Windows.Forms.Label inchesLbl;
        private System.Windows.Forms.TextBox KiloTextBox;
        private System.Windows.Forms.TextBox InchesTextBox;
        private System.Windows.Forms.Label BMI_ResultLbl;
        private System.Windows.Forms.RadioButton ImperialButton;
        private System.Windows.Forms.RadioButton MetricButton;
        private System.Windows.Forms.GroupBox Imperial_information;
        private System.Windows.Forms.Label LbsLbl;
        private System.Windows.Forms.Label cmLbl;
        private System.Windows.Forms.TextBox LblTxtBx;
        private System.Windows.Forms.TextBox CmTxtBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ResultTextBx;
    }
}

