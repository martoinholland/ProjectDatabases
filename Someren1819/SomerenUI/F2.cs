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
    public partial class F2 : Form
    {
        public F2()
        {
            InitializeComponent();
            DisplayList();
        }
        void DisplayList()
        {
            SomerenLogic.SomerenDAL CashService = new SomerenLogic.SomerenDAL();
            List<Register> registerList = CashService.GetRegister();

            // clear the listview before filling it again
            //listViewCheckOut.Clear();

            //Adding columns
            listViewCheckOut.View = View.Details;
            listViewCheckOut.Columns.Add("Student Name");
            listViewCheckOut.Columns[0].Width = 100;
            listViewCheckOut.Columns.Add("Drink Name");
            listViewCheckOut.Columns[1].Width = 125;

            foreach (SomerenModel.Register s in registerList)
            {
                ListViewItem li = new ListViewItem(s.StudentName.ToString());
                //li.SubItems.Add(s.StudentName.ToString());
                li.SubItems.Add(s.DrinkName.ToString());
                listViewCheckOut.Items.Add(li);
            }
        }
        private void listViewCheckOut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F2_Load(object sender, EventArgs e)
        {

        }
    }
}
