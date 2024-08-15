namespace ASQA_BeraterProfil
{
    partial class Projekt
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
            lbProjektMitarbeiter = new ListBox();
            dgvProjekten = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btnUpdateProjekt = new Button();
            cbProjekten = new ComboBox();
            btnDeleteProjekt = new Button();
            btnAddNewProjekt = new Button();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProjekten).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(lbProjektMitarbeiter);
            panel1.Controls.Add(dgvProjekten);
            panel1.Controls.Add(btnUpdateProjekt);
            panel1.Controls.Add(cbProjekten);
            panel1.Controls.Add(btnDeleteProjekt);
            panel1.Controls.Add(btnAddNewProjekt);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(27, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1279, 374);
            panel1.TabIndex = 0;
            // 
            // lbProjektMitarbeiter
            // 
            lbProjektMitarbeiter.FormattingEnabled = true;
            lbProjektMitarbeiter.ItemHeight = 25;
            lbProjektMitarbeiter.Location = new Point(23, 100);
            lbProjektMitarbeiter.Name = "lbProjektMitarbeiter";
            lbProjektMitarbeiter.Size = new Size(562, 179);
            lbProjektMitarbeiter.TabIndex = 53;
            // 
            // dgvProjekten
            // 
            dgvProjekten.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProjekten.BackgroundColor = Color.LightBlue;
            dgvProjekten.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjekten.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvProjekten.Location = new Point(591, 33);
            dgvProjekten.Name = "dgvProjekten";
            dgvProjekten.RowHeadersWidth = 62;
            dgvProjekten.Size = new Size(662, 297);
            dgvProjekten.TabIndex = 52;
            dgvProjekten.CellContentClick += dgvProjekten_CellContentClick;
            dgvProjekten.SelectionChanged += dgvProjekten_SelectionChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "Proj_id";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Projekt";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // btnUpdateProjekt
            // 
            btnUpdateProjekt.Location = new Point(450, 294);
            btnUpdateProjekt.Name = "btnUpdateProjekt";
            btnUpdateProjekt.Size = new Size(99, 36);
            btnUpdateProjekt.TabIndex = 51;
            btnUpdateProjekt.Text = "UPDATE";
            btnUpdateProjekt.UseVisualStyleBackColor = true;
            // 
            // cbProjekten
            // 
            cbProjekten.FormattingEnabled = true;
            cbProjekten.Location = new Point(200, 33);
            cbProjekten.Name = "cbProjekten";
            cbProjekten.Size = new Size(228, 33);
            cbProjekten.TabIndex = 49;
            // 
            // btnDeleteProjekt
            // 
            btnDeleteProjekt.Location = new Point(332, 294);
            btnDeleteProjekt.Name = "btnDeleteProjekt";
            btnDeleteProjekt.Size = new Size(96, 36);
            btnDeleteProjekt.TabIndex = 42;
            btnDeleteProjekt.Text = "DELETE";
            btnDeleteProjekt.UseVisualStyleBackColor = true;
            // 
            // btnAddNewProjekt
            // 
            btnAddNewProjekt.Location = new Point(102, 294);
            btnAddNewProjekt.Name = "btnAddNewProjekt";
            btnAddNewProjekt.Size = new Size(218, 36);
            btnAddNewProjekt.TabIndex = 41;
            btnAddNewProjekt.Text = "ADD NEW PROJEKT";
            btnAddNewProjekt.UseVisualStyleBackColor = true;
            btnAddNewProjekt.Click += button4_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(110, 33);
            label10.Name = "label10";
            label10.Size = new Size(86, 25);
            label10.TabIndex = 38;
            label10.Text = "PROJEKT ";
            // 
            // Projekt
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1327, 411);
            Controls.Add(panel1);
            Name = "Projekt";
            Text = "Projekt";
            FormClosed += Projekt_FormClosed;
            Load += Projekt_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProjekten).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label10;
        private ComboBox cbProjekten;
        private Button btnUpdateProjekt;
        private Button btnDeleteProjekt;
        private Button btnAddNewProjekt;
        private DataGridView dgvProjekten;
        private ListBox lbProjektMitarbeiter;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}