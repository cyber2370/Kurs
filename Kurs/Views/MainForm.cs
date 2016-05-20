using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Kurs.Classes;

namespace Kurs.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void summaryBtn_Click(object sender, EventArgs e)
        {

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            var list = PrisonerCollection.PrisonersList; //.Select(x =>
            //new { Id = x.Id, FirstName = x.FirstName, SecondName = x.SecondName, MiddleName = x.MiddleName });
            //DGV.DataSource = PrisonerCollection.PrisonersList;
        } 

        private void addBtn_Click(object sender, EventArgs e)
        {
            var form = new AddForm();
            form.ShowDialog();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var form = new SearchForm();
            form.ShowDialog();
        }

        private void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var form = new ShowForm(Convert.ToInt32(DGV[0, e.RowIndex].Value));
            form.ShowDialog();
        }

        private void FillTable(IEnumerable<XElement> prisoners)
        {
            if (!prisoners?.Any() ?? true) return;

            DGV.RowCount = 0;
            
            foreach (var p in prisoners)
            {
                var row = new DataGridViewRow();
                var id = new DataGridViewTextBoxCell();
                var fName = new DataGridViewTextBoxCell();
                var sName = new DataGridViewTextBoxCell();
                var tName = new DataGridViewTextBoxCell();

                id.Value = p.FirstAttribute?.Value ?? "-1";
                fName.Value = p.Element("firstName")?.Value ?? "error";
                sName.Value = p.Element("secondName")?.Value ?? "error";
                tName.Value = p.Element("middleName")?.Value ?? "error";

                row.Cells.AddRange(id, fName, sName, tName);
                DGV.Rows.Add(row);
            }
        }

    }
}
