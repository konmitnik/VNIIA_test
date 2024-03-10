using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VNIIA_test.AppContext;
using VNIIA_test.Models;

namespace VNIIA_test.Forms
{
    public partial class DocumnetForm : Form
    {
        private readonly int? docId;
        public DocumnetForm(int? DocId = null)
        {
            InitializeComponent();
            docId = DocId;
        }

        private void DocSaveBtn_Click(object sender, EventArgs e)
        {
            using (VniiaSharpContext db = new VniiaSharpContext())
            {
                if (docId == null)
                {
                    Document doc = new Document
                    {
                        Number = Convert.ToInt32(DocNumField.Text),
                        Date = DateOnly.FromDateTime(DocDatePicker.Value.Date),
                        Comment = DocComField.Text
                    };
                    foreach (Position pos in DocPosView.Rows)
                    {
                        doc.Positions.Add(pos);
                    }
                    db.Documents.Add(doc);
                    db.SaveChanges();
                }
                else
                {
                    Document doc = db.Documents.Find(docId);
                    doc.Number = Convert.ToInt32(DocNumField.Text);
                    doc.Date = DateOnly.FromDateTime(DocDatePicker.Value.Date);
                    doc.Comment = DocComField.Text;
                    foreach (Position pos in DocPosView.Rows)
                    {
                        doc.Positions.Add(pos);
                    }
                    db.Documents.Update(doc);
                    db.SaveChanges(true);
                }

                this.Close();
            }
        }

        private void DocDelBtn_Click(object sender, EventArgs e)
        {
            if (docId != null)
            {
                using (VniiaSharpContext db = new VniiaSharpContext())
                {
                    Document? doc = db.Documents.Find(docId);
                    db.Documents.Remove(doc);
                    db.SaveChanges();
                }
            }
            this.Close();
        }

        private void DocumnetForm_Load(object sender, EventArgs e)
        {
            using (VniiaSharpContext db = new VniiaSharpContext())
            {
                Document? doc = db.Documents.Find(docId);
                if (doc != null)
                {
                    DocNumField.Text = doc.Number.ToString();
                    DocDatePicker.Text = doc.Date.ToString();
                    DocSumField.Text = db.Positions.Where(p => p.DocId == doc.Id).Sum(p => p.Sum).ToString();
                    DocComField.Text = doc.Comment;

                    DocPosView.DataSource = db.Positions.Where(p => p.DocId == doc.Id).Select(p => new
                    {
                        Id = p.Id,
                        Number = p.Number,
                        Name = p.Name,
                        Sum = p.Sum
                    }).ToList();
                    DocPosView.Columns["Id"].Visible = false;
                    DocPosView.Columns["Number"].HeaderText = "Номер";
                    DocPosView.Columns["Name"].HeaderText = "Наименование";
                    DocPosView.Columns["Sum"].HeaderText = "Сумма";
                }
            }
        }

        private void NewDocPosBtn_Click(object sender, EventArgs e)
        {
            PositionForm form = new PositionForm(DocParentId: docId);
            form.Show();
        }

        private void DocPosView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PositionForm form = new PositionForm(Convert.ToInt32(DocPosView.Rows[e.RowIndex].Cells["Id"].Value), docId);
            form.Show();
        }
    }
}
