using assignment_trial;
using System;
using System.Collections;

namespace Assignemtn_Question_2_B1
{
    public partial class Form1 : Form
    {
        
        string filePath = "";
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide form1
            Form2 F2 = new Form2(); //create instance of form 2 
            F2.ShowDialog();//show fom2
            this.Close();
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowStudents f3 = new ShowStudents(); //declare variable 
	        f3.ShowDialog();//shows second form 
            this.Close(); //closes first form 

            

            

            Console.ReadLine();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit?", "Exit Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
                
        }
    }
}