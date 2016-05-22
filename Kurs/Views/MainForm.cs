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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BindCollectionToDataGridView(PrisonerCollection.PrisonersList);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var form = new PrisonerForm();
            form.ShowDialog();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) return;

            var form = new PrisonerForm(Convert.ToInt32(DGV[0, e.RowIndex].Value), false);
            form.ShowDialog();
        }

        private void BindCollectionToDataGridView(BindingList<Prisoner> list)
        {
            var bindingList = list;
            var source = new BindingSource(bindingList, null);
            DGV.DataSource = source;
        }
    }
}
