using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformationWFApp
{
    public partial class personalInformationForm : Form
    {
        public static string firstName;
        public static string lastName;
        public static string fatherName;
        public static string motherName;
        public static string address;
        public personalInformationForm()
        {
            InitializeComponent();
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            firstName =firstNametextBox.Text;
            lastName =lastNametextBox.Text;
            fatherName =fatherNametextBox.Text;
            motherName =motherNametextBox.Text;
            address = addressRichTextBox.Text;
            
            firstNametextBox.Clear();
            lastNametextBox.Clear();
            fatherNametextBox.Clear();
            motherNametextBox.Clear();
            addressRichTextBox.Clear();
        }


        private void nameButton_Click(object sender, EventArgs e)
        {
            
            firstNametextBox.Text = firstName;
            lastNametextBox.Text = lastName;

            fatherNametextBox.Clear();
            motherNametextBox.Clear();
            addressRichTextBox.Clear();
        }

        private void parentsNamebutton_Click(object sender, EventArgs e)
        {
            fatherNametextBox.Text = fatherName;
            motherNametextBox.Text = motherName;

            firstNametextBox.Clear();
            lastNametextBox.Clear();
            addressRichTextBox.Clear();

        }

        private void showAllInformationbutton_Click(object sender, EventArgs e)
        {
            firstNametextBox.Text = firstName;
            lastNametextBox.Text = lastName;
            fatherNametextBox.Text = fatherName;
            motherNametextBox.Text = motherName;
            addressRichTextBox.Text = address;
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            
            addressRichTextBox.Text = address;
            firstNametextBox.Clear();
            lastNametextBox.Clear();
            fatherNametextBox.Clear();
            motherNametextBox.Clear();
        }

        private void personalInformationForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
