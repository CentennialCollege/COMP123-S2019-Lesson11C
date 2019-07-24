using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace COMP123_S2019_Lesson11C
{
    public partial class StudentInfoForm : Form
    {
        public StudentInfoForm()
        {
            InitializeComponent();
        }

        private void StudentInfoForm_Activate(object sender, EventArgs e)
        {
            try
            {
                Debug.WriteLine("Loading Student from File");
                StreamReader inputStream = new StreamReader("Students.txt");

                Program.student.id = int.Parse(inputStream.ReadLine());
                Program.student.StudentID = inputStream.ReadLine();
                Program.student.FirstName = inputStream.ReadLine();
                Program.student.LastName = inputStream.ReadLine();
                inputStream.Close();
            }
            catch (Exception exception)
            {

                Debug.WriteLine(exception.Message);
            }



            Debug.WriteLine("Output to Labels from Student");
            IDDataLabel.Text = Program.student.id.ToString();
            StudentIDDataLabel.Text = Program.student.StudentID;
            FirstNameDataLabel.Text = Program.student.FirstName;
            LastNameDataLabel.Text = Program.student.LastName;

            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.mainForm.Show();
            this.Hide();
        }

        private void StudentInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
