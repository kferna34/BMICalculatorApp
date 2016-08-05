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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void INFOHOLDER_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WeightLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void FeetTxtBx_TextChanged(object sender, EventArgs e)
        {
            Console.ReadLine();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void imp_info(object sender, EventArgs e)
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
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            //visibility 
            BMI_ResultLbl.Visible = true;
            ResultTextBx.Visible = true;

            double heightI = 0, heightM = 0, weightM = 0, weightI = 0, BMI;
            //imperial inches, pounds
            //metric  kilos, cm
            try //for emperial
            {
                //converting textbox to double rather than string

                weightI = Convert.ToDouble(LblTxtBx.Text);
                weightM = Convert.ToDouble(KiloTextBox.Text);
                heightI = Convert.ToDouble(InTxtBx.Text);
                heightM = Convert.ToDouble(CmTextBox.Text);

            }
            catch (Exception)
            {
                MessageBox.Show(" Please make sure all fields are filled");
            }
            if (LblTxtBx.Text == "" || CmTextBox.Text == "")
            {
                CmTextBox.Focus();
                CmTextBox.SelectAll();
                LblTxtBx.Focus();
                LblTxtBx.SelectAll();

                if (InTxtBx.Text == "" || KiloTextBox.Text == "")
                InTxtBx.Focus();
                InTxtBx.SelectAll();
                KiloTextBox.Focus();
                KiloTextBox.SelectAll();
            }
            else if (heightI < 0 && heightM < 0 || weightI < 0 && weightM < 0)
            {
                MessageBox.Show("Please make sure all values are positive");
            }
            else if (heightI < 0 && heightM < 0 || weightI < 0 && weightM < 0)
            {
                if (ImperialButton.Checked == true && Imperial_information.Visible == true)
                {
                    BMI = (weightI * 703) / (heightI * heightI);
                    ResultTextBx.Text = string.Format("{0:f1}", BMI);
                    ResultTextBx.BackColor = Color.AntiqueWhite;
                    if (BMI < 18.5)
                    {
                        ResultTextBx.Text = ("Underweight");

                    }
                    else if (BMI >= 18.5 && BMI <= 24.9)
                    {
                        ResultTextBx.Text = ("Normal");

                    }
                    else if (BMI >= 25 && BMI <= 29.9)
                    {
                        ResultTextBx.Text = ("Overweight");

                    }
                    else if (BMI >= 30)
                    {
                        ResultTextBx.Text = ("Obese");
                    }
                }
                else if (MetricButton.Checked == true && Imperial_information.Visible == true)
                {
                    BMI = weightM / ((heightM * heightM) / 10000);
                    ResultTextBx.Text = string.Format("{0:f1}", BMI);
                    ResultTextBx.BackColor = Color.AntiqueWhite;
                    if (BMI < 18.5)
                    {
                        ResultTextBx.Text = ("Underweight");

                    }
                    else if (BMI >= 18.5 && BMI <= 24.9)
                    {
                        ResultTextBx.Text = ("Normal");

                    }
                    else if (BMI >= 25 && BMI <= 29.9)
                    {
                        ResultTextBx.Text = ("Overweight");

                    }
                    else if (BMI >= 30)
                    {
                        ResultTextBx.Text = ("Obese");
                    }

                }
            }
        }
        private void LblTxtBx_TextChanged(object sender, EventArgs e)
        {



        }

        private void ResultTextBx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
