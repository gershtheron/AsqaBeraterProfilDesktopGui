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
    public partial class Add_Tech : Form
    {
        private Database db = new Database();//zugriff zum datenbank
        private List<Technologie> ListTechnologie;

        public Add_Tech()
        {
            InitializeComponent();
            UpdateLbTech();
        }

        private void btnAddNewTech_Click(object sender, EventArgs e)
        {
            Technologie Tech = new Technologie();
            Tech.Tech_id = -1;
            Tech.Tech_name = tbAddTechName.Text;

            db.saveTechnologie(Tech);

            UpdateLbTech();

        }
        private void UpdateLbTech()
        {
            // Clear the existing items in the ListBox
            lbTech.Items.Clear();

            // Get the list of skills from the database
            List<Technologie> Tech = db.getTechnologie();


            // Add each skill to the ListBox
            foreach (Technologie Techs in Tech)
            {
                string displayText = $"{Techs.Tech_name} (ID: {Techs.Tech_id})";
                lbTech.Items.Add(displayText);

            }
        }

        private void btnAddNewTech_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Optional: check if a specific control has focus if needed
                // if (!someSpecificControl.ContainsFocus)

                btnAddNewTech.PerformClick();
                e.Handled = true; // Prevent further processing of the Enter key
            }
        }

        private void Add_Tech_Load(object sender, EventArgs e)
        {

        }
    }
}
