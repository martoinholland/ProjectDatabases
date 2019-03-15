using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void showPanel(string panelName)
        {

            if(panelName == "Dashboard")
            {

                // hide all other panels
                pnl_Students.Hide();

                // show dashboard
                pnl_Dashboard.Show();
                img_Dashboard.Show();
            }
            else if(panelName == "Students")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();

                // show students
                pnl_Students.Show();

                

                // fill the students listview within the students panel with a list of students
                SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
                List<Student> studentList = studService.GetStudents();

                // clear the listview before filling it again
                listViewStudents.Clear();

                //add columns and allign
                listViewStudents.Columns.Add("Student number");
                listViewStudents.Columns[0].Width = 100;
                listViewStudents.Columns.Add("First Name");
                listViewStudents.Columns[1].Width = 110;
                listViewStudents.Columns.Add("Last Name");
                listViewStudents.Columns[2].Width = 110;

                foreach (SomerenModel.Student s in studentList)
                {

                    ListViewItem li = new ListViewItem(s.Number.ToString());
                    li.SubItems.Add(s.FirstName);
                    li.SubItems.Add(s.LastName);
                    listViewStudents.Items.Add(li);
                }

            }
            else if (panelName == "Teachers")
            {
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Students.Hide();

                //Program.ShowTeachers().Show();
                //this.pnl_Students.Controls.Clear();
                lbl_Students.Text = "Teachers";
                // show students
                pnl_Students.Show();
                //this.pnl_Students.Controls.Add(Program.ShowTeachers());
                // fill the Teachers listview within the Teachers panel with a list of lecturers
                SomerenLogic.Lecturers_Service lecService = new SomerenLogic.Lecturers_Service();
                List<Teacher> lecturersList = lecService.GetLecturers();

                // clear the listview before filling it again
                listViewStudents.Clear();

                //Adding columns
                listViewStudents.View = View.Details;
                listViewStudents.Columns.Add("Name", -2, HorizontalAlignment.Center);
                listViewStudents.Columns.Add("Id", -2, HorizontalAlignment.Center);
                foreach (SomerenModel.Teacher s in lecturersList)
                {
                    ListViewItem li = new ListViewItem(s.Name);
                    li.SubItems.Add(s.Number.ToString());
                    li.SubItems.Add(s.Name.ToString());
                    listViewStudents.Items.Add(li);
                    //   listViewLecturers.Items.Add(li);
                }
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void img_Dashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e) //
        {
            showPanel("Students");
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Teachers");
        }
    }
}
