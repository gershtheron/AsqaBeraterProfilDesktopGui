using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ASQA_BeraterProfil
{
    public partial class Profil : Form
    {

        private Database db = new Database();//zugriff zum datenbank
        private List<Mitarbeiter> ListMitar;


        public Profil()
        {
            InitializeComponent();
        }


        private void Profil_Load(object sender, EventArgs e)
        {
            LoadMitarbeiter();
            
        }

        private void Profil_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 Mainform = new Form1();
            Mainform.Show();
        }

        private void LoadMitarbeiter()
        {
            List<Mitarbeiter> ListMa = db.getMitarbeiter();

            cbNachname.DataSource = ListMa;
            cbNachname.DisplayMember = "Ma_nachname1";
        }

     
        private void cbNachname_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbNachname.SelectedItem is Mitarbeiter selectedMitarbeiter)
            {             
                rtbVorname.Text = selectedMitarbeiter.Ma_Vorname1;
                rtbMa_Rolle.Text = selectedMitarbeiter.Firma_Rolle1;
                rtbMa_Schwerpunkte.Text = selectedMitarbeiter.Schwerpunkte1;
                


                //PHOTOBOX -----------------------------------
                string imagePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    "Fotos", $"{selectedMitarbeiter.Ma_Nachname1}.jpg");

                if (File.Exists(imagePath))
                {
                    pbMaFoto.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // Set a default image or display a placeholder
                    pbMaFoto.Image = null; // Set a default image or placeholder
                }
                //-------------------------------------------

                listboxinfo.Items.Clear();
                // Fetch skills and competencies for the selected Mitarbeiter
                var techAndkomp = db.GetTechForMitarbeiter(selectedMitarbeiter.Ma_id1);
                
                // Populate the listboxinfo with skills and competency levels tech_name, seitjahr, komp_id
                foreach (var (TechName, Seitjahr, Komp_id) in techAndkomp)
                {
                    listboxinfo.Items.Add($"{TechName} seit: {Seitjahr} komp: {Komp_id}");
                }

                List<(string TechName, string Seitjahr, int Komp_id)> mitarbeiterSkills = db.GetTechForMitarbeiter(selectedMitarbeiter.Ma_id1);
                DisplayTech(mitarbeiterSkills);





                var ProjectRoles = db.GetProjektForMitarbeiter(selectedMitarbeiter.Ma_id1);

                flowLayoutPanel1.Controls.Clear();
                foreach (var (projName, maRolle, taetigkeiten, startDate, endDate) in ProjectRoles)
                {
                    //listboxinfo.Items.Add($"Project: {Projekt} - Role: {Rolle} - Start: {Start.ToShortDateString()} - End: {End.ToShortDateString()}");

                    Panel projectPanel = new Panel
                    {
                        Width = flowLayoutPanel1.Width - 20, // Adjust based on FlowLayoutPanel width
                        Height = 100, // Or any other height that fits your content
                        Padding = new Padding(5), // Optional, for some inner spacing
                        BorderStyle = BorderStyle.Fixed3D, // Optional, for better visual separation
                        BackColor = SystemColors.GradientInactiveCaption
                    };

                    // Example: Adding a label to each project panel
                    Label projectLabel = new Label
                    {
                        Text = $"Project: {projName} \n - Role: {maRolle} \n - Start: {startDate} - End: {endDate}",
                        AutoSize = true, // Or set specific size
                        Dock = DockStyle.Top // Adjust as needed
                    };
                    projectPanel.Controls.Add(projectLabel);

                    // Add more controls as needed...

                    flowLayoutPanel1.Controls.Add(projectPanel);

                }


                rtbAusbildungen.Clear(); // Clears the RichTextBox content
                var ausbildungen = db.GetAusbildungenForMitarbeiter(selectedMitarbeiter.Ma_id1);
                foreach (var ausbildung in ausbildungen)
                {
                    rtbAusbildungen.AppendText(ausbildung + Environment.NewLine); // Appends each Ausbildung name followed by a newline
                }



                rtbKommunikation.Clear(); // Clears the RichTextBox content
                var sprachen = db.GetSpracheForMitarbeiter(selectedMitarbeiter.Ma_id1);
                foreach (var sprache in sprachen)
                {
                    rtbKommunikation.AppendText(sprache + Environment.NewLine); // Appends each Ausbildung name followed by a newline
                }










            }

        }



        private void DisplayTech(List<(string TechName, string Seitjahr, int Komp_id)> techs)//SKILLS PANEL -----

        {
            const int labelHeight = 20;
            const int progressBarHeight = 20;
            const int spacing = 5;
            int currentYPosition = 5; // Initial Y position for the first item

            // Clear existing controls from the panel
            skillsPanel.Controls.Clear();

            foreach (var (TechName, Seitjahr, Komp_id) in techs)
            {
                // Create and configure the label for the skill name
                Label techLabel = new Label
                {
                    Text = TechName,
                    Location = new Point(10, currentYPosition),
                    Size = new Size(100, labelHeight)
                };
                skillsPanel.Controls.Add(techLabel);

                // Create and configure the progress bar for the skill level
                System.Windows.Forms.ProgressBar skillProgressBar = new System.Windows.Forms.ProgressBar
                {
                    Minimum = 1,
                    Maximum = 5,
                    Value = Komp_id,
                    Location = new Point(120, currentYPosition),
                    Size = new Size(100, progressBarHeight)
                };
                skillsPanel.Controls.Add(skillProgressBar);

                // Adjust Y position for the next item
                currentYPosition += labelHeight + progressBarHeight + spacing;
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (cbNachname.SelectedItem is Mitarbeiter selectedMitarbeiter)
            {
                EditProfil EditProfilform = new EditProfil();

                EditProfilform.Show();

                EditProfilform.SetMitarbeiterDetails(selectedMitarbeiter);

                this.Hide();
            }

        }


















//NOISE
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void rtbKommunikation_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
