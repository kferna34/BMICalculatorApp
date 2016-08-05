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
                //MessageBox.Show(" Please make sure all fields are filled");
            }
            if (LblTxtBx.Text == "" && InTxtBx.Text == "" || CmTextBox.Text == "" && KiloTextBox.Text == "")
            {
                CmTextBox.Focus();
                CmTextBox.SelectAll();
                LblTxtBx.Focus();
                LblTxtBx.SelectAll();            
                InTxtBx.Focus();
                InTxtBx.SelectAll();
                KiloTextBox.Focus();
                KiloTextBox.SelectAll();
            }
            else if (heightI < 0 && heightM < 0 || weightI < 0 && weightM < 0)
            {
                MessageBox.Show("Please make sure all values are positive");
            }
            else if (heightI > 0 && heightM > 0 || weightI > 0 && weightM > 0)
            {
                if (ImperialButton.Checked == true)
                {
                    BMI = (weightI * 703) / (heightI * heightI);
                    ResultTextBx.Text = string.Format("{0:f1}"+BMI);
                    ResultTextBx.BackColor = Color.AntiqueWhite;
                    if (BMI < 18.5)
                    {
                        this.ResultTextBx.Text=("Underweight") ;
                        MessageBox.Show("NORMAL");

                    }
                    else if (BMI >= 18.5 && BMI <= 24.9)
                    {
                        this.ResultTextBx.Text = ("Normal");
                        MessageBox.Show("NORMAL");

                    }
                    else if (BMI >= 25 && BMI <= 29.9)
                    {
                        this.ResultTextBx.Text = ("Overweight");
                        MessageBox.Show("NORMAL");

                    }
                    else if (BMI >= 30)
                    {
                        this.ResultTextBx.Text =( "Obese");
                        MessageBox.Show("NORMAL");
                    }
                }
                try//metric
                {
                    heightI = Convert.ToDouble(InTxtBx.Text);
                    heightM = Convert.ToDouble(CmTextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show(" Please make sure all fields are filled");
                }
                if (MetricButton.Checked == true)
                {
                    BMI = weightM / ((heightM * heightM) / 10000);
                    ResultTextBx.Text =("{0:f1}"+BMI);
                    ResultTextBx.BackColor = Color.AntiqueWhite;
                    if (BMI < 18.5)
                    {
                        this.ResultTextBx.Text = ("Underweight" );
                        MessageBox.Show("NORMAL");

                    }
                    else if (BMI >= 18.5 && BMI <= 24.9)
                    {
                        this.ResultTextBx.Text = ("Normal");
                        MessageBox.Show("NORMAL");

                    }
                    else if (BMI >= 25 && BMI <= 29.9)
                    {
                        this.ResultTextBx.Text = ("Overweight");
                        MessageBox.Show("NORMAL");

                    }
                    else if (BMI >= 30)
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
