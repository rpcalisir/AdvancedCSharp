using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
