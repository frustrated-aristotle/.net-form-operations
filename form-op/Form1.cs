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
            if(textBoxUserName.Text == "admin" && textBoxPassword.Text == "1234" && textBoxCaptchaInput.Text == textBoxCaptcha.Text)
            {
                Form2 secondForm = new Form2();
                secondForm.ShowDialog();
                this.Hide();
            }
            else
            {
                
                MessageBox.Show("Wrong Inputs!", "Info" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateCaptcha();
        }
        
        private void CreateCaptcha()
        {
            Random rnd = new Random();
            int captchaInt = rnd.Next(10000, 100000);
            textBoxCaptcha.Text = captchaInt.ToString();    
        }
    }
}
