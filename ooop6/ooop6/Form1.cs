using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooop6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        Pacient pacient;
        private void button1_Click(object sender, EventArgs e)
        {
            pacient = new Pacient(textBox1.Text, textBox2.Text, (double)numericUpDown1.Value, (int)numericUpDown2.Value, (double)numericUpDown3.Value);
            label6.Text = pacient.ToString();           
        }
    }
}
