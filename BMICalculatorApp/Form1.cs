using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            else if ( ImperialButton.Checked == false)
            {
                Imperial_information.Visible = false;
            }
            
           
        }

        private void Information_Enter(object sender, EventArgs e)
        {

        }

        private void MetricButton_CheckedChanged(object sender, EventArgs e)
        {
            if(MetricButton.Checked == true)
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
            Imperial_information.Visible = false;
            Metric_Information.Visible = false;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            //converting textbox to int rather than string

            Int32 pounds = Convert.ToInt32(LblTxtBx.Text);
            Int32 kilo = Convert.ToInt32(KiloTextBox.Text);
            Int32 inches = Convert.ToInt32(InchesTextBox.Text);
            Int32 centemeter = Convert.ToInt32(CmTxtBx.Text);
            
            
           Int32 BMI = (pounds * 703) / (centemeter * centemeter) | (kilo) / (inches * inches);
            ResultTextBx.Text = BMI.ToString();



        }

        private void LblTxtBx_TextChanged(object sender, EventArgs e)
        {

            
            
        }

        private void ResultTextBx_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
