using System;
using System.Linq;
using System.Windows.Forms;
using Kurs.Classes;
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
            deleteBtn.Visible = false;
            writableBtn.Visible = false;
            okBtn.Visible = true;
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
            Text = (writable) ? @"Изменение заключенного" : "Просмотр заключенного";
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

            ((ComboBox) persControls["FamilyCB"]).SelectedIndex = GetFamilyIndexByValue(
                prisoner.PersonalInfo.FamilyStatus.ToString());

            ((ComboBox) imprisControls["prisonCB"]).SelectedIndex = GetPrisonIndexByValue(
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

            var personalInf = new PersonalInfo()
            {
                FamilyStatus = (FamilyStatus)Enum.Parse(typeof(FamilyStatus),
                    GetFamilyValueByIndex(FamilyCB.SelectedIndex), true),

                FirstName = FirstNameTB.Text,
                SecondName = SecondNameTB.Text,
                MiddleName = MiddleNameTB.Text,
                Birthday = birthdayDTP.Value,
                СityOfBirth = CityBornTB.Text
            };

            var imprisInfo = new ImprisonmentInfo()
            {
                Prison = (Prisons) Enum.Parse(typeof(Prisons),
                    GetPrisonValueByIndex(prisonCB.SelectedIndex), true),

                ImprisonmentCount = Convert.ToInt32(ImprCountNUD.Value),
                PrisonCell = Convert.ToInt32(PrisCellNUD.Value),
                JailedDate = JailedDTP.Value,
                JailingMonths = Convert.ToInt32(JailingYearsNUD.Value*12 + JailingMonthsNUD.Value)
            };

            var prisoner = new Prisoner()
            {
                Id = this.prisoner?.Id ?? 0,
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
            WritableFieldsHelper(Controls["tabControl1"].Controls[0].Controls, verif);
            WritableFieldsHelper(Controls["tabControl1"].Controls[1].Controls, verif);
        }

        /// <summary>
        /// Вспомогательный метод для метода writableFields. Изменяет свойство Enabled у полей на форме.
        /// </summary>
        /// <param name="control"></param>
        /// <param name="verif"></param>
        private void WritableFieldsHelper(Control.ControlCollection control, bool verif)
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



        private string GetFamilyValueByIndex(int index)
        {
            switch (index)
            {
                case 1:
                    return "Женат";
                case 2:
                    return "НеЖенат";
                case 3:
                    return "Разведен";
                default:
                    return "Неизвестно";
            }
        }

        private int GetFamilyIndexByValue(string value)
        {
            switch (value)
            {
                case "Женат":
                    return 1;
                case "НеЖенат":
                    return 2;
                case "Разведен":
                    return 3;
                default:
                    return 0;
            }
        }

        private string GetPrisonValueByIndex(int index)
        {
            switch (index)
            {
                case 1:
                    return "БутырскаяТюрьма";
                case 2:
                    return "Кресты";
                case 3:
                    return "ЛефортовскаяТюрьма";
                case 4:
                    return "МатросскаяТюрьма";
                case 5:
                    return "ВладимирскийЦентрал";
                case 6:
                    return "БелыйЛебедь";
                default:
                    return "Неизвестно";
            }
        }

        private int GetPrisonIndexByValue(string value)
        {
            switch (value)
            {
                case "БутырскаяТюрьма":
                    return 1;
                case "Кресты":
                    return 2;
                case "ЛефортовскаяТюрьма":
                    return 3;
                case "МатросскаяТюрьма":
                    return 4;
                case "ВладимирскийЦентрал":
                    return 5;
                case "БелыйЛебедь":
                    return 6;
                default:
                    return 0;
            }
        }

    }
}
