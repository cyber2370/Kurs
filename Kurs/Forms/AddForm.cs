using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs.Forms
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Classes.DataBase.addPrisoner(new Classes.Prisoner()
            {
                Name = tbName.Text,
                Surname = tbSurname.Text,
                Article = tbState.Text,
                Character = tbCharacter.Text,
                Place = tbPrison.Text,
                PrisonCell = Convert.ToInt32(nudCamera.Value),
                Relations = tbRelations.Text
            });
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbCharacter.Text = "";
            tbName.Text = "";
            tbPrison.Text = "";
            tbRelations.Text = "";
            tbState.Text = "";
            tbSurname.Text = "";
            nudCamera.Value = 1;
        }
    }
}
