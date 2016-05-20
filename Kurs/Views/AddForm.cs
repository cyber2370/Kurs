using System;
using System.Windows.Forms;
using Kurs.Classes;

namespace Kurs.Views
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (!CheckFields())
            {
                MessageBox.Show(@"Fill all fields, please!");
                return;
            }

            PrisonerCollection.AddPrisoner(new Prisoner()
            {
                FirstName = firstNameTB.Text,
                SecondName = secondNameTB.Text,
                MiddleName = middleNameTB.Text,
                Family = haveFamilyRB.Checked,
                AdditionalInfo = additionalTB.Text,
                PrisonCell = Convert.ToInt32(cellNUD.Value),
                ImprisonmentCount = Convert.ToInt32(imprisonCountNUD.Value),
                СityOfBirth = birthCityTB.Text,
                Prison = (Prisons)Enum.Parse(typeof(Prisons), prisonCB.SelectedText, true)
            });
            MessageBox.Show(@"Success!");
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Вызывается при нажатии кнопки Reset. Обнуляет значения в редактируемых полях формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetBtn_Click(object sender, EventArgs e)
        {
            foreach (var control in Controls)
            {
                if (control is TextBox)
                    ((TextBox) control).Text = "";
                else if (control is NumericUpDown)
                    ((NumericUpDown) control).Value = 0;
                else if (control is ComboBox)
                    ((ComboBox)control).ResetText();
                else if (control is GroupBox)
                {
                    foreach (var c in ((GroupBox)control).Controls)
                    {
                        ((CheckBox) c).Checked = false;
                    }
                }
            }
        }

        private bool CheckFields()
        {
            foreach (var control in Controls)
            {
                if ((control is TextBox && ((TextBox)control).Text.Length == 0)
                    || (control is ComboBox && ((ComboBox)control).SelectedText.Length == 0))
                    return false;
                if (control is GroupBox)
                {
                    var items = ((GroupBox)control).Controls;
                    if (!(((CheckBox)items[0]).Checked || ((CheckBox)items[1]).Checked))
                        return false;
                }

            }
            return true;
        }
    }
}
