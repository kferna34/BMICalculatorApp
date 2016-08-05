using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Krytia Fernandez
 * Date Lst Modified  = August 04 2016
 * version: 0.0.0.6
 */
namespace BMICalculatorApp
{
    public partial class BMI_Form : Form
    {
        public BMI_Form()
        {
            InitializeComponent();
        }

        private void INFOHOLDER_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ImperialButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ImperialButton.Checked == true)
            {
                Imperial_information.Visible = true;
            }
            else if (ImperialButton.Checked == false)
            {
                Imperial_information.Visible = false;
            }


        }

        private void Information_Enter(object sender, EventArgs e)
        {

        }

        private void MetricButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MetricButton.Checked == true)
            {
                Metric_Information.Visible = true;
            }
            else if (MetricButton.Checked == false)
            {
                Metric_Information.Visible = false;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BMI_Form_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            LblTxtBx.Text = "";
            KiloLbl.Text = "";
            CmTextBox.Text = "";
            InTxtBx.Text = "";
            ResultTextBx.BackColor = Color.Beige;

            //Visibility of the group box
            Imperial_information.Visible = false;
            Metric_Information.Visible = false;
            ResultTextBx.Visible = false;
            BMI_ResultLbl.Visible = false;
            MetricButton.Checked = false;
            ImperialButton.Checked = false;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            //visibility 
            BMI_ResultLbl.Visible = true;
            ResultTextBx.Visible = true;

            //imperial inches, pounds
            //metric  kilos, cm          
            double weightI = Convert.ToDouble(LblTxtBx.Text);
            double weightM = Convert.ToDouble(KiloTextBox.Text);
            double heightI = Convert.ToDouble(InTxtBx.Text);
            double heightM = Convert.ToDouble(CmTextBox.Text);

            if (ImperialButton.Checked == true)
            {
                double BMI_Imperial = (weightI * 703) / (heightI * heightI);
                ResultTextBx.Text = string.Format("{0:f1}" + BMI_Imperial);
                ResultTextBx.BackColor = Color.AntiqueWhite;

                if (BMI_Imperial < 18.5)
                {
                    this.ResultTextBx.Text = ("Underweight");
                }
                else if (BMI_Imperial >= 18.5 && BMI_Imperial <= 24.9)
                {
                    this.ResultTextBx.Text = ("Normal");
                }
                else if (BMI_Imperial >= 25 && BMI_Imperial <= 29.9)
                {
                    this.ResultTextBx.Text = ("Overweight");
                }
                else if (BMI_Imperial >= 30)
                {
                    this.ResultTextBx.Text = ("Obese");
                }
                if (MetricButton.Checked == true)
                {
                    double BMI_Metric = weightM / ((heightM * heightM) / 10000);
                    ResultTextBx.Text = ("{0:f1}" + BMI_Metric);
                    ResultTextBx.BackColor = Color.AntiqueWhite;

                    if (BMI_Metric < 18.5)
                    {
                        this.ResultTextBx.Text = ("Underweight");
                    }
                    else if (BMI_Metric >= 18.5 && BMI_Metric <= 24.9)
                    {
                        this.ResultTextBx.Text = ("Normal");
                    }
                    else if (BMI_Metric >= 25 && BMI_Metric <= 29.9)
                    {
                        this.ResultTextBx.Text = ("Overweight");
                    }
                    else if (BMI_Metric >= 30)
                    {
                        this.ResultTextBx.Text = ("Obese");
                        MessageBox.Show("NORMAL");
                    }
                }
            }
        }
        private void ResultTextBx_TextChanged(object sender, EventArgs e)
        {
            ResultTextBx.Text = ("{0:f1}");
            ResultTextBx.BackColor = Color.AntiqueWhite;

        }

        private void LblTxtBx_TextChanged(object sender, KeyPressEventArgs e)
        {
            char digit = e.KeyChar;
            if (!Char.IsDigit(digit) && digit != 8 && digit != 46)
            {
                e.Handled = true;
            }
        }

        private void imp_info(object sender, KeyPressEventArgs e)
        {
            char digit = e.KeyChar;
            if (!Char.IsDigit(digit) && digit != 8 && digit != 46)
            {
                e.Handled = true;
            }
        }
    }
}
