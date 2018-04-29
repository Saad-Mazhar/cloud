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
    public partial class Form1 : Form
    {


        string userName;
        public Form1(string un)
        {
            userName = un;
            
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            BReq req = new BReq();

            string review = textBox1.Text.ToString();



            review.Replace(" ", "%20");
               
            



            label1.Text = req.HttpGet("https://shrouded-everglades-94535.herokuapp.com/functions/addReview-review="+review+",userName="+userName+"");





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("5");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            BReq req = new BReq();

            string rating = comboBox1.GetItemText(comboBox1.SelectedItem);


            req.HttpGet("https://shrouded-everglades-94535.herokuapp.com/functions/setRating-rating="+rating+",usename="+userName+"");





        }

        private void button3_Click(object sender, EventArgs e)
        {
            BReq req = new BReq();

            string roomID = textBox2.Text.ToString();

            req.HttpGet("https://shrouded-everglades-94535.herokuapp.com/functions/bookRoom-roomid="+roomID+",uname="+userName+"");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
