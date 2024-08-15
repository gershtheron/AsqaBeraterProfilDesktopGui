namespace ASQA_BeraterProfil
{
    partial class Tech
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
            lbTechMitarbeiter = new ListBox();
            dgvTech = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btnUpdateTech = new Button();
            btnDeleteTech = new Button();
            cbTech = new ComboBox();
            btnAddNewTech = new Button();
            label10 = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTech).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(lbTechMitarbeiter);
            panel1.Controls.Add(dgvTech);
            panel1.Controls.Add(btnUpdateTech);
            panel1.Controls.Add(btnDeleteTech);
            panel1.Controls.Add(cbTech);
            panel1.Controls.Add(btnAddNewTech);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1266, 354);
            panel1.TabIndex = 0;
            // 
            // lbTechMitarbeiter
            // 
            lbTechMitarbeiter.FormattingEnabled = true;
            lbTechMitarbeiter.ItemHeight = 25;
            lbTechMitarbeiter.Location = new Point(30, 82);
            lbTechMitarbeiter.Name = "lbTechMitarbeiter";
            lbTechMitarbeiter.Size = new Size(589, 179);
            lbTechMitarbeiter.TabIndex = 60;
            // 
            // dgvTech
            // 
            dgvTech.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTech.BackgroundColor = Color.LightBlue;
            dgvTech.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTech.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvTech.Location = new Point(651, 26);
            dgvTech.Name = "dgvTech";
            dgvTech.RowHeadersWidth = 62;
            dgvTech.Size = new Size(591, 294);
            dgvTech.TabIndex = 59;
            dgvTech.CellContentClick += dgvTech_CellContentClick;
            dgvTech.SelectionChanged += dgvTech_SelectionChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tech_id";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "TECH";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // btnUpdateTech
            // 
            btnUpdateTech.Location = new Point(520, 284);
            btnUpdateTech.Name = "btnUpdateTech";
            btnUpdateTech.Size = new Size(99, 36);
            btnUpdateTech.TabIndex = 54;
            btnUpdateTech.Text = "UPDATE";
            btnUpdateTech.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTech
            // 
            btnDeleteTech.Location = new Point(418, 284);
            btnDeleteTech.Name = "btnDeleteTech";
            btnDeleteTech.Size = new Size(96, 36);
            btnDeleteTech.TabIndex = 53;
            btnDeleteTech.Text = "DELETE";
            btnDeleteTech.UseVisualStyleBackColor = true;
            // 
            // cbTech
            // 
            cbTech.FormattingEnabled = true;
            cbTech.Location = new Point(109, 26);
            cbTech.Name = "cbTech";
            cbTech.Size = new Size(228, 33);
            cbTech.TabIndex = 57;
            // 
            // btnAddNewTech
            // 
            btnAddNewTech.Location = new Point(49, 284);
            btnAddNewTech.Name = "btnAddNewTech";
            btnAddNewTech.Size = new Size(218, 36);
            btnAddNewTech.TabIndex = 52;
            btnAddNewTech.Text = "ADD NEW TECH";
            btnAddNewTech.UseVisualStyleBackColor = true;
            btnAddNewTech.Click += btnAddNewTech_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(49, 29);
            label10.Name = "label10";
            label10.Size = new Size(54, 25);
            label10.TabIndex = 52;
            label10.Text = "TECH";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Tech
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1319, 387);
            Controls.Add(panel1);
            Name = "Tech";
            Text = "Tech";
            FormClosed += Tech_FormClosed;
            Load += Tech_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTech).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cbTech;
        private Label label10;
        private Button btnUpdateTech;
        private Button btnDeleteTech;
        private Button btnAddNewTech;
        private DataGridView dgvTech;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private ListBox lbTechMitarbeiter;
        private FileSystemWatcher fileSystemWatcher1;
    }
}