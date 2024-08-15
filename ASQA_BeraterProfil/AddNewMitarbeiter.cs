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

    public partial class AddNewMitarbeiter : Form
    {
        private Database db = new Database();//zugriff zum datenbank

        public AddNewMitarbeiter()
        {
            InitializeComponent();

        }

        private void AddNewMitarbeiter_Load(object sender, EventArgs e)
        {
            UpdatelbMitarbeiter();
        }

        private void AddNewMitarbeiter_FormClosed(object sender, FormClosedEventArgs e)
        {
            EditProfil EditProfilform = new EditProfil();
            EditProfilform.Show();
            this.Hide();
        }

        private void btnAddNewMitarbeiter_Click(object sender, EventArgs e)
        {
            Mitarbeiter Mitarb = new Mitarbeiter();
            Mitarb.Ma_id1 = -1;
            Mitarb.Ma_Nachname1 = tbMa_Nachname.Text;
            Mitarb.Ma_Vorname1 = tbMa_Name.Text;
            Mitarb.Ma_Gebjahr1 = tbMa_Geburts.Text;
            Mitarb.Firma_Rolle1 = rtbMa_Rolle.Text;
            Mitarb.Schwerpunkte1 = rtbMa_Schwerpunkte.Text;

            db.saveMitarbeiter(Mitarb);

            tbMa_Nachname.Clear();
            tbMa_Name.Clear();
            tbMa_Geburts.Clear();
            rtbMa_Rolle.Clear();
            rtbMa_Schwerpunkte.Clear();
        }


        private void UpdatelbMitarbeiter()
        {
            // Clear the existing items in the ListBox
            lbMitarbeiter.Items.Clear();

            // Get the list of skills from the database
            List<Mitarbeiter> Mitar = db.getMitarbeiter();


            // Add each skill to the ListBox
            foreach (Mitarbeiter Mitars in Mitar)
            {
                string displayText = $"(ID: {Mitars.Ma_id1}) {Mitars.Ma_Vorname1},{Mitars.Ma_Nachname1}  ";
                lbMitarbeiter.Items.Add(displayText);

            }
        }

        
    }
}
