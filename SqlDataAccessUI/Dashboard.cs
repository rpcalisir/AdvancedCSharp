using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SqlDataAccessUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BusinessLayer db = new BusinessLayer();
             
            people = db.GetPeopleByLastName(txtLastName.Text);
            lstBoxPeopleFound.DataSource = people;
            lstBoxPeopleFound.DisplayMember = "FullInfo";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            BusinessLayer db = new BusinessLayer();

            db.InsertPeople(txtFirstNameInsert.Text, txtLastNameInsert.Text, txtEmailAddressInsert.Text, txtPhoneNumberInsert.Text);

            txtFirstNameInsert.Text = "";
            txtLastNameInsert.Text = "";
            txtEmailAddressInsert.Text = "";
            txtPhoneNumberInsert.Text = "";
        }
    }
}
