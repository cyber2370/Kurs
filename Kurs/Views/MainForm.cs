using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Kurs.Classes;
using Kurs.Model;

namespace Kurs.Views
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Стандартный конструктор.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Событие FormLoad главной формы. Привязывает общую коллекцию заключенных к таблице.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            BindCollectionToDataGridView(PrisonerCollection.PrisonersList);
        }


        /// <summary>
        /// Открывает форму для добавления заключенного.
        /// </summary>
        private void AddFormCall()
        {
            var form = new PrisonerForm();
            form.ShowDialog();
        }


        /// <summary>
        /// Событие Click кнопки Найти. Собирает параметры поиска с формы, перепривязывает форму к коллекции заключенных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchBtn_Click(object sender, EventArgs e)
        {
            var col = PrisonerCollection.Find(CreatePrisonerFromForm());
            BindCollectionToDataGridView(col);
        }


        /// <summary>
        /// Событие таблицы CellDoubleClick. Открывает форму для отображения/изменения/удаления заключенного.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) return;

            var form = new PrisonerForm(Convert.ToInt32(DGV[0, e.RowIndex].Value), false);
            form.ShowDialog();
        }


        /// <summary>
        /// Привязывает коллекцию к таблице DataGridView.
        /// </summary>
        /// <param name="list"></param>
        private void BindCollectionToDataGridView(BindingList<Prisoner> list)
        {
            var bindingList = list;
            var source = new BindingSource(bindingList, null);
            DGV.DataSource = source;
        }


        /// <summary>
        /// Событие FormClosing формы MainForm. Сохраняет коллекцию заключенных в файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            PrisonerCollection.Save();
        }


        /// <summary>
        /// Событие вызова ContextMenu таблицы DGV (DataGridView). 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV_CellContextMenuStripNeeded(object sender,
            DataGridViewCellContextMenuStripNeededEventArgs e)
        {

            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            DGV[e.ColumnIndex, e.RowIndex].Selected = true;
            DGV.ContextMenuStrip.Show(new System.Drawing.Point());
        }

        /// <summary>
        /// Просмотреть (контекстное меню таблицы).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void просмотретьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new PrisonerForm(Convert.ToInt32(DGV[0, DGV.SelectedRows[0].Index].Value), false);
            form.ShowDialog();
        }


        /// <summary>
        /// Изменить заключенного (контекстное меню таблицы).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeTMSI_Click(object sender, EventArgs e)
        {
            var form = new PrisonerForm(Convert.ToInt32(DGV[0, DGV.SelectedRows[0].Index].Value), true);
            form.ShowDialog();
        }


        /// <summary>
        /// Удалить заключенного заключенного (контекстное меню таблицы).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteTMSI_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(@"Вы уверены?",
               @"Удаление заключенного", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;
            PrisonerCollection.RemovePrisoner(Convert.ToInt32(DGV[0, DGV.SelectedRows[0].Index].Value));
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new PrisonerForm();
            form.ShowDialog();
        }

        private void разработчикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Программа разработана студентом группы ПИ-15-1 Черкасом Борисом.", "Справочник начальника тюрьмы." );
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Програма дозволяє знайти ув'язнених, які задовольняють"
            + "різним критеріям пошуку. Ув'язнених можна шукати за анкетними даними, статтею, "
            + "датою взяття під варту, місцем в тюремній ієрархії, камерою, відомостями про родичів, " 
            + "особливостями характеру. Є можливість додавати, видаляти та редагувати інформацію про ув'язнених, " 
            + "робити звіт, а також зберігати оновлений перелік ув'язнених після редагування.", "Справочник начальника тюрьмы.");
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrisonerCollection.Save();
        }


        /// <summary>
        /// Собирает данные поиска с формы в один объект.
        /// </summary>
        /// <returns></returns>
        private Prisoner CreatePrisonerFromForm()
        {
            var persInfo = new PersonalInfo()
            {
                FirstName = FirstNameTB.Text,
                SecondName = SecondNameTB.Text,
                MiddleName = MiddleNameTB.Text,
                Birthday = BirthdayDTP.Value,
                СityOfBirth = CityBornTB.Text
            };

            var imprInfo = new ImprisonmentInfo()
            {
                JailedDate = JailedDTP.Value,
                JailingMonths = Convert.ToInt32(JailingYearsNUD.Value) * 12 + Convert.ToInt32(JailingMonthsNUD.Value),
                PrisonCell = Convert.ToInt32(PrisCellNUD.Value),
                ImprisonmentCount = Convert.ToInt32(ImprCountNUD.Value),
            };

            return new Prisoner()
            {
                ImprisonmentInfo = imprInfo,
                PersonalInfo = persInfo
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstNameTB.Text = SecondNameTB.Text = MiddleNameTB.Text = CityBornTB.Text = "";
            BirthdayDTP.Value = JailedDTP.Value = new DateTime(1800, 1, 1);
            JailingYearsNUD.Value = ImprCountNUD.Value = JailingMonthsNUD.Value = PrisCellNUD.Value = 0;
            FamilyCB.SelectedIndex = PrisonCB.SelectedIndex = 0;
            
            BindCollectionToDataGridView(PrisonerCollection.PrisonersList);
        }
    }
}
