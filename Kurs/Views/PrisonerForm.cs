using System;
using System.Linq;
using System.Windows.Forms;
using Kurs.Model;

namespace Kurs.Views
{
    /// <summary>
    ///  Класс формы заключенного. Просмотр, добавление, изменение. 
    /// </summary>
    public partial class PrisonerForm : Form
    {
        private readonly Prisoner prisoner = null;

        /// <summary>
        /// Конструктор (добавление заключенного).
        /// </summary>
        public PrisonerForm()
        {
            InitializeComponent();
            Text = @"Добавление заключенного";
            deleteBtn.Visible = writableBtn.Visible = false;
            okBtn.Visible = true;
            FamilyCB.SelectedIndex = prisonCB.SelectedIndex = 0;
        }

        /// <summary>
        /// Конструктор просмотр или изменения данных заключенного.
        /// </summary>
        /// <param name="prisoner"></param>
        /// <param name="writable"></param>
        public PrisonerForm(int prisonerId, bool writable)
        {
            InitializeComponent();
            if (prisonerId <= 0)
            {
                MessageBox.Show(@"Sorry, but ID is wrong!");
                Close();
            }
            var pris = PrisonerCollection.GetPrisonerById(prisonerId);
            if (pris == null)
            {
                MessageBox.Show(@"Ошибка! Такого заключенного не существует!");
                Close();
            }
            Text = writable 
                ? @"Изменение заключенного" 
                : "Просмотр заключенного";

            prisoner = pris;
            FillFields();
            deleteBtn.Visible = true;
            okBtn.Visible = writable;
            writableBtn.Visible = !writable;
            WritableFields(writable);
        }

        private void FillFields()
        {
            var persControls = Controls["tabControl1"].Controls[0].Controls;
            var imprisControls = Controls["tabControl1"].Controls[1].Controls;

            persControls["FirstNameTB"].Text = prisoner.PersonalInfo.FirstName;
            persControls["SecondNameTB"].Text = prisoner.PersonalInfo.SecondName;
            persControls["MiddleNameTB"].Text = prisoner.PersonalInfo.MiddleName;
            persControls["CityBornTB"].Text = prisoner.PersonalInfo.СityOfBirth;

            ((DateTimePicker)persControls["birthdayDTP"]).Value = 
                prisoner.PersonalInfo.Birthday;
            
            ((ComboBox) persControls["FamilyCB"]).SelectedIndex = 
                FormHelper.GetFamilyIndexByValue(
                                prisoner.PersonalInfo.FamilyStatus.ToString());

            ((ComboBox)imprisControls["prisonCB"]).SelectedIndex = 
                FormHelper.GetPrisonIndexByValue(
                                prisoner.ImprisonmentInfo.Prison.ToString());

            ((NumericUpDown) imprisControls["PrisCellNUD"]).Value =
                prisoner.ImprisonmentInfo.PrisonCell;

            ((NumericUpDown) imprisControls["ImprCountNUD"]).Value =
                prisoner.ImprisonmentInfo.ImprisonmentCount;

            ((NumericUpDown) imprisControls["JailingYearsNUD"]).Value =
                Convert.ToInt32(prisoner.ImprisonmentInfo.JailingMonths/12);

            ((NumericUpDown) imprisControls["JailingMonthsNUD"]).Value =
                prisoner.ImprisonmentInfo.JailingMonths%12;

            ((DateTimePicker)imprisControls["JailedDTP"]).Value = 
                prisoner.ImprisonmentInfo.JailedDate;

        }


        /// <summary>
        /// Событие Click кнопки OK. Добавляет/заменяет заключенного в коллекцию.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (!CheckFields()) return;

            var personalInf = new PersonalInfo()
            {
                FamilyStatus = FormHelper.GetFamilyValueByIndex
                                            (FamilyCB.SelectedIndex),
                FirstName = FirstNameTB.Text,
                SecondName = SecondNameTB.Text,
                MiddleName = MiddleNameTB.Text,
                Birthday = birthdayDTP.Value,
                СityOfBirth = CityBornTB.Text
            };

            var imprisInfo = new ImprisonmentInfo()
            {
                Prison = FormHelper.GetPrisonValueByIndex(prisonCB.SelectedIndex),
                ImprisonmentCount = Convert.ToInt32(ImprCountNUD.Value),
                PrisonCell = Convert.ToInt32(PrisCellNUD.Value),
                JailedDate = JailedDTP.Value,
                JailingMonths = Convert.ToInt32(JailingYearsNUD.Value*12
                                                + JailingMonthsNUD.Value)
            };

            var prisoner = new Prisoner()
            {
                Id = this.prisoner != null ? this.prisoner.Id : 0,
                PersonalInfo = personalInf,
                ImprisonmentInfo = imprisInfo
            };
            if(this.prisoner == null)
                PrisonerCollection.AddPrisoner(prisoner);
            else 
                PrisonerCollection.ReplacePrisoner(prisoner);
            Close();
        }


        /// <summary>
        /// Событие Click кнопки Cancel. Закрывает текущую форму.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// Делает поля формы (не)доступными для записи.
        /// </summary>
        /// <param name="verif"></param>
        private void WritableFields(bool verif)
        {
            WritableFieldsHelper(Controls["tabControl1"]
                                .Controls[0].Controls, verif);
            WritableFieldsHelper(Controls["tabControl1"]
                                .Controls[1].Controls, verif);
        }

        /// <summary>
        /// Вспомогательный метод для метода writableFields. 
        /// Изменяет свойство Enabled у полей на форме.
        /// </summary>
        /// <param name="control"></param>
        /// <param name="verif"></param>
        private void WritableFieldsHelper(Control.ControlCollection control,
                                            bool verif)
        {
            foreach (var c1 in control)
                if (c1 is TextBox)
                    ((TextBox)c1).Enabled = verif;
                else if (c1 is NumericUpDown)
                    ((NumericUpDown)c1).Enabled = verif;
                else if (c1 is ComboBox)
                    ((ComboBox)c1).Enabled = verif;
                else if (c1 is DateTimePicker)
                    ((DateTimePicker)c1).Enabled = verif;
        }


        /// <summary>
        /// Событие Click кнопки Удалить.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(@"Вы уверены?",
                @"Удаление заключенного", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;
            PrisonerCollection.RemovePrisoner(prisoner.Id);
            MessageBox.Show(@"Success");
            Close();
        }


        /// <summary>
        /// Событие Click кнопки Изменить. Делает поля Enabled.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void writableBtn_Click(object sender, EventArgs e)
        {
            writableBtn.Visible = false;
            okBtn.Visible = true;
            WritableFields(true);
        }

        private bool CheckFields()
        {
            if (FirstNameTB.Text == "" || SecondNameTB.Text == "" 
                || MiddleNameTB.Text == "" || CityBornTB.Text == "" 
                || birthdayDTP.Value == new DateTime(1800, 1, 1)
                || (JailingYearsNUD.Value == 0 && JailingMonthsNUD.Value == 0) 
                || PrisCellNUD.Value == 0)
            {
                MessageBox.Show("Заполните все поля!", 
                                "Ошибка добавления заключенного.");
                return false;
            }
            if(birthdayDTP.Value > JailedDTP.Value)
            { 
                MessageBox.Show("Дата рождения не может быть " 
                    + "раньше даты заключения!",
                    "Ошибка добавления заключенного.");
                return false;
            }
            return true;
        }
    }
}
