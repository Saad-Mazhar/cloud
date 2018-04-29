using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class RegisterUser : Form
    {

        Login loginForm;

        public RegisterUser(Login l)
        {
            loginForm = l;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BReq req = new BReq();


            string userName = textBox1.Text.ToString();
            string password = textBox2.Text.ToString();
            string gender = textBox3.Text.ToString();
            string age = textBox4.Text.ToString();




            req.HttpGet("https://shrouded-everglades-94535.herokuapp.com/functions/registerUser-uN="+userName+",pass="+password+",gend="+gender+",age="+age+"");


            loginForm.Show();
            this.Close();


        }
    }
}
