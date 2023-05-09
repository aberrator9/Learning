using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLDataAccessTutorial_FormsFramework
{
    public partial class Dashboard : Form
    {
        List <Person> people = new List <Person>();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.GetPeople(lastNameText.Text);
        }
    }
}
