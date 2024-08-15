using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ASQA_BeraterProfil
{
    public partial class EditProfil : Form
    {

        private Database db = new Database();//zugriff zum datenbank
        private List<Ausbildungen> ListAusbildungen;
        private List<Technologie> ListTechnologie;
        private List<Sprache> ListSprache;
        private List<Mitarb_Projekt> ListMitarProj;



        public EditProfil()
        {
            InitializeComponent();


        }

        private void EditProfil_Load(object sender, EventArgs e)
        {
            LoadAusbildungen();
            UpdatelbAusb();
            UpdatelbMaAusb();

            LoadTechnologie();
            UpdatelbMa_Tech();
            UpdatelbMaTech();
            LoadKompetenz();

            LoadSpracheKompetenz();
            LoadSprache();
            UpdatelbMa_Sprache();
            UpdatelbMaSprache();


            LoadProjekten();
            MaProjAnzeigen();
            UpdatelbMaProj();



        }




        //_______ PANEL Ma_daten________________________________________________
        private void LoadAusbildungen()
        {
            List<Ausbildungen> ListAusb = db.getAusbildungen();
            cbAusb1.DataSource = ListAusb;
            cbAusb1.DisplayMember = "Ausb_name1";
        }
        public void UpdateComboBoxSelection(object selectedItem)
        {
            comboBox1.SelectedItem = selectedItem;
        }
        public void SetMitarbeiterDetails(Mitarbeiter mitarbeiter)
        {
            // Set the details in textboxes or other controls
            tbMa_id.Text = mitarbeiter.Ma_id1.ToString();
            tbMa_Name.Text = mitarbeiter.Ma_Vorname1;
            tbMa_Nachname.Text = mitarbeiter.Ma_Nachname1;
            tbMa_Geburts.Text = mitarbeiter.Ma_Gebjahr1.ToString();
            rtbMa_Rolle.Text = mitarbeiter.Firma_Rolle1;
            rtbMa_Schwerpunkte.Text = mitarbeiter.Schwerpunkte1;


            //----POPULATE THE MA_LISTBOXES---------------------------------------------->

            lbMaAusb.Items.Clear();
            var ausbildungen = db.GetAusbildungenForMitarbeiter(mitarbeiter.Ma_id1);
            foreach (var Ausb_name in ausbildungen)
            {
                lbMaAusb.Items.Add(Ausb_name);
            }


            lbMaTech.Items.Clear();
            var tech = db.GetTechForMitarbeiter(mitarbeiter.Ma_id1);
            foreach (var (Tech_name, seitjahr, komp_id) in tech)
            {
                lbMaTech.Items.Add($"{Tech_name}; {seitjahr}; {komp_id}");
            }


            lbMaSprache.Items.Clear();
            var sprachen = db.GetSpracheForMitarbeiter(mitarbeiter.Ma_id1);
            foreach (var (Sprache_name, Sprach_komp) in sprachen)
            {
                lbMaSprache.Items.Add($"{Sprache_name}; {Sprach_komp}");
            }


            lbMaProj.Items.Clear();
            var projekte = db.GetProjektForMitarbeiter(mitarbeiter.Ma_id1);
            foreach (var (Proj_name, Ma_rolle, Taetigkeiten, Start_date, End_date) in projekte)
            {
                lbMaProj.Items.Add($"{Proj_name}; {Ma_rolle}; {Taetigkeiten}; {Start_date}; {End_date}");
            }
            //----------------------------------------------------------------------------|POPULATE THE MA_LISTBOXES end


            //PHOTOBOX ---------------------------------->
            string imagePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Fotos", $"{tbMa_Nachname.Text}.jpg");

            if (File.Exists(imagePath))
            {
                pbMa_Foto.Image = Image.FromFile(imagePath);
            }
            else
            {
                // Set a default image or display a placeholder
                pbMa_Foto.Image = null; // Set a default image or placeholder
            }
            //------------------------------------------|PHOTOBOX end

        }
        private void cbAusb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This check ensures that we have a valid selection before attempting to display its corresponding ID.
            if (cbAusb1.SelectedIndex != -1)
            {
                var selectedAusbildung = cbAusb1.SelectedItem as Ausbildungen;
                if (selectedAusbildung != null)
                {
                    tbAusb_id.Text = selectedAusbildung.Ausb_id1.ToString();
                }
            }
            else
            {
                tbAusb_id.Clear();
            }
        }
        private void btnAusbAdd_Click(object sender, EventArgs e)
        {
            Mitarbeiter_Ausbildung ma_ausb = new Mitarbeiter_Ausbildung();
            ma_ausb.Ma_ausb_id = -1;
            ma_ausb.Ma_id = Convert.ToInt32(tbMa_id.Text);
            ma_ausb.Ausb_id = Convert.ToInt32(tbAusb_id.Text);
            ma_ausb.Ausb_name = cbAusb1.Text;

            db.saveMitarAusb(ma_ausb);
            UpdatelbAusb();
            UpdatelbMaAusb();
        }
        private void UpdatelbAusb()
        {
            lbAusb.Items.Clear();

            List<Mitarbeiter_Ausbildung> ma_ausb = db.getMitarAusb();

            foreach (Mitarbeiter_Ausbildung maus in ma_ausb)
            {
                string displayText = $" (Ma_ausb_id: {maus.Ma_ausb_id}, - :{maus.Ausb_name})";
                lbAusb.Items.Add(displayText);
            }
        }
        private void UpdatelbMaAusb()
        {
            lbMaAusb.Items.Clear();

            List<Mitarbeiter_Ausbildung> ma_lbausb = db.getMitarAusb();

            foreach (Mitarbeiter_Ausbildung mauslb in ma_lbausb)
            {
                string displayText = $" (Ma_ausb_id: {mauslb.Ma_ausb_id}, - :{mauslb.Ausb_name})";
                lbMaAusb.Items.Add(displayText);
            }
        }

        //_______________________________________________________|PANEL Ma_daten END








        //PANEL MITARBEITER_TECH ------------------------------------------------->
        private void LoadTechnologie()
        {
            List<Technologie> ListTech = db.getTechnologie();

            cbTech_Ma.DataSource = ListTech;
            cbTech_Ma.DisplayMember = "tech_name";
        }
        private void LoadKompetenz()
        {
            List<Kompetenz> ListKomp = db.getKompetenz();


            cbKomp_Ma.DataSource = ListKomp;
            cbKomp_Ma.DisplayMember = "komp_level";
        }
        private void cbTech_Ma_SelectedIndexChanged(object sender, EventArgs e) //here we convert the technologie name to the id so that we can enter it to the ma_tech table
        {
            if (cbTech_Ma.SelectedIndex != -1)
            {
                var selectedTechnologie = cbTech_Ma.SelectedItem as Technologie;
                if (selectedTechnologie != null)
                {
                    tbTech_id.Text = selectedTechnologie.Tech_id.ToString();
                }
            }
            else
            {
                tbTech_id.Clear();
            }
        }
        private void btnAddSkillsMa_Click(object sender, EventArgs e)
        {
            Mitarb_Tech matec = new Mitarb_Tech();
            matec.Ma_tech_id = -1;

            matec.Ma_id = Convert.ToInt32(tbMa_id.Text);
            matec.Tech_id = Convert.ToInt32(tbTech_id.Text);
            matec.Komp_id = Convert.ToInt32(cbKomp_Ma.Text);
            matec.Seit_jahr = tbSeitJahr.Text;
            matec.Tech_name = cbTech_Ma.Text;

            db.saveMitarbTech(matec);

            UpdatelbMa_Tech();
            UpdatelbMaTech();

        }
        private void UpdatelbMa_Tech()
        {
            lbMa_Tech.Items.Clear();

            List<Mitarb_Tech> ListMitartech = db.getMitarbTech();

            foreach (Mitarb_Tech ma_tech in ListMitartech)
            {
                string displayText = $" ({ma_tech.Tech_name}, {ma_tech.Komp_id}, {ma_tech.Seit_jahr})";
                lbMa_Tech.Items.Add(displayText);
            }
        }
        private void UpdatelbMaTech()
        {
            lbMaTech.Items.Clear();

            List<Mitarb_Tech> ListMatech = db.getMitarbTech();

            foreach (Mitarb_Tech matech in ListMatech)
            {
                string displayText = $" ({matech.Tech_name}, {matech.Komp_id}, {matech.Seit_jahr})";
                lbMaTech.Items.Add(displayText);
            }
        }

        //END --------------------------------------------------------------------|PANEL MITARBEITER TECH









        //PANEL MITARBEITER_SPRACHE ------------------------------------------------->
        private void LoadSprache()
        {
            List<Sprache> ListSprache = db.getSprache();

            cbMa_Sprache.DataSource = ListSprache;
            cbMa_Sprache.DisplayMember = "Sprache_name1";
        }
        private void LoadSpracheKompetenz()
        {
            List<Sprache_Kompetenz> ListSpracheKomp = db.getSpracheKompetenz();
            cbMaKomm_Komp.DataSource = ListSpracheKomp;
            cbMaKomm_Komp.DisplayMember = "sprach_komp";
        }
        private void cbMa_Sprache_SelectedIndexChanged(object sender, EventArgs e)//here we convert the technologie name to the id so that we can enter it to the ma_tech table
        {
            if (cbMa_Sprache.SelectedIndex != -1)
            {
                var selectedSprache = cbMa_Sprache.SelectedItem as Sprache;
                if (selectedSprache != null)
                {
                    tbSprache_id.Text = selectedSprache.Sprache_id1.ToString();
                }
            }
            else
            {
                tbSprache_id.Clear();
            }
        }
        private void btnSaveMa_Sprache_Click(object sender, EventArgs e)
        {
            Mitarbeiter_Sprache ma_sprach = new Mitarbeiter_Sprache();
            ma_sprach.Ma_sprache_id = -1;

            ma_sprach.Ma_id = Convert.ToInt32(tbMa_id.Text);
            ma_sprach.Sprache_id = Convert.ToInt32(tbSprache_id.Text);
            ma_sprach.Sprache_name = cbMa_Sprache.Text;
            ma_sprach.Sprach_komp = cbMaKomm_Komp.Text;


            db.saveMitarSprache(ma_sprach);

            UpdatelbMa_Sprache();
            UpdatelbMaSprache();
        }
        private void UpdatelbMa_Sprache()
        {
            lbMa_Sprache.Items.Clear();

            List<Mitarbeiter_Sprache> ListMitarSprache = db.getMitarSprache();

            foreach (Mitarbeiter_Sprache ma_sprac in ListMitarSprache)
            {
                string displayText = $" ( {ma_sprac.Sprache_name}, - :{ma_sprac.Sprach_komp})";
                lbMa_Sprache.Items.Add(displayText);
            }
        }
        private void UpdatelbMaSprache()
        {
            lbMaSprache.Items.Clear();

            List<Mitarbeiter_Sprache> ListMaSprache = db.getMitarSprache();

            foreach (Mitarbeiter_Sprache masprac in ListMaSprache)
            {
                string displayText = $" ( {masprac.Sprache_name}, - :{masprac.Sprach_komp})";
                lbMaSprache.Items.Add(displayText);
            }
        }

        //END ---------------------------------------------------------------------|PANEL MITARBEITER KOMMS









        //PANEL MITARBEITER_PROJEKT ------------------------------------------------->
        private void LoadProjekten()
        {
            List<Projekten> ListProjekten = db.getProjekten();

            cbProjekt_Ma.DataSource = ListProjekten;
            cbProjekt_Ma.DisplayMember = "Proj_name";
        }
        private void cbProjekt_Ma_SelectedIndexChanged(object sender, EventArgs e)//here we convert the technologie name to the id so that we can enter it to the ma_tech table
        {
            if (cbProjekt_Ma.SelectedIndex != -1)
            {
                var selectedProjekt = cbProjekt_Ma.SelectedItem as Projekten;
                if (selectedProjekt != null)
                {
                    tbProjid.Text = selectedProjekt.Proj_id.ToString();
                }
            }
            else
            {
                tbProjid.Clear();
            }
        }
        private void btnAddProjektMa_Click(object sender, EventArgs e)
        {
            Mitarb_Projekt ma_proj = new Mitarb_Projekt();
            ma_proj.Ma_proj_id = -1;

            ma_proj.Ma_id = Convert.ToInt32(tbMa_id.Text);
            ma_proj.Proj_id = Convert.ToInt32(tbProjid.Text);
            ma_proj.Ma_rolle = tbProjekt_Rolle.Text;
            ma_proj.Start_date = tbStart_date.Text;
            ma_proj.End_date = tbEnd_date.Text;
            ma_proj.Proj_name = cbProjekt_Ma.Text;
            ma_proj.Taetigkeiten = rtbTaetigkeiten.Text;

            db.saveMitarbProj(ma_proj);
            UpdatelbMaProj();

            tbProjekt_Rolle.Clear();
            tbStart_date.Clear();
            tbEnd_date.Clear();


        }

        private void MaProjAnzeigen()
        {
            ListMitarProj = db.getMitarbProj();

            foreach (Mitarb_Projekt MaProj in ListMitarProj)
            {
                dgvMa_Projekten.Rows.Add(MaProj.Proj_name, MaProj.Ma_rolle, MaProj.Start_date, MaProj.End_date);
            }
        }
        private void checkBoxBisHeute_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBisHeute.Checked)
            {
                // When the checkbox is checked, set the TextBox to "Bis Heute"
                tbEnd_date.Text = "Bis Heute";
            }
        }
        private void UpdatelbMaProj()
        {
            lbMaProj.Items.Clear();

            List<Mitarb_Projekt> ListMitarProj = db.getMitarbProj();

            foreach (Mitarb_Projekt maproj in ListMitarProj)
            {
                string displayText = $" ( {maproj.Proj_name}, - {maproj.Ma_rolle}, - {maproj.Start_date}, - {maproj.End_date})";
                lbMaProj.Items.Add(displayText);
            }
        }

        // ------------------------------------------------------------------------|PANEL MITARBEITER_PROJEKT




















        // ------ PAGE FUNCTIONALITY BUTTONS ------------------------------------------>
        private void button4_Click(object sender, EventArgs e) //add newAusbildungen
        {
            Ausbildung Ausbildungform = new Ausbildung();
            Ausbildungform.Show();
            this.Hide();
        }
        private void btnAddNewMa_Click(object sender, EventArgs e)
        {
            AddNewMitarbeiter AddNewMitarbeiterform = new AddNewMitarbeiter();
            AddNewMitarbeiterform.Show();
            this.Hide();
        }
        private void EditProfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            Profil profilform = new Profil();
            profilform.Show();
        }
        private void btnAddNewKomms_Click(object sender, EventArgs e)
        {
            Komms Kommsform = new Komms();
            Kommsform.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)//Zuruck Button
        {
            Profil previousForm = new Profil();
            previousForm.Show();
            this.Hide();
        }
        // ----------------------------------------------------------------------------| PAGE FUNCTIONALITY BUTTONS END













        //NOISE --- 
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void panelMitarbeiter_Sprache_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbMaAusb_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
