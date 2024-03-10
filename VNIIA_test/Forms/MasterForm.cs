using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Windows.Forms;
using VNIIA_test.AppContext;

namespace VNIIA_test.Forms
{
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            using (VniiaSharpContext db = new VniiaSharpContext())
            {
                DocMasterView.DataSource = db.Documents.Select(d => new
                {
                    Id = d.Id,
                    Number = d.Number,
                    Date = d.Date,
                    Sum = db.Positions.Where(p => p.DocId == d.Id).Sum(p => p.Sum),
                    Comment = d.Comment
                }).ToList();
                DocMasterView.Columns["Id"].Visible = false;
                DocMasterView.Columns["Number"].HeaderText = "Номер";
                DocMasterView.Columns["Date"].HeaderText = "Дата";
                DocMasterView.Columns["Sum"].HeaderText = "Сумма";
                DocMasterView.Columns["Comment"].HeaderText = "Примечание";

                PosMasterView.DataSource = db.Positions.Select(p => new
                {
                    Id = p.Id,
                    Number = p.Number,
                    Name = p.Name,
                    Sum = p.Sum
                }).ToList();
                PosMasterView.Columns["Id"].Visible = false;
                PosMasterView.Columns["Number"].HeaderText = "Номер";
                PosMasterView.Columns["Name"].HeaderText = "Наименование";
                PosMasterView.Columns["Sum"].HeaderText = "Сумма";
            }
        }

        private void NewDocBtn_Click(object sender, EventArgs e)
        {
            DocumnetForm form = new DocumnetForm();
            form.Show();
        }

        private void NewPosBtn_Click(object sender, EventArgs e)
        {
            PositionForm form = new PositionForm();
            form.Show();
        }

        private void DocMasterView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DocumnetForm form = new DocumnetForm(Convert.ToInt32(DocMasterView.Rows[e.RowIndex].Cells["Id"].Value));
            form.Show();
        }

        private void PosMasterView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PositionForm form = new PositionForm(Convert.ToInt32(PosMasterView.Rows[e.RowIndex].Cells["Id"].Value));
            form.Show();
        }

        private void MasterForm_Enter(object sender, EventArgs e)
        {
            DocMasterView.Update();
            PosMasterView.Update();
        }
    }
}
