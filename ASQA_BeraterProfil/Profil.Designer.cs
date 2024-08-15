namespace ASQA_BeraterProfil
{
    partial class Profil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtbVorname = new RichTextBox();
            btnEdit = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            listboxinfo = new ListBox();
            skillsPanel = new Panel();
            rtbKommunikation = new RichTextBox();
            rtbMa_Rolle = new RichTextBox();
            rtbAusbildungen = new RichTextBox();
            rtbMa_Schwerpunkte = new RichTextBox();
            pbMaFoto = new PictureBox();
            cbNachname = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMaFoto).BeginInit();
            SuspendLayout();
            // 
            // rtbVorname
            // 
            rtbVorname.Location = new Point(111, 54);
            rtbVorname.Name = "rtbVorname";
            rtbVorname.Size = new Size(187, 33);
            rtbVorname.TabIndex = 45;
            rtbVorname.Text = "Vorname";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightSkyBlue;
            btnEdit.Location = new Point(500, 39);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(109, 60);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit Profil";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(listboxinfo);
            flowLayoutPanel1.Location = new Point(280, 318);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(348, 301);
            flowLayoutPanel1.TabIndex = 44;
            // 
            // listboxinfo
            // 
            listboxinfo.FormattingEnabled = true;
            listboxinfo.ItemHeight = 25;
            listboxinfo.Location = new Point(3, 3);
            listboxinfo.Name = "listboxinfo";
            listboxinfo.Size = new Size(228, 154);
            listboxinfo.TabIndex = 46;
            listboxinfo.Visible = false;
            // 
            // skillsPanel
            // 
            skillsPanel.AutoScroll = true;
            skillsPanel.BorderStyle = BorderStyle.Fixed3D;
            skillsPanel.Location = new Point(16, 318);
            skillsPanel.Name = "skillsPanel";
            skillsPanel.Size = new Size(258, 301);
            skillsPanel.TabIndex = 43;
            // 
            // rtbKommunikation
            // 
            rtbKommunikation.Location = new Point(91, 137);
            rtbKommunikation.Name = "rtbKommunikation";
            rtbKommunikation.Size = new Size(212, 44);
            rtbKommunikation.TabIndex = 41;
            rtbKommunikation.Text = "";
            rtbKommunikation.TextChanged += rtbKommunikation_TextChanged;
            // 
            // rtbMa_Rolle
            // 
            rtbMa_Rolle.Location = new Point(108, 93);
            rtbMa_Rolle.Name = "rtbMa_Rolle";
            rtbMa_Rolle.Size = new Size(190, 35);
            rtbMa_Rolle.TabIndex = 39;
            rtbMa_Rolle.Text = "Rolle";
            // 
            // rtbAusbildungen
            // 
            rtbAusbildungen.BackColor = Color.Azure;
            rtbAusbildungen.Location = new Point(56, 224);
            rtbAusbildungen.Name = "rtbAusbildungen";
            rtbAusbildungen.ReadOnly = true;
            rtbAusbildungen.Size = new Size(247, 63);
            rtbAusbildungen.TabIndex = 36;
            rtbAusbildungen.Text = "Ausbildung Qualifikation, Institut, Jahr";
            // 
            // rtbMa_Schwerpunkte
            // 
            rtbMa_Schwerpunkte.BackColor = Color.Azure;
            rtbMa_Schwerpunkte.Location = new Point(334, 224);
            rtbMa_Schwerpunkte.Name = "rtbMa_Schwerpunkte";
            rtbMa_Schwerpunkte.Size = new Size(284, 61);
            rtbMa_Schwerpunkte.TabIndex = 35;
            rtbMa_Schwerpunkte.Text = "Schwerpunkte";
            // 
            // pbMaFoto
            // 
            pbMaFoto.Location = new Point(324, 17);
            pbMaFoto.Name = "pbMaFoto";
            pbMaFoto.Size = new Size(154, 164);
            pbMaFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbMaFoto.TabIndex = 6;
            pbMaFoto.TabStop = false;
            // 
            // cbNachname
            // 
            cbNachname.FormattingEnabled = true;
            cbNachname.Location = new Point(111, 17);
            cbNachname.Name = "cbNachname";
            cbNachname.Size = new Size(187, 33);
            cbNachname.TabIndex = 4;
            cbNachname.Text = "Mitarbeiter Name";
            cbNachname.SelectedIndexChanged += cbNachname_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 46;
            label1.Text = "nachname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 54);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 47;
            label2.Text = "vorname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 96);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 48;
            label3.Text = "rolle";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 196);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 50;
            label5.Text = "ausbildung";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 137);
            label6.Name = "label6";
            label6.Size = new Size(83, 25);
            label6.TabIndex = 51;
            label6.Text = "sprachen";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(324, 196);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 49;
            label4.Text = "schwerpunkte";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(79, 290);
            label7.Name = "label7";
            label7.Size = new Size(105, 25);
            label7.TabIndex = 52;
            label7.Text = "technologie";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(426, 288);
            label8.Name = "label8";
            label8.Size = new Size(87, 25);
            label8.TabIndex = 53;
            label8.Text = "projekten";
            // 
            // Profil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(640, 634);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEdit);
            Controls.Add(rtbVorname);
            Controls.Add(rtbKommunikation);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(rtbMa_Rolle);
            Controls.Add(skillsPanel);
            Controls.Add(rtbAusbildungen);
            Controls.Add(pbMaFoto);
            Controls.Add(rtbMa_Schwerpunkte);
            Controls.Add(cbNachname);
            Name = "Profil";
            Text = "Profil";
            FormClosed += Profil_FormClosed;
            Load += Profil_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMaFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbMaFoto;
        private Button btnEdit;
        private ComboBox cbNachname;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel skillsPanel;
        private RichTextBox rtbMa_Rolle;
        private RichTextBox rtbMa_Schwerpunkte;
        private RichTextBox rtbVorname;
        private RichTextBox rtbKommunikation;
        private RichTextBox rtbAusbildungen;
        private ListBox listboxinfo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label7;
        private Label label8;
    }
}