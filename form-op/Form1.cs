using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_op
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();    
        }


        //As we can see, every form is basically a class. It's name is defined when you're creating it from Project window.
        private void button2_Click(object sender, EventArgs e)
        {
            Foram3 form3 = new Foram3();
            form3.Show();
            this.Hide();   
        }
    }
}
