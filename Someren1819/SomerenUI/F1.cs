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
using SomerenLogic;
using SomerenDAL;

namespace SomerenUI
{
    public partial class FormCashRegister : Form
    {
        string studentUI;
        string drinkUI;
        public FormCashRegister()
        {            
            InitializeComponent();
            DisplayStudents();
            DisplayDrinks();
        }
        void DisplayStudents()
        {
            SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
            List<Student> studentList = studService.GetStudents();

            foreach (SomerenModel.Student item in studentList)
            {
                if (item != null)
                {
                    comboBoxCashRegister.Items.Add(item.FirstName);
                }
            }
        }
        void DisplayDrinks()
        {
            SomerenLogic.Drinks_Service drinkService = new SomerenLogic.Drinks_Service();
            List<Drinks> drinksList = drinkService.GetDrinks();

            foreach (SomerenModel.Drinks item in drinksList)
            {
                if (item != null)
                {
                    comboBoxDrinks.Items.Add(item.DrinkName);
                }                
            }
        }
        private void comboBoxCashRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            //comboBoxCashRegister.Items.Add();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CashRegister_DAO cash = new CashRegister_DAO();
            if (comboBoxCashRegister != null && comboBoxDrinks != null)
            {
                cash.CashAdder(comboBoxCashRegister.Text, comboBoxDrinks.Text);                
            }
            comboBoxCashRegister.ResetText();
            comboBoxDrinks.ResetText();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheckOutList_Click(object sender, EventArgs e)
        {
            F2 f2 = new F2();
            f2.ShowDialog();
        }

        private void comboBoxDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCashRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
