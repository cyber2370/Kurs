using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Kurs.Classes;
using Kurs.Classes.Model;

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
        /// Событие Click кнопки Добавить. Открывает форму PrisonerForm для добавления.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBtn_Click(object sender, EventArgs e)
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
    }
}
