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
    public partial class PrisonerForm : Form
    {
        private Classes.Prisoner pris;
        public PrisonerForm()
        {
            InitializeComponent();
        }

        public void fillForm(Classes.Prisoner pris)
        {
            this.pris = pris;
            lblArticle.Text = pris.Article;
            lblCharacter.Text = pris.Character;
            lblName.Text = pris.Name;
            lblPrison.Text = pris.Prison;
            lblPrisonCell.Text = "" + pris.PrisonCell;
            lblRelations.Text = pris.Relations;
            lblSurname.Text = pris.Surname;
        }
    }
}
