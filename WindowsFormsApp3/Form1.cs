using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private Array arr;

        public Form1()
        {
            InitializeComponent();
            arr = new Array();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                arr.Add(Convert.ToDouble(maskedTextBox1.Text));
                label1.Text = arr.MidRange();
            }
            catch
            {
                Form2 showDialog = new Form2();
                showDialog.ShowDialog();
            }
        }

        private void Enter_Click()
        {
            try
            {
                arr.Add(Convert.ToDouble(maskedTextBox1.Text));
                label1.Text = arr.MidRange();
            }
            catch
            {
                Form2 showDialog = new Form2();
                showDialog.ShowDialog();
            }
        }
    }
}
