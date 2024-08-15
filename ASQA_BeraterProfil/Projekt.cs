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
    public partial class Projekt : Form
    {
        private Database db = new Database();//zugriff zum datenbank
        private List<Projekten> ListProjekten;

        public Projekt()
        {
            InitializeComponent();
        }

        private void Projekt_Load(object sender, EventArgs e)
        {
            ProjektenAnzeigen();
            LoadProjekten();
        }

        private void ProjektenAnzeigen()
        {
            ListProjekten = db.getProjekten();

            foreach (Projekten Proj in ListProjekten)
            {
                dgvProjekten.Rows.Add(Proj.Proj_id, Proj.Proj_name);
            }
        }
        private void LoadProjekten()
        {
            List<Projekten> ListProj = db.getProjekten();

            cbProjekten.DataSource = ListProj;
            cbProjekten.DisplayMember = "Proj_name";
        }

 

      
        private void PopulateMitarbeiterForProject(int projId)
        {
            lbProjektMitarbeiter.Items.Clear();

            // Assuming you have a method in your db class to get Mitarbeiter details by project ID
            var mitarbeiterList = db.GetMitarbeiterForProjekt(projId);

            foreach (var mitarbeiter in mitarbeiterList)
            {
                // Assuming you want to display the Mitarbeiter's name, adjust as needed
                lbProjektMitarbeiter.Items.Add($"{mitarbeiter.Vorname}.{mitarbeiter.Nachname} ({mitarbeiter.Ma_rolle}: {mitarbeiter.Start_date}/{mitarbeiter.End_date}) ");
            }
        }
        private void dgvProjekten_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProjekten.SelectedRows.Count > 0)
            {
                var selectedRow = dgvProjekten.SelectedRows[0];
                int projId = Convert.ToInt32(selectedRow.Cells["Column1"].Value); // Adjust "ProjIdColumn" to your actual project ID column name

                PopulateMitarbeiterForProject(projId);
            }
        }













        private void button4_Click(object sender, EventArgs e)//ADD_PROJEKT BUTTON
        {
            Add_Projekt Add_Projektform = new Add_Projekt();
            Add_Projektform.Show();

        }

        private void Projekt_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 Mainform = new Form1();
            Mainform.Show();
        }






        private void dgvProjekten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
