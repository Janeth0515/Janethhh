using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRectangleArea_Click(object sender, EventArgs e)
        {
              try
            {
                double length = double.Parse(txtLength.Text);
                double width = double.Parse(txtWidth.Text);
                double area = length * width;
                string result = ($"Rectangle Area: {area} square units");

                lstResults.Items.Add(result);
                txtRecentResult.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input for rectangle: " + ex.Message);
            }
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
              try
            {
                double radius = double.Parse(txtRadius.Text);
                double area = Math.PI * radius * radius;
                string result = ($"Circle Area: {area:F2} square units");

                lstResults.Items.Add(result);
                txtRecentResult.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input for circle: " + ex.Message);
            }
        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
                try
            {
                double @base = double.Parse(txtBase.Text);
                double height = double.Parse(txtHeight.Text);
                double area = 0.5 * @base * height;
                string result = ($"Triangle Area: {area} square units");

                lstResults.Items.Add(result);
                txtRecentResult.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input for triangle: " + ex.Message);
            }
        }

        private void Length(object sender, EventArgs e)
        {

        }

        private void Heigth(object sender, EventArgs e)
        {

        }

        private void Base(object sender, EventArgs e)
        {

        }

        private void lstResultArea_Click(object sender, EventArgs e)
        {

        }

        private void txtWidth(object sender, EventArgs e)
        {
        
        }

        private void txtLength(object sender, EventArgs e)
        {
        
        }

        private void txtRecentResult(object sender, EventArgs e)
        {
        
        }

        private void txtRadius(object sender, EventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
    }
}
