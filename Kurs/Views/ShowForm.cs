using System;
using System.Windows.Forms;
using Kurs.Classes;
using Kurs.Classes.Model;

namespace Kurs.Views
{
    public partial class ShowForm : Form
    {
        private int _id = 0;
        public ShowForm()
        {
            InitializeComponent();

        }
        public ShowForm(int id) : this()
        {
            _id = id;
        }

        private void ShowForm_Load(object sender, EventArgs e)
        {
            if (_id <= 0)
            {
                MessageBox.Show(@"Wrong ID!\nSorry...");
                Close();
                return;
            }
            //FillFields(PrisonerCollection.GetPrisoner(_id));
        }

        private void FillFields(Prisoner prisoner)
        {
            

        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deteleBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Deleted successful");
            Close();
        }
    }
}
