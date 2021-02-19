using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformationApp
{
    public partial class Form1 : Form
    {
        Person aPerson = new Person();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aPerson.firstName = firstNameTextbox.Text;
            aPerson.lastName = lastNameTextbox.Text;
            aPerson.fatherName = fatherNameTextbox.Text;
            aPerson.motherName = motherNameTextbox.Text;
            aPerson.address = addressTextbox.Text;

            MessageBox.Show(@"Your Information has been saved Successfully", "Save Information",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);

            clear();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            clear();
            firstNameTextbox.Text = aPerson.firstName;
            lastNameTextbox.Text = aPerson.lastName;
            fatherNameTextbox.Text = aPerson.fatherName;
            motherNameTextbox.Text = aPerson.motherName;
            addressTextbox.Text = aPerson.address;
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            clear();
            firstNameTextbox.Text = aPerson.firstName;
            lastNameTextbox.Text = aPerson.lastName;
        }

        private void parentNameButton_Click(object sender, EventArgs e)
        {
            clear();
            fatherNameTextbox.Text = aPerson.fatherName;
            motherNameTextbox.Text = aPerson.motherName;
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            clear();
            addressTextbox.Text = aPerson.address;
        }
        public void clear()
        {
            firstNameTextbox.Clear();
            lastNameTextbox.Clear();
            fatherNameTextbox.Clear();
            motherNameTextbox.Clear();
            addressTextbox.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
