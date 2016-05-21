using System;
using System.Windows.Forms;
using Kurs.Classes;
using Kurs.Classes.Model;

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
            var personalInf = new PersonalInfo()
            {
                FirstName = FirstNameTB.Text,
                SecondName = SecondNameTB.Text,
                MiddleName = MiddleNameTB.Text,
                Birthday = birthdatDTP.Value,
                FamilyStatus = (FamilyStatus)Enum.Parse(typeof(FamilyStatus), FamilyCB.Text, true),
                СityOfBirth = CityBornTB.Text
            };

            var imprisInfo = new ImprisonmentInfo()
            {
                Prison = (Prisons) Enum.Parse(typeof(Prisons), prisonCB.SelectedItem.ToString(), true),
                ImprisonmentCount = Convert.ToInt32(ImprCountNUD.Value),
                PrisonCell = Convert.ToInt32(PrisCellNUD.Value),
                JailedDate = JailedDTP.Value,
                JailingYears = Convert.ToInt32(JailingTimeNUD.Value)
            };

            var prisoner = new Prisoner()
            {
                PersonalInfo = personalInf,
                ImprisonmentInfo = imprisInfo
            };

            PrisonerCollection.AddPrisoner(prisoner);
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

            }
            return true;
        }
    }
}
