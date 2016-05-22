using System;
using System.Linq;
using System.Windows.Forms;
using Kurs.Classes;
using Kurs.Classes.Model;

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
                MessageBox.Show("Sorry, but ID is wrong!");
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

            deleteBtn.Visible = true;
            writableBtn.Visible = !writable;
            writableFields(writable);
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
            if(this.prisoner == null)
                PrisonerCollection.AddPrisoner(prisoner);
            else 
                PrisonerCollection.ReplacePrisoner(this.prisoner.Id, prisoner);
            MessageBox.Show(@"Success!");
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


        private void writableFields(bool verif)
        {
            WfHelper(Controls["tabControl1"].Controls[0].Controls, verif);
            WfHelper(Controls["tabControl1"].Controls[1].Controls, verif);
        }

        /// <summary>
        /// Вспомогательный метод для метода writableFields. Изменяет свойство Enabled у полей на форме.
        /// </summary>
        /// <param name="control"></param>
        /// <param name="verif"></param>
        private void WfHelper(Control.ControlCollection control, bool verif)
        { 
            foreach (var c1 in control)
                if (c1 is TextBox)
                    ((TextBox)c1).Enabled = verif;
                else if (c1 is NumericUpDown)
                    ((NumericUpDown)c1).Enabled = verif;
                else if (c1 is ComboBox)
                    ((ComboBox)c1).Enabled = verif;
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
    }
}
