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
    public partial class Add_Projekt : Form
    {
        private Database db = new Database();//zugriff zum datenbank
        private List<Projekten> ListProjekten;
        public Add_Projekt()
        {
            InitializeComponent();
            UpdatelbProjekten();
        }

        private void Add_Projekt_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Add_Projekt_Load(object sender, EventArgs e)
        {

        }

        private void btnAddProjekt_Click(object sender, EventArgs e)
        {
            Projekten Proj = new Projekten();
            Proj.Proj_id = -1;
            Proj.Proj_name = tbAddProjektName.Text;

            db.saveProjekten(Proj);

            UpdatelbProjekten();

        }
        private void UpdatelbProjekten()
        {
            // Clear the existing items in the ListBox
            lbProjekten.Items.Clear();

            // Get the list of skills from the database
            List<Projekten> Proj = db.getProjekten();


            // Add each skill to the ListBox
            foreach (Projekten Projekt in Proj)
            {
                string displayText = $"{Projekt.Proj_name} (ID: {Projekt.Proj_id})";
                lbProjekten.Items.Add(displayText);

            }
        }





    }
}
