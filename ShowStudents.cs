using Assignemtn_Question_2_B1;
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
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;

namespace assignment_trial
{
    public partial class ShowStudents : Form
    {
        string filePath = ""; //create global 'filepath' var name 
        ArrayList studentList = new ArrayList();  // different pieces of a student
        int counter = 0; //create a counter to keep track of position in array

        StreamReader reader;

        public ShowStudents()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e) //prev button
        {
            try
            {
                counter--; //decrease counter everytime prev button is pressed
                if (counter > -1) // display student record at position if counter is bigger than -1
                {
                
                    ArrayList studentRecord = studentList.GetRange(counter, 1);   // get current student from arraylist

                    foreach (string[] field in studentRecord) //for each row in array
                    {
                        
                        txtName.Text = field[0].ToString();
                        txtLastName.Text = field[1].ToString();
                        txtSponName.Text = field[2].ToString();
                        txtDOB.Text = field[3].ToString();
                        txtJDate.Text = field[4].ToString();
                        txtNat.Text = field[5].ToString();
                    }
                }
                else //show we have reached last record 
                {
                    MessageBox.Show("There are no more student records ");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide form1
            Form1 F1 = new Form1(); //create instance of form 2 
            F1.ShowDialog();//show fom2
            this.Close();
        }

        private void ShowStudents_Load(object sender, EventArgs e)
        {
            //store entire file in an array 
            filePath = "C:\\Users\\Monique\\OneDrive\\Desktop\\Assignments Block1Y2\\Assignemtn Question 2 B1\\ListOfStudents.txt";

            foreach (string line in File.ReadLines(filePath))
            {
                studentList.Add(line.Split(";")); //split student info with ;
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnNext_Click(object sender, EventArgs e)
        {


           try
           {
                counter++;
                if (counter < studentList.Count ) // no more records 
                {
                   
                    ArrayList studentRecord = studentList.GetRange(counter, 1);   // get current student from arraylist

                    foreach (string[] field in studentRecord) //for each row in array
                    {

                        txtName.Text = field[0].ToString(); //fill text boxes with current student info
                        txtLastName.Text = field[1].ToString();
                        txtSponName.Text = field[2].ToString();
                        txtDOB.Text = field[3].ToString();
                        txtJDate.Text = field[4].ToString();
                        txtNat.Text = field[5].ToString();
                        

                    }
                    
                }
                else 
                {
         
                    MessageBox.Show("There are no more student records"); //reach end of list 

                }

            }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message); //give exception error 
           }

        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete?", "Delete Student Record", MessageBoxButtons.YesNo) == DialogResult.Yes) //ask if they are sure that they want to delete the record 
            {

                if (counter >= 0 && counter < studentList.Count)
                {
                    var studentToRemove = studentList[counter];
                    studentList.RemoveAt(counter); // Remove student at current position

                    txtName.Text = ""; // Clear student text boxes at selected student 
                    txtLastName.Text = "";
                    txtDOB.Text = "";
                    txtJDate.Text = "";
                    txtSponName.Text = "";
                    txtNat.Text = "";
                    
                }
            }
        }
    }
}
