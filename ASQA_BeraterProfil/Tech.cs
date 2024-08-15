using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.Collections;

namespace ASQA_BeraterProfil
{
    public partial class Tech : Form
    {

        private Database db = new Database();//zugriff zum datenbank
        private List<Technologie> ListTechnologie;



        public Tech()
        {
            InitializeComponent();
        }




        private void Tech_Load(object sender, EventArgs e)
        {
            TechAnzeigen();
            LoadTech();
        }
        private void TechAnzeigen()
        {
            ListTechnologie = db.getTechnologie();

            foreach (Technologie tech in ListTechnologie)
            {
                dgvTech.Rows.Add(tech.Tech_id, tech.Tech_name);
            }
        }
        private void LoadTech()
        {
            List<Technologie> ListTech = db.getTechnologie();

            cbTech.DataSource = ListTech;
            cbTech.DisplayMember = "Tech_name";
        }









        private void btnAddNewTech_Click(object sender, EventArgs e)
        {
            Add_Tech add_Techform = new Add_Tech();
            add_Techform.Show();
        }









        private void Tech_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 Mainform = new Form1();
            Mainform.Show();
        }

        private void dgvTech_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void PopulateMitarbeiterForTech(int techId)
        {
            lbTechMitarbeiter.Items.Clear();

            // Assuming you have a method in your db class to get Mitarbeiter details by project ID
            var mitarbeiterList = db.GetMitarbeiterForTech(techId);

            foreach (var mitarbeiter in mitarbeiterList)
            {
                // Assuming you want to display the Mitarbeiter's name, adjust as needed
                lbTechMitarbeiter.Items.Add($"{mitarbeiter.Vorname}.{mitarbeiter.Nachname} ({mitarbeiter.Tech_name} seit: {mitarbeiter.Seitjahr}) ");
            }
        }
        private void dgvTech_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTech.SelectedRows.Count > 0)
            {
                var selectedRow = dgvTech.SelectedRows[0];
                int techId = Convert.ToInt32(selectedRow.Cells["Column1"].Value); // Adjust "ProjIdColumn" to your actual project ID column name

                PopulateMitarbeiterForTech(techId);
            }
        }
    }
}
