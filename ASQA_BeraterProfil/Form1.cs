namespace ASQA_BeraterProfil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        // -- BUTTONS PANEL --- //
        private void button1_Click(object sender, EventArgs e)//ProfilButton
        {
            Profil profilform = new Profil();
            profilform.Show();
            this.Hide();
        }

        private void btnProjekt_Click(object sender, EventArgs e)
        {
            Projekt Projektform = new Projekt();
            Projektform.Show();
            this.Hide();
        }

        private void btnTech_Click(object sender, EventArgs e)
        {
            Tech Techform = new Tech();
            Techform.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
