using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace name_Encapsulation.app
{
    public partial class NameUI : Form
    {
        public NameUI()
        {
            InitializeComponent();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            Person aPerson = new Person();
            aPerson.SetFirstName(firstNameTextBox.Text);
            aPerson.SetMiddleName(middleNameTextBox.Text);
            aPerson.SetLastName(lastNameTextBox.Text);

            fullNameTextBox.Text = aPerson.GetFullName();
            reverseNameTextBox.Text = aPerson.GetReverseName();
        }

       
    }
}
