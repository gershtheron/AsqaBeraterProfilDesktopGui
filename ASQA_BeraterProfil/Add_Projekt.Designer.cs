namespace ASQA_BeraterProfil
{
    partial class Add_Projekt
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
            panel1 = new Panel();
            lbProjekten = new ListBox();
            tbAddProjektName = new TextBox();
            button3 = new Button();
            btnAddProjekt = new Button();
            label10 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(lbProjekten);
            panel1.Controls.Add(tbAddProjektName);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnAddProjekt);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(27, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 286);
            panel1.TabIndex = 0;
            // 
            // lbProjekten
            // 
            lbProjekten.FormattingEnabled = true;
            lbProjekten.ItemHeight = 25;
            lbProjekten.Location = new Point(24, 79);
            lbProjekten.Name = "lbProjekten";
            lbProjekten.Size = new Size(348, 129);
            lbProjekten.TabIndex = 62;
            // 
            // tbAddProjektName
            // 
            tbAddProjektName.Location = new Point(166, 19);
            tbAddProjektName.Name = "tbAddProjektName";
            tbAddProjektName.Size = new Size(210, 31);
            tbAddProjektName.TabIndex = 60;
            // 
            // button3
            // 
            button3.Location = new Point(137, 221);
            button3.Name = "button3";
            button3.Size = new Size(85, 36);
            button3.TabIndex = 55;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnAddProjekt
            // 
            btnAddProjekt.Location = new Point(40, 221);
            btnAddProjekt.Name = "btnAddProjekt";
            btnAddProjekt.Size = new Size(91, 36);
            btnAddProjekt.TabIndex = 54;
            btnAddProjekt.Text = "ADD";
            btnAddProjekt.UseVisualStyleBackColor = true;
            btnAddProjekt.Click += btnAddProjekt_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 19);
            label10.Name = "label10";
            label10.Size = new Size(136, 25);
            label10.TabIndex = 52;
            label10.Text = "PROJEKT NAME";
            // 
            // Add_Projekt
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(441, 316);
            Controls.Add(panel1);
            Name = "Add_Projekt";
            Text = "Add_Projekt";
            FormClosed += Add_Projekt_FormClosed;
            Load += Add_Projekt_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button btnAddProjekt;
        private Label label10;
        private TextBox tbAddProjektName;
        private ListBox lbProjekten;
    }
}