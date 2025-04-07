using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Fraction_Calculator_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void initGui() {
            string fractionTop1 = txt1.Text;
            string fractionBottom1 = txt2.Text;

            // result fraction top
            //string resultTop = string.Empty;
            //string resultBottom = string.Empty;
            //info += txtName.Text + Environment.NewLine;
            //info += program + Environment.NewLine;
            //info += "Course" + Environment.NewLine;
            //foreach (var item in lstCourses.SelectedItems)
            //{
            //    info += $"{item.ToString()} {Environment.NewLine}";
            //}

            //info += "Residancy" + Environment.NewLine;
            //string selectedResidency = cboResigency.SelectedItem.ToString();
            //info += "Residency: " + selectedResidency + Environment.NewLine;


            MessageBox.Show(fractionTop1, fractionBottom1);

        }

        private void btn_Click(object sender, EventArgs e)
        {

            string fractionTop1 = txt1.Text;
            string fractionBottom1 = txt2.Text;

            // result fraction top
            //string resultTop = string.Empty;
            //string resultBottom = string.Empty;
            //info += txtName.Text + Environment.NewLine;
            //info += program + Environment.NewLine;
            //info += "Course" + Environment.NewLine;
            //foreach (var item in lstCourses.SelectedItems)
            //{
            //    info += $"{item.ToString()} {Environment.NewLine}";
            //}

            //info += "Residancy" + Environment.NewLine;
            //string selectedResidency = cboResigency.SelectedItem.ToString();
            //info += "Residency: " + selectedResidency + Environment.NewLine;
            

            MessageBox.Show(fractionTop1,fractionBottom1 );
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
