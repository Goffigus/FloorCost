using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloorCost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            //Comment and explain waht is going on in this section
            //If you have extra time, think of suggestions to improve the code and modify it on one of your computers
            double width = Convert.ToDouble(widthBox.Text);
            double length = Convert.ToDouble(lengthBox.Text);

            double total;
            double costPerFt;
            string material = matBox.Text;

            if(material == "Carpet")
            {
                costPerFt = 1.5;

                if(cleanCheckBox.Checked == true)
                {
                    costPerFt = costPerFt * 1.2;
                }
            }
            else
            {
                costPerFt = 2.3;
                if (cleanCheckBox.Checked == true)
                {
                    costPerFt = costPerFt * 1.1;
                }
            }

            total = costPerFt * length * width;

            totalCost.Text = total.ToString("C");

        }
    }
    
}
