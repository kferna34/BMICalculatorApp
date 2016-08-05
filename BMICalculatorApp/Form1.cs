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
            //calculation if the user choses imperial
            if (ImperialButton.Checked == true)
            {
                Imperial_information.Visible = true;
                double weightI = Convert.ToDouble(LblTxtBx.Text);
                double heightI = Convert.ToDouble(InTxtBx.Text);

                double BMI_Imperial = (weightI * 703) / (heightI * heightI);

                ResultTextBx.Text = ("" + BMI_Imperial);
                ResultTextBx.BackColor = Color.Ivory;
                ValueTextBox.Visible = true;
                if (BMI_Imperial < 18.5)
                {
                    ResultTextBx.BackColor = Color.Blue;
                    ValueTextBox.BackColor = Color.Blue;
                    this.ResultTextBx.Text = ("Underweight");
                    this.ValueTextBox.Text = Convert.ToString(BMI_Imperial);
                }
                else if (BMI_Imperial >= 18.5 && BMI_Imperial <= 24.9)
                {
                    ResultTextBx.BackColor = Color.Green;
                    ValueTextBox.BackColor = Color.Green;
                    this.ResultTextBx.Text = ("Normal");
                    this.ValueTextBox.Text = Convert.ToString(BMI_Imperial);
                }
                else if (BMI_Imperial >= 25 && BMI_Imperial <= 29.9)
                {
                    ResultTextBx.BackColor = Color.Yellow;
                    ValueTextBox.BackColor = Color.Yellow;
                    this.ResultTextBx.Text = ("Overweight");
                    this.ValueTextBox.Text = Convert.ToString(BMI_Imperial);
                }
                else if (BMI_Imperial >= 30)
                {
                    ResultTextBx.BackColor = Color.Red;
                    ValueTextBox.BackColor = Color.Red;
                    this.ResultTextBx.Text = ("Obese");
                    this.ValueTextBox.Text = Convert.ToString(BMI_Imperial);
                }
            }
            //calculations if the user choses metric
            if (MetricButton.Checked == true)
            {
                Metric_Information.Visible = true;
                double weightM = Convert.ToDouble(KiloTextBox.Text);
                double heightM = Convert.ToDouble(CmTextBox.Text);
                double BMI_Metric = weightM / ((heightM * heightM) / 10000);
                ValueTextBox.Visible = true;
                ResultTextBx.Text = Convert.ToString(BMI_Metric);
                ResultTextBx.BackColor = Color.Ivory;

                if (BMI_Metric < 18.5)
                {  ResultTextBx.BackColor = Color.Blue;
                    ValueTextBox.BackColor = Color.Blue;
                    this.ResultTextBx.Text = ("Underweight");           
                    this.ValueTextBox.Text = Convert.ToString(BMI_Metric);
                }
                else if (BMI_Metric >= 18.5 && BMI_Metric <= 24.9)
                {
                    ResultTextBx.BackColor = Color.Green;
                    ValueTextBox.BackColor = Color.Green;
                    this.ResultTextBx.Text = ("Normal");
                    
                    this.ValueTextBox.Text = Convert.ToString(BMI_Metric);

                }
                else if (BMI_Metric >= 25 && BMI_Metric <= 29.9)
                {
                    ResultTextBx.BackColor = Color.Yellow;
                    ValueTextBox.BackColor = Color.Yellow;
                    this.ResultTextBx.Text = ("Overweight");
                    this.ValueTextBox.Text = Convert.ToString(BMI_Metric);

                }
                else if (BMI_Metric >= 30)
                {
                    ResultTextBx.BackColor = Color.Red;
                    ValueTextBox.BackColor = Color.Red;
                    this.ResultTextBx.Text = ("Obese");
                    this.ValueTextBox.Text = Convert.ToString(BMI_Metric);


                }
            }
        }
        private void ResultTextBx_TextChanged(object sender, EventArgs e)
        {


        }

        private void LblTxtBx_TextChanged(object sender, KeyPressEventArgs e)
        {
            Convert.ToDouble(Console.ReadLine());
        }

        private void imp_info(object sender, KeyPressEventArgs e)
        {
            Convert.ToDouble(Console.ReadLine());
        }

        private void InTxtBx_TextChanged(object sender, EventArgs e)
        {
            Convert.ToDouble(Console.ReadLine());
        }
    }
}
