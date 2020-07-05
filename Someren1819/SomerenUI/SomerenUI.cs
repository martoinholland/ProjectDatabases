using SomerenDAL;
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
using System.Globalization;


namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public bool IamAdmin { get; set; }
        public SomerenUI(bool Isadmin, string email)
        {
            //grabbing the login list and dao
            SomerenLogic.Login_Service loginService = new SomerenLogic.Login_Service();
            List<Login> loginList = loginService.GetLogin();
            Login_DAO login = new Login_DAO();
            bool answer = true;

            if (Isadmin == false)
            {
                MessageBox.Show("Hello user!");
                IamAdmin = false;

                foreach (SomerenModel.Login s in loginList)
                {
                    if (s.UserName == $"{email}" && s.RequestDenied == true)
                    {
                        MessageBox.Show("An admin has denied your admin request");
                        answer = false;
                        login.AnswerRequest(answer, $"{s.UserName}");
                    }
                }

                DialogResult dialogResult = MessageBox.Show("Would you like to request an admin to change your status to an admin?", "Admin Request", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (SomerenModel.Login s in loginList)
                    {
                        if ($"{email}" == s.UserName)
                        {
                            login.RequestAdmin($"{email}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Hello admin!");
                IamAdmin = true;

                foreach (SomerenModel.Login s in loginList)
                {
                    if (s.AdminRequest == true)
                    {
                        DialogResult dialogResult = MessageBox.Show($"User: {s.UserName} requests to become an admin", "Admin Requests", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            login.PromoteAccount($"{s.UserName}");
                            answer = false;
                            login.AnswerRequest(answer, $"{s.UserName}");
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            answer = true;
                            login.AnswerRequest(answer, $"{s.UserName}");
                        }
                    }
                }
            }
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pdbe33DataSet.Drinks' table. You can move, or remove it, as needed.
            this.drinksTableAdapter.Fill(this.pdbe33DataSet.Drinks);
            showPanel("Dashboard");
        }

        private void showPanel(string panelName)
        {
            if (IamAdmin == false)
            {
                btnAdd.Hide();
                btnChange.Hide();
                btnRemove.Hide();
                btnSubmit.Hide();
                btn_EditDrinks.Hide();
                btn_saveDrink.Hide();
                btn_Add.Hide();
                btn_Remove.Hide();
            }
            DisplayActivityID();
            //normally hidden stuff:
            //filter panel
            pnl_Filter.Hide();

            if (panelName == "Dashboard")
            {
                // hide all other panels
                pnl_Students.Hide();
                btn_Filter.Hide();
                btn_RemoveFilter.Hide();
                pnl_Activity.Hide();

                // show dashboard
                pnl_Dashboard.Show();
                img_Dashboard.Show();
            }
            else if (panelName == "Activities")
            {
                
                //
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                //pnl_Students.Hide();
                pnl_EditDrink.Hide();
                pnl_Drinks.Hide();
                panel1Activity.Hide();
                panel3Activity.Hide();
                //
                pnl_Activity.Show();
                pnl_Students.Show();

                //
                DisplayListViewActivity();
            }
            else if(panelName == "Students")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                btn_Filter.Hide();
                btn_RemoveFilter.Hide();
                pnl_Drinks.Hide();
                pnl_EditDrink.Hide();
                pnl_Activity.Hide();

                // show students

                lbl_Students.Text = "Students";
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
                listViewStudents.Columns[1].Width = 125;
                listViewStudents.Columns.Add("Last Name");
                listViewStudents.Columns[2].Width = 125;

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
                //hiding the dashboard
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                btn_Filter.Hide();
                pnl_Drinks.Hide();
                pnl_EditDrink.Hide();
                btn_RemoveFilter.Hide();
                pnl_Activity.Hide();

                //show teachers
                lbl_Students.Text = "Teachers";
                pnl_Students.Show();

                // fill the Teachers listview within the Teachers panel with a list of lecturers
                SomerenLogic.Lecturers_Service lecService = new SomerenLogic.Lecturers_Service();
                List<Teacher> lecturersList = lecService.GetLecturers();

                // clear the listview before filling it again
                listViewStudents.Clear();

                //Adding columns
                listViewStudents.View = View.Details;
                listViewStudents.Columns.Add("Teacher Number");
                listViewStudents.Columns[0].Width = 100;
                listViewStudents.Columns.Add("Name");
                listViewStudents.Columns[1].Width = 125;

                foreach (SomerenModel.Teacher s in lecturersList)
                {
                    ListViewItem li = new ListViewItem(s.Number.ToString());
                    li.SubItems.Add(s.Name.ToString());
                    listViewStudents.Items.Add(li);
                }
            }
            else if (panelName == "Rooms")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                btn_Filter.Hide();
                pnl_Drinks.Hide();
                pnl_EditDrink.Hide();
                btn_RemoveFilter.Hide();
                pnl_Activity.Hide();

                //show rooms
                pnl_Students.Show();
                lbl_Students.Text = "Rooms     ";


                //filling the roomList a list of rooms
                SomerenLogic.Room_Service roomService = new SomerenLogic.Room_Service();
                List<Room> roomList = roomService.GetRooms();

                //clearing listView
                listViewStudents.Clear();

                //add columns and allign
                listViewStudents.Columns.Add("Room Number");
                listViewStudents.Columns[0].Width = 100;
                listViewStudents.Columns.Add("Type");
                listViewStudents.Columns[1].Width = 125;
                listViewStudents.Columns.Add("Capacity");
                listViewStudents.Columns[2].Width = 125;

                foreach (SomerenModel.Room s in roomList)
                {

                    ListViewItem li = new ListViewItem(s.Number.ToString());
                    if (s.Type == true)
                    {
                        li.SubItems.Add("teacher");
                    }
                    else
                    {
                        li.SubItems.Add("student");
                    }
                    
                    li.SubItems.Add(s.Capacity.ToString());
                    listViewStudents.Items.Add(li);

                    //li.SubItems.Add(s.Type.ToString());
                    //saved for potential later use
                }
            }
            else if (panelName == "Drinks")
            {
                //hiding the dashboard and other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Students.Hide();
                pnl_EditDrink.Hide();
                btn_Filter.Hide();
                btn_RemoveFilter.Hide();
                pnl_Activity.Hide();

                //show drinks
                lbl_Drinks.Text = "Drinks";
                pnl_Drinks.Show();
                // clear the listview before filling it again
                listViewDrinks.Clear();

                // fill the drinks listview within the drinks panel with a list of drinks
                SomerenLogic.Drinks_Service drinkService = new SomerenLogic.Drinks_Service();
                List<Drinks> drinksList = drinkService.GetDrinks();

                //Adding columns
                listViewDrinks.View = View.Details;
                listViewDrinks.Columns.Add("Name");
                listViewDrinks.Columns[0].Width = 100;
                listViewDrinks.Columns.Add("Stock");
                listViewDrinks.Columns[1].Width = 100;
                listViewDrinks.Columns.Add("Price");
                listViewDrinks.Columns[2].Width = 100;

                foreach (SomerenModel.Drinks d in drinksList)
                {
                    ListViewItem li = new ListViewItem(d.DrinkName.ToString());
                    if (d.Stock >= 10)
                    {
                        li.SubItems.Add("✔️" + "  (" + d.Stock.ToString() + ")");
                    }
                    else
                    {
                        li.SubItems.Add("⚠️" + "  (" + d.Stock.ToString() + ")");
                    }
                    li.SubItems.Add(d.Price.ToString());
                    listViewDrinks.Items.Add(li);
                }

            }
            else if (panelName == "Edit drinks")
            {
                //hiding the dashboard
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Drinks.Hide();
                pnl_Students.Hide();
                btn_Filter.Hide();
                btn_RemoveFilter.Hide();
                pnl_Activity.Hide();

                //show datagridview drinks
                pnl_EditDrink.Show();
            }
            else if (panelName == "RevenueReport")
            {
                //hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Activity.Hide();

                //show report
                pnl_Students.Show();
                btn_Filter.Show();
                btn_RemoveFilter.Show();
                lbl_Students.Text = "Revenue Report";

                //clearing listView
                listViewStudents.Clear();

                //prep
                listViewStudents.GridLines = false;

                //calling the list with drinks
                SomerenLogic.Drinks_Service drinkService = new SomerenLogic.Drinks_Service();
                List<Drinks> drinksList = drinkService.GetDrinks();

                //calling the list of students from the register
                SomerenLogic.SomerenDAL CashService = new SomerenLogic.SomerenDAL();
                List<Register> registerList = CashService.GetRegister();

                //calculating sales and turnover
                int Sales = 0, Customers = 0;
                decimal Turnover = 0m;

                foreach (SomerenModel.Drinks s in drinksList)
                {
                    Sales += s.DrinkSold;
                    Turnover += (s.Price * s.DrinkSold);
                }

                //calculating the amount of customers
                List<string> TempCustomerList = new List<string>();
                foreach (Register s in registerList)
                {
                    if (!TempCustomerList.Contains(s.StudentName))
                    {
                        TempCustomerList.Add(s.StudentName);
                        Customers++;
                    }
                }

                //displaying report
                listViewStudents.Columns.Add("Sales");
                listViewStudents.Columns[0].Width = 100;
                listViewStudents.Columns.Add("Turnover");
                listViewStudents.Columns[1].Width = 100;
                listViewStudents.Columns.Add("Num of Customers");
                listViewStudents.Columns[2].Width = 100;

                ListViewItem li = new ListViewItem(Sales.ToString());
                li.SubItems.Add("€ " + Turnover.ToString("0.00"));
                li.SubItems.Add(Customers.ToString());
                listViewStudents.Items.Add(li);
            }
            else if (panelName == "Supervisors")
            {
                //hiding the dashboard
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Drinks.Hide();
                pnl_EditDrink.Hide();
                pnl_Students.Hide();
                btn_Filter.Hide();
                btn_RemoveFilter.Hide();
                comboBoxAdd.Items.Clear();
                comboBoxDelete.Items.Clear();

                //show supervisor panel
                pnl_Supervisor.Show();

                // clear the listview before filling it again
                listViewSupervisor.Clear();

                // fill the drinks listview within the supervisor panel with a list of supervisor
                SomerenLogic.Supervisor_Service supervisor_Service = new SomerenLogic.Supervisor_Service();
                List<Supervisor> supervisors = supervisor_Service.GetSupervisors();

                //Adding columns
                listViewSupervisor.View = View.Details;
                listViewSupervisor.Columns.Add("Name");
                listViewSupervisor.Columns[0].Width = 100;
                listViewSupervisor.Columns.Add("ID");
                listViewSupervisor.Columns[1].Width = 100;

                foreach (SomerenModel.Supervisor s in supervisors)
                {
                    ListViewItem li = new ListViewItem(s.name);
                    li.SubItems.Add(s.LecturerID.ToString());
                    listViewSupervisor.Items.Add(li);
                }

                DisplayTeachersComboBox();
                DisplaySupervisorsComboBox();
            }
            else if (panelName == "WeeklyTimetable")
            {
                //hiding all the other stuff
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Drinks.Hide();
                pnl_EditDrink.Hide();
                pnl_Students.Hide();
                btn_Filter.Hide();
                btn_RemoveFilter.Hide();

                //show report
                pnl_Students.Show();
                lbl_Students.Text = "Weekly Timetable";

                //clearing listView
                listViewStudents.Clear();

                //calling the timetable list
                SomerenLogic.Timetable_Service timetable_Service = new SomerenLogic.Timetable_Service();
                List<Timetable> timetables = timetable_Service.GetTimetables();

                //displaying timetable
                listViewStudents.Columns.Add("Date");
                listViewStudents.Columns[0].Width = 100;
                listViewStudents.Columns.Add("Day of Week");
                listViewStudents.Columns[1].Width = 100;
                listViewStudents.Columns.Add("Activities");
                listViewStudents.Columns[2].Width = 100;
                listViewStudents.Columns.Add("Supervisors");
                listViewStudents.Columns[3].Width = 100;

                int counter = 0;

                foreach (SomerenModel.Timetable s in timetables)
                {
                    ListViewItem li = new ListViewItem(s.Date.ToShortDateString().ToString());
                    li.SubItems.Add(s.Date.DayOfWeek.ToString());
                    li.SubItems.Add(s.Activity);
                    li.SubItems.Add(s.Supervisor);
                    listViewStudents.Items.Add(li);
                    counter++;
                    if (counter == 7)
                    {
                        return;
                    }
                }
            }

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
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

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Teachers");
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Rooms");
        }

        private void chashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormCashRegister form = new FormCashRegister();
            form.ShowDialog();
        }

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Drinks");
        }

        private void revenueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("RevenueReport");
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            pnl_Filter.Show();
            lbl_ErrorMessage.Hide();
            listViewStudents.Width = 464;
        }

        /*
         IMPORTANT IMPORTANT IMPORTANT
         
         For my variant I'm supposed to create a filer which would filter out the dates
         HOWEVER, in the previous variants there was no mention of anything related to DateTime
         Which means I have no method of using data from the database to create the filter
         I assume this will come later because this is just a confusing assignment
         So I'll code with theoritical data in order to finish my variant

         I'll be coding in theory that the Model Register has a
         -string StudentName
         -Drinks DrinkName
         -DateTime OrderDate

         Down below I've turned a section into a comment so that the application is useable

         IMPORTANT IMPORTANT IMPORTANT
         */
        //FILTER CALCULATIONS
        private void btn_FilterConfirm_Click(object sender, EventArgs e)
        {
            //filter filter
            DateTime dtpStart = DateTime.ParseExact(dtp_StartDate.Value.ToString("dd-MM-yyyy"), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime dtpEnd = DateTime.ParseExact(dtp_EndDate.Value.ToString("dd-MM-yyyy"), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            if (DateTime.Compare(DateTime.Now, dtpEnd) < 0)
            {
                lbl_ErrorMessage.Show();
                return;
            }

            //prep
            pnl_Filter.Hide();
            listViewStudents.Width = 708;
            listViewStudents.Clear();
            listViewStudents.GridLines = false;
            int Sales = 0, Customers = 0;
            decimal Turnover = 0m;

            //calling the list of students from the register
            SomerenLogic.SomerenDAL CashService = new SomerenLogic.SomerenDAL();
            List<Register> registerList = CashService.GetRegister();

            //calculationg sales, turnover and customers
            List<string> TempCustomerList = new List<string>();

            /* This part is commented so the app is usable */
            //foreach (Register s in registerList)
            //{
            //    int filterStart = DateTime.Compare(s.OrderDate, dtpStart);
            //    int filterEnd = DateTime.Compare(s.OrderDate, dtpEnd);

            //    if (filterStart >= 0 && filterEnd <= 0)
            //    {
            //        Sales++;
            //        Turnover += s.DrinkName.Price;

            //        if (!TempCustomerList.Contains(s.StudentName))
            //        {
            //            TempCustomerList.Add(s.StudentName);
            //            Customers++;
            //        }
            //    }
            //}
            /* End Part */

            //displaying report
            listViewStudents.Columns.Add("Sales");
            listViewStudents.Columns[0].Width = 100;
            listViewStudents.Columns.Add("Turnover");
            listViewStudents.Columns[1].Width = 100;
            listViewStudents.Columns.Add("Num of Customers");
            listViewStudents.Columns[2].Width = 100;

            ListViewItem li = new ListViewItem(Sales.ToString());
            li.SubItems.Add("€ " + Turnover.ToString("0.00"));
            li.SubItems.Add(Customers.ToString());
            listViewStudents.Items.Add(li);
        }

        private void btn_RemoveFilter_Click(object sender, EventArgs e)
        {
            listViewStudents.Width = 708;
            showPanel("RevenueReport");
        }

        private void btn_saveDrink_Click(object sender, EventArgs e)
        {
            //update the databse through the datagridview db adapter
            this.drinksTableAdapter.Update(pdbe33DataSet);

            showPanel("Drinks");
        }

        private void btn_EditDrinks_Click(object sender, EventArgs e)
        {
            showPanel("Edit drinks");
        }

        //updating the database
        private void DataGridViewDirectDBUpdate_Load(object sender, EventArgs e)
        {
            this.drinksTableAdapter.Fill(this.pdbe33DataSet.Drinks);
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Activities");
        }

        private void asdadwToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panel1Activity.Show();
            comboBoxChange.Hide();
            txtActivityID.Show();
            panel3Activity.Hide();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            panel1Activity.Show();
            txtActivityID.Hide();
            comboBoxChange.Show();
            panel3Activity.Hide();            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {            
            panel1Activity.Hide();
            panel3Activity.Show();
        }
        void DisplayActivityID()
        {
            SomerenLogic.Activity_Service activityService = new SomerenLogic.Activity_Service();
            List<Activity> activityList = activityService.GetActivities();
            
            foreach (SomerenModel.Activity item in activityList)
            {
                if (item != null)
                {
                    comboBoxChange.Items.Add(item.ActivityID);
                    comboBoxRemove.Items.Add(item.ActivityID);
                }
            }
        }
        void DisplayListViewActivity()
        {
            SomerenLogic.Activity_Service activityService = new SomerenLogic.Activity_Service();
            List<Activity> activityList = activityService.GetActivities();
            
            listViewActivity.Clear();
            //add columns and allign
            listViewActivity.View = View.Details;
            listViewActivity.Columns.Add("Activity ID");
            listViewActivity.Columns[0].Width = 80;
            listViewActivity.Columns.Add("Description");
            listViewActivity.Columns[1].Width = 80;
            listViewActivity.Columns.Add("Number of students");
            listViewActivity.Columns[2].Width = 80;
            listViewActivity.Columns.Add("Number of supervisors");
            listViewActivity.Columns[3].Width = 80;

            foreach (SomerenModel.Activity s in activityList)
            {
                ListViewItem li = new ListViewItem(s.ActivityID.ToString());
                //li.SubItems.Add(s.ActivityID.ToString());
                li.SubItems.Add(s.Description);
                li.SubItems.Add(s.NumberOfStudents.ToString());
                li.SubItems.Add(s.NumberOfSupervisors.ToString());
                listViewActivity.Items.Add(li);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Activity_DAO activity = new Activity_DAO();
            listViewActivity.Clear();
            if (txtActivityID.Text == "" && comboBoxChange.Text == "")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure that you wish to remove this activity?", "Remove validation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    activity.ActivityRemover(int.Parse(comboBoxRemove.Text));
                    comboBoxChange.Items.Clear();
                    comboBoxRemove.Items.Clear();
                    DisplayActivityID();
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }               
                comboBoxRemove.ResetText();
            }
            else if (txtActivityID.Text != "" && comboBoxChange.Text == "")
            {
                SomerenLogic.Activity_Service activityService = new SomerenLogic.Activity_Service();
                List<Activity> activityList = activityService.GetActivities();
                bool check = false;
                foreach (var s in activityList)
                {
                    if (s.ActivityID == int.Parse(txtActivityID.Text))
                    {
                        MessageBox.Show("You can't add an activity with the same name");
                        break;
                    }
                    else
                    {
                        check = true;
                    }
                }
                if (check == true)
                {
                    activity.ActivityAdder(int.Parse(txtActivityID.Text), txtDescriptionAdd.Text, int.Parse(txtNOfStudentsAdd.Text), int.Parse(txtNOfSupervisorsAdd.Text));
                    txtActivityID.ResetText();
                    txtDescriptionAdd.ResetText();
                    txtNOfStudentsAdd.ResetText();
                    txtNOfSupervisorsAdd.ResetText();
                    comboBoxChange.Items.Clear();
                    comboBoxRemove.Items.Clear();
                    DisplayActivityID();
                }
                else if (check == false)
                {
                    txtActivityID.ResetText();
                    txtDescriptionAdd.ResetText();
                    txtNOfStudentsAdd.ResetText();
                    txtNOfSupervisorsAdd.ResetText();
                }
                              
            }
            else if (comboBoxChange.Text != "") 
            {
                activity.ActivityChanger(int.Parse(comboBoxChange.Text), txtDescriptionAdd.Text, int.Parse(txtNOfStudentsAdd.Text),int.Parse(txtNOfSupervisorsAdd.Text));
                comboBoxChange.ResetText();
                txtDescriptionAdd.ResetText();
                txtNOfStudentsAdd.ResetText();
                txtNOfSupervisorsAdd.ResetText();
            }
            DisplayListViewActivity();          
        }

        private void supervisorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Supervisors");
        }

        void DisplayTeachersComboBox()
        {
            SomerenLogic.Lecturers_Service lecturers = new SomerenLogic.Lecturers_Service();
            List<Teacher> lecturerList = lecturers.GetLecturers();
            
            foreach (SomerenModel.Teacher item in lecturerList)
            {  
                if (item != null)
                {
                    comboBoxAdd.Items.Add(item.Number);
                }
            }
        }

        void DisplaySupervisorsComboBox()
        {
            SomerenLogic.Supervisor_Service supervisor = new SomerenLogic.Supervisor_Service();
            List<Supervisor> supervisors = supervisor.GetSupervisors();

            foreach (SomerenModel.Supervisor s in supervisors)
            {
                if (supervisor != null)
                {
                    comboBoxDelete.Items.Add(s.LecturerID);
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            SomerenDAL.Supervisor_DAO supervisor = new SomerenDAL.Supervisor_DAO();
            supervisor.SupervisorAdd(comboBoxAdd.Text);
            showPanel("Supervisors");
            comboBoxRemove.ResetText();
            comboBoxAdd.ResetText();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to remove this supervisor?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SomerenDAL.Supervisor_DAO supervisor = new SomerenDAL.Supervisor_DAO();
                supervisor.SupervisorRemove(comboBoxDelete.Text);
                showPanel("Supervisors");
            }
            else
            {
                return;
            }

            comboBoxAdd.ResetText();
            comboBoxRemove.ResetText();
        }

        private void timetableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("WeeklyTimetable");
        }
    }
}
