namespace ASQA_BeraterProfil
{
    partial class Ausbildung
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
            richTextBox1 = new RichTextBox();
            label9 = new Label();
            panel2 = new Panel();
            tbAusb_Jahr = new TextBox();
            tbInstitut = new TextBox();
            label3 = new Label();
            label1 = new Label();
            tbAusbildungName = new TextBox();
            dgvAusbildung = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnUpdateTech = new Button();
            btnDeleteTech = new Button();
            btnAddNewAusbildung = new Button();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAusbildung).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(503, 242);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(450, 112);
            richTextBox1.TabIndex = 65;
            richTextBox1.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(503, 214);
            label9.Name = "label9";
            label9.Size = new Size(118, 25);
            label9.TabIndex = 62;
            label9.Text = "Beschreibung";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Controls.Add(tbAusb_Jahr);
            panel2.Controls.Add(tbInstitut);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(richTextBox1);
            panel2.Controls.Add(tbAusbildungName);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(dgvAusbildung);
            panel2.Controls.Add(btnUpdateTech);
            panel2.Controls.Add(btnDeleteTech);
            panel2.Controls.Add(btnAddNewAusbildung);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(1072, 461);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // tbAusb_Jahr
            // 
            tbAusb_Jahr.Location = new Point(139, 66);
            tbAusb_Jahr.Name = "tbAusb_Jahr";
            tbAusb_Jahr.Size = new Size(210, 31);
            tbAusb_Jahr.TabIndex = 73;
            // 
            // tbInstitut
            // 
            tbInstitut.Location = new Point(139, 106);
            tbInstitut.Name = "tbInstitut";
            tbInstitut.Size = new Size(210, 31);
            tbInstitut.TabIndex = 72;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 106);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 71;
            label3.Text = "Institut";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 72);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 69;
            label1.Text = "Jahr";
            // 
            // tbAusbildungName
            // 
            tbAusbildungName.Location = new Point(139, 29);
            tbAusbildungName.Name = "tbAusbildungName";
            tbAusbildungName.Size = new Size(210, 31);
            tbAusbildungName.TabIndex = 67;
            // 
            // dgvAusbildung
            // 
            dgvAusbildung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAusbildung.BackgroundColor = Color.LightBlue;
            dgvAusbildung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAusbildung.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvAusbildung.Location = new Point(355, 26);
            dgvAusbildung.Name = "dgvAusbildung";
            dgvAusbildung.RowHeadersWidth = 62;
            dgvAusbildung.Size = new Size(693, 179);
            dgvAusbildung.TabIndex = 59;
            // 
            // Column1
            // 
            Column1.HeaderText = "Ausb_id";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Ausbildung";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Institut";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Jahr";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // btnUpdateTech
            // 
            btnUpdateTech.Location = new Point(168, 284);
            btnUpdateTech.Name = "btnUpdateTech";
            btnUpdateTech.Size = new Size(99, 36);
            btnUpdateTech.TabIndex = 54;
            btnUpdateTech.Text = "UPDATE";
            btnUpdateTech.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTech
            // 
            btnDeleteTech.Location = new Point(50, 284);
            btnDeleteTech.Name = "btnDeleteTech";
            btnDeleteTech.Size = new Size(96, 36);
            btnDeleteTech.TabIndex = 53;
            btnDeleteTech.Text = "DELETE";
            btnDeleteTech.UseVisualStyleBackColor = true;
            // 
            // btnAddNewAusbildung
            // 
            btnAddNewAusbildung.Location = new Point(49, 242);
            btnAddNewAusbildung.Name = "btnAddNewAusbildung";
            btnAddNewAusbildung.Size = new Size(218, 36);
            btnAddNewAusbildung.TabIndex = 52;
            btnAddNewAusbildung.Text = "ADD NEW AUSB";
            btnAddNewAusbildung.UseVisualStyleBackColor = true;
            btnAddNewAusbildung.Click += btnAddNewAusbildung_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 29);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 52;
            label2.Text = "Ausbildung";
            // 
            // Ausbildung
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1096, 512);
            Controls.Add(panel2);
            Name = "Ausbildung";
            Text = "Ausbildung";
            FormClosed += Ausbildung_FormClosed;
            Load += Ausbildung_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAusbildung).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox richTextBox1;
        private Label label9;
        private Panel panel2;
        private Label label1;
        private TextBox tbAusbildungName;
        private DataGridView dgvAusbildung;
        private Button btnUpdateTech;
        private Button btnDeleteTech;
        private Button btnAddNewAusbildung;
        private Label label2;
        private TextBox tbInstitut;
        private Label label3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox tbAusb_Jahr;
    }
}