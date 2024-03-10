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
    public partial class PositionForm : Form
    {
        private readonly int? posId;
        private readonly int? docParentId;

        public PositionForm(int? PosId = null, int? DocParentId = null)
        {
            InitializeComponent();
            posId = PosId;
            docParentId = DocParentId;
        }

        private void PosSaveBtn_Click(object sender, EventArgs e)
        {
            using (VniiaSharpContext db = new VniiaSharpContext())
            {
                if (posId == null)
                {
                    Position pos = new Position
                    {
                        Number = Convert.ToInt32(PosNumField.Text),
                        Name = PosNameField.Text,
                        Sum = Convert.ToInt32(PosSumField.Text),
                        DocId = docParentId,
                        Doc = db.Documents.Find(docParentId)
                    };
                    db.Positions.Add(pos);
                    db.SaveChanges();
                }
                else
                {
                    Position? pos = db.Positions.Find(posId);
                    pos.Number = Convert.ToInt32(PosNumField.Text);
                    pos.Name = PosNameField.Text;
                    pos.Sum = Convert.ToInt32(PosSumField.Text);
                    db.Positions.Update(pos);
                    db.SaveChanges(true);
                }
            }

            this.Close();
        }

        private void PosDelBtn_Click(object sender, EventArgs e)
        {
            if (posId != null)
            {
                using (VniiaSharpContext db = new VniiaSharpContext())
                {
                    Position? pos = db.Positions.Find(posId);
                    db.Positions.Remove(pos);
                    db.SaveChanges();
                }
            }
            this.Close();
        }

        private void PositionForm_Load(object sender, EventArgs e)
        {
            if (posId != null)
            {
                using (VniiaSharpContext db = new VniiaSharpContext())
                {
                    Position? pos = db.Positions.Find(posId);
                    PosNumField.Text = pos.Number.ToString();
                    PosNameField.Text = pos.Name;
                    PosSumField.Text = pos.Sum.ToString();
                }
            }
        }
    }
}
