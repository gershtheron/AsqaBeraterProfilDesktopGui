using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASQA_BeraterProfil
{
    public partial class Ausbildung : Form
    {
        private Database db = new Database();//zugriff zum datenbank
        private List<Ausbildungen> ListAusbildungen;
        public Ausbildung()
        {
            InitializeComponent();
        }

        private void Ausbildung_Load(object sender, EventArgs e)
        {
            AusbAnzeigen();
        }
        private void AusbAnzeigen()
        {
            ListAusbildungen = db.getAusbildungen();

            foreach (Ausbildungen Ausb in ListAusbildungen)
            {
                dgvAusbildung.Rows.Add(Ausb.Ausb_id1, Ausb.Ausb_name1, Ausb.Ausb_institut1, Ausb.Ausb_jahr1);
            }
        }
        private void btnAddNewAusbildung_Click(object sender, EventArgs e)
        {
            Ausbildungen Ausb = new Ausbildungen();
            Ausb.Ausb_id1 = -1;
            Ausb.Ausb_name1 = tbAusbildungName.Text;
            Ausb.Ausb_institut1 = tbInstitut.Text;
            Ausb.Ausb_jahr1 = tbAusb_Jahr.Text;

            db.saveAusbildungen(Ausb);

            AusbAnzeigen();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ausbildung_FormClosed(object sender, FormClosedEventArgs e)
        {
            EditProfil EditProfilform = new EditProfil();
            EditProfilform.Show();
            this.Hide();
        }
    }
}
