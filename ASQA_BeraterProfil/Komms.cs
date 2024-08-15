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
    public partial class Komms : Form
    {
        private Database db = new Database();//zugriff zum datenbank
        private List<Sprache> ListSprache;

        public Komms()
        {
            InitializeComponent();
            SpracheAnzeigen();
        }

        private void btnAddNewKomms_Click(object sender, EventArgs e)
        {
            Sprache Sprach = new Sprache();
            Sprach.Sprache_id1 = -1;
            Sprach.Sprache_name1 = tbKomm_name.Text;

            db.saveSprache(Sprach);
            SpracheAnzeigen();


        }

        private void SpracheAnzeigen()
        {
            dgvKomms.Rows.Clear();

            ListSprache = db.getSprache();

            foreach (Sprache komms in ListSprache)
            {
                dgvKomms.Rows.Add(komms.Sprache_id1, komms.Sprache_name1);
            }
        }

        private void Komms_FormClosed(object sender, FormClosedEventArgs e)
        {
            EditProfil EditProfilform = new EditProfil();
            EditProfilform.Show();
            this.Hide();
        }
    }
}
