using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Kurs.Model;
using Kurs.Views;

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
        /// Событие FormLoad главной формы.
        /// Привязывает главную коллекцию заключенных к таблице.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            BindCollectionToDataGridView(PrisonerCollection.PrisonersList);
            PrisonCB.SelectedIndex = FamilyCB.SelectedIndex = 0;
        }


        /// <summary>
        /// Событие Click кнопки Найти. Собирает параметры поиска с формы, 
        /// перепривязывает форму к коллекции заключенных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchBtn_Click(object sender, EventArgs e)
        {
            var col = PrisonerCollection.Find(CreatePrisonerFromForm());
            MessageBox.Show(!col.Any()
                        ? "Не найдено заключенных по вашему запросу"
                        : "По вашему запросу найдено "
                        + $"{col.Count()} заключенных.",
                        "Результаты поиска");
            BindCollectionToDataGridView(col);
        }


        /// <summary>
        /// Событие таблицы CellDoubleClick. 
        /// Открывает форму для отображения/изменения/удаления заключенного.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowPrisoner();
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
        /// Событие FormClosing формы MainForm. 
        /// Сохраняет коллекцию заключенных в файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!PrisonerCollection.IsChanged) return;

            DialogResult dialogResult =
                MessageBox.Show
                    (@"Внесенные изменения не были сохранены. Желаете сохранить?",
                        @"Внимание! Потеря данных!", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;
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
        /// Изменить заключенного (контекстное меню таблицы).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeTMSI_Click(object sender, EventArgs e)
        {
            ChangePrisoner();
        }


        /// <summary>
        /// Удалить заключенного заключенного (контекстное меню таблицы).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteTMSI_Click(object sender, EventArgs e)
        {
            DeletePrisoner();
        }


        /// <summary>
        /// Открывает форму для добавления нового заключенного.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPrisoner();
        }


        /// <summary>
        /// Открывает форму для изменения заключенного, 
        /// который выделен в таблице.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePrisoner();
        }


        /// <summary>
        /// Кнопка из меню "Разработчики". 
        /// Выводит информацию о разработчиках программы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void разработчикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Программа разработана студентом группы ПИ-15-1"
                            + "Черкасом Борисом.", "Справочник начальника тюрьмы.");
        }


        /// <summary>
        /// Кнопка из меню "О программе...".
        /// Отображает основную информацию о программе.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Програма дозволяє знайти ув'язнених, які"
            + "задовольняють різним критеріям пошуку. Ув'язнених можна шукати"
            + "за анкетними даними, статтею, "
            + "датою взяття під варту, місцем в тюремній ієрархії, камерою,"
            + "відомостями про родичів, особливостями характеру. Є можливість "
            + "додавати, видаляти та редагувати інформацію про ув'язнених, "
            + "робити звіт, а також зберігати оновлений перелік ув'язнених"
            + "після редагування.", "Справочник начальника тюрьмы.");
        }


        /// <summary>
        /// Сохраняет текущее состояние основной коллекции
        /// заключенных в файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                СityOfBirth = CityBornTB.Text,
                FamilyStatus = FormHelper
                                .GetFamilyValueByIndex(FamilyCB.SelectedIndex)
            };

            var imprInfo = new ImprisonmentInfo()
            {
                JailedDate = JailedDTP.Value,
                JailingMonths = Convert.ToInt32(JailingYearsNUD.Value) * 12
                                + Convert.ToInt32(JailingMonthsNUD.Value),
                PrisonCell = Convert.ToInt32(PrisCellNUD.Value),
                ImprisonmentCount = Convert.ToInt32(ImprCountNUD.Value),
                Prison = FormHelper.GetPrisonValueByIndex(PrisonCB.SelectedIndex)
            };

            return new Prisoner()
            {
                ImprisonmentInfo = imprInfo,
                PersonalInfo = persInfo
            };
        }


        /// <summary>
        /// Кнопка Сброс. Очищает поля поиска и отображает 
        /// полную коллекцию заключенных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            FirstNameTB.Text = SecondNameTB.Text
                = MiddleNameTB.Text = CityBornTB.Text = "";

            BirthdayDTP.Value = JailedDTP.Value = new DateTime(1800, 1, 1);

            JailingYearsNUD.Value = ImprCountNUD.Value
                = JailingMonthsNUD.Value = PrisCellNUD.Value = 0;

            FamilyCB.SelectedIndex = PrisonCB.SelectedIndex = 0;

            BindCollectionToDataGridView(PrisonerCollection.PrisonersList);
        }


        /// <summary>
        /// Просмотреть (контекстное меню таблицы).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void просмотретьToolStripMenuItem_Click_1
            (object sender, EventArgs e)
        {
            ShowPrisoner();
        }


        /// <summary>
        /// Кнопка из меню программы "Удалить заключенного".
        /// Удаляет выбранного в таблице заключенного.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletePrisoner();
        }


        /// <summary>
        /// Кнопка Удалить всех заключенных из меню программы. 
        /// Полностью очищает коллекцию от заключенных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void удалитьВсехЗаключенныхToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            DialogResult dialogResult =
                MessageBox.Show
                (@"Вы точно уверены, что хотите удалить всех заключенных?",
                    @"Удаление ВСЕХ заключенных!", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;
            PrisonerCollection.DeleteAllPrisoners();
            BindCollectionToDataGridView(PrisonerCollection.PrisonersList);
        }


        /// <summary>
        /// Открывает форму отображения детальной 
        /// информации по заключенному.
        /// </summary>
        private void ShowPrisoner()
        {
            if (!CheckTable()) return;
            var form = new PrisonerForm
                (Convert.ToInt32(DGV[0, DGV.SelectedRows[0].Index].Value), false);
            form.ShowDialog();
        }


        /// <summary>
        /// Открывает форму добавления заключенного.
        /// </summary>
        private void AddPrisoner()
        {
            var form = new PrisonerForm();
            form.ShowDialog();
        }


        /// <summary>
        /// Открывает форму изменения заключенного.
        /// </summary>
        private void ChangePrisoner()
        {
            if (!CheckTable()) return;
            var form = new PrisonerForm
                (Convert.ToInt32(DGV[0, DGV.SelectedRows[0].Index].Value), true);
            form.ShowDialog();
        }


        /// <summary>
        /// Удаляет заключенного из коллекции.
        /// </summary>
        private void DeletePrisoner()
        {
            if (!CheckTable()) return;
            DialogResult dialogResult = MessageBox.Show(@"Вы уверены?",
                @"Удаление заключенного", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;
            PrisonerCollection.RemovePrisoner
                (Convert.ToInt32(DGV[0, DGV.SelectedRows[0].Index].Value));
        }


        /// <summary>
        /// Проверяет, выбран ли заключенный в таблице.
        /// </summary>
        /// <returns></returns>
        private bool CheckTable()
        {
            if (DGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Сначала выберите заключенного!", "Ошибка");
                return false;
            }
            return true;
        }


        /// <summary>
        /// Показывает MessageBox с обобщенной информацией о заключенных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void обобщенныеДанныеToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            var prisLst = PrisonerCollection.PrisonersList;
            var buturka = prisLst.Count(x => x.Prison.ToString().Equals("Butyrskaya"));
            var krestu = prisLst.Count(x => x.Prison.ToString().Equals("Crosses"));
            var lefort = prisLst.Count(x => x.Prison.ToString().Equals("Lefortovo"));
            var matros = prisLst.Count(x => x.Prison.ToString().Equals("Sailor"));
            var vladimir = prisLst.Count(x => x.Prison.ToString().Equals("VladimirskyCentral"));
            var lebed = prisLst.Count(x => x.Prison.ToString().Equals("WhiteSwan"));
            var unknown = prisLst.Count(x => x.Prison.ToString().Equals("Unknown"));

            MessageBox.Show($"Общее количество заключенных: "
            + $"{prisLst.Count}{Environment.NewLine}{Environment.NewLine}"
            + $"Бутырская тюрьма: {buturka}; {Environment.NewLine}"
            + $"Кресты: {krestu}; {Environment.NewLine}"
            + $"Лефортовская тюрьма: {lefort}; {Environment.NewLine}"
            + $"Матросская тюрьма: {matros}; {Environment.NewLine} "
            + $"Владимирский Централ: {vladimir}; {Environment.NewLine} "
            + $"Белый Лебедь: {lebed}; {Environment.NewLine} "
            + $"Неизвестно: {unknown}. {Environment.NewLine} ",
            "Обобщенная информация о заключенных");
        }
    }
}