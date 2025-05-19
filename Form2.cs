using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignemtn_Question_2_B1
{
    public partial class Form2 : Form
    {
        internal object F2;
        string filePath = "";
        public static ArrayList studentList = new ArrayList();
        public Form2()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            //show filepath
            filePath = "C:\\Users\\Monique\\OneDrive\\Desktop\\Assignments Block1Y2\\Assignemtn Question 2 B1\\ListOfStudents.txt";

            //read from file 
            StreamWriter sw = new StreamWriter(filePath, true);

            if (File.Exists(filePath))
            {
                sw.Write(txtName.Text + " ;");
                sw.Write(txtLastName.Text + " ;");
                sw.Write(txtSponName.Text + " ;");
                sw.Write(txtDOB.Text + " ;");
                sw.Write(txtJoinDate.Text + " ;");
                sw.Write(txtNationality.Text + " ;");
                sw.WriteLine();
                MessageBox.Show("Saved Successfully"); //show tht student has been saved successfully 

                txtName.Clear();
                txtLastName.Clear();
                txtSponName.Clear();
                txtDOB.Clear();
                txtJoinDate.Clear();
                txtNationality.Clear();

                sw.Close();
            }
            else
            {
                MessageBox.Show("File does not exist");
            }
  
        }

        private void button2_Click(object sender, EventArgs e) //back button
        {
            this.Hide(); //hide form1
            Form1 F1 = new Form1(); //create instance of form 2 
            F1.ShowDialog();//show fom2
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
