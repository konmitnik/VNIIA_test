using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using VNIIA_test.AppContext;
using VNIIA_test.Models;

namespace VNIIA_test
{
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
            using (VniiaSharpContext db = new VniiaSharpContext()) 
            {
                DocMasterView.DataSource = db.Documents.Local.ToBindingList();
                PosMasterView.DataSource = db.Positions.Local.ToBindingList();
                DocPosView.DataSource = db.Positions.Local.ToBindingList().Where();
            }
        }

        private void DocSaveBtn_Click(object sender, EventArgs e)
        {
            using (VniiaSharpContext db = new VniiaSharpContext())
            {
                Document? doc = db.Documents.Find(Convert.ToInt32(DocIdLabel.Text));

                if (doc == null)
                {
                    doc = new Document
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
            }
        }

        private void DocDelBtn_Click(object sender, EventArgs e)
        {
            using (VniiaSharpContext db = new VniiaSharpContext())
            {
                Document? doc = db.Documents.Find(Convert.ToInt32(DocIdLabel.Text));

                if (doc != null)
                {
                    db.Documents.Remove(doc);
                    db.SaveChanges();
                }
            }
        }

        private void PosSaveBtn_Click(object sender, EventArgs e)
        {
            using (VniiaSharpContext db = new VniiaSharpContext())
            {
                Position? pos = db.Positions.Find(Convert.ToInt32(PosIdLabel.Text));

                if (pos == null)
                {
                    pos = new Position
                    {
                        Number = Convert.ToInt32(PosNumField.Text),
                        Name = PosNameField.Text,
                        Sum = Convert.ToInt32(PosSumField.Text)
                    };
                    db.Positions.Add(pos);
                    db.SaveChanges();
                }
                else
                {
                    pos.Number = Convert.ToInt32(DocNumField.Text);
                    pos.Name = PosNameField.Text;
                    pos.Sum = Convert.ToInt32(PosSumField.Text);
                    db.Positions.Update(pos);
                    db.SaveChanges(true);
                }
            }
        }

        private void PosDelBtn_Click(object sender, EventArgs e)
        {
            using (VniiaSharpContext db = new VniiaSharpContext())
            {
                Position? pos = db.Positions.Find(Convert.ToInt32(PosIdLabel.Text));

                if (pos != null)
                {
                    db.Positions.Remove(pos);
                    db.SaveChanges();
                }
            }
        }
    }
}
