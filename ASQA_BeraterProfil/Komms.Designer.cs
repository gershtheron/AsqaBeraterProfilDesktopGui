namespace ASQA_BeraterProfil
{
    partial class Komms
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
            tbKomm_name = new TextBox();
            btnUpdateTech = new Button();
            btnDeleteTech = new Button();
            btnAddNewKomms = new Button();
            label2 = new Label();
            dgvKomms = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvKomms).BeginInit();
            SuspendLayout();
            // 
            // tbKomm_name
            // 
            tbKomm_name.Location = new Point(244, 29);
            tbKomm_name.Name = "tbKomm_name";
            tbKomm_name.Size = new Size(210, 31);
            tbKomm_name.TabIndex = 81;
            // 
            // btnUpdateTech
            // 
            btnUpdateTech.Location = new Point(355, 120);
            btnUpdateTech.Name = "btnUpdateTech";
            btnUpdateTech.Size = new Size(99, 36);
            btnUpdateTech.TabIndex = 77;
            btnUpdateTech.Text = "UPDATE";
            btnUpdateTech.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTech
            // 
            btnDeleteTech.Location = new Point(237, 120);
            btnDeleteTech.Name = "btnDeleteTech";
            btnDeleteTech.Size = new Size(96, 36);
            btnDeleteTech.TabIndex = 76;
            btnDeleteTech.Text = "DELETE";
            btnDeleteTech.UseVisualStyleBackColor = true;
            // 
            // btnAddNewKomms
            // 
            btnAddNewKomms.Location = new Point(236, 78);
            btnAddNewKomms.Name = "btnAddNewKomms";
            btnAddNewKomms.Size = new Size(218, 36);
            btnAddNewKomms.TabIndex = 74;
            btnAddNewKomms.Text = "ADD NEW KOMMS";
            btnAddNewKomms.UseVisualStyleBackColor = true;
            btnAddNewKomms.Click += btnAddNewKomms_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 29);
            label2.Name = "label2";
            label2.Size = new Size(213, 25);
            label2.TabIndex = 75;
            label2.Text = "Kommunikation/ Sprache";
            // 
            // dgvKomms
            // 
            dgvKomms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKomms.BackgroundColor = Color.LightBlue;
            dgvKomms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKomms.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvKomms.Location = new Point(471, 12);
            dgvKomms.Name = "dgvKomms";
            dgvKomms.RowHeadersWidth = 62;
            dgvKomms.Size = new Size(532, 179);
            dgvKomms.TabIndex = 78;
            // 
            // Column1
            // 
            Column1.HeaderText = "Komm_id";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Komm_name";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Komms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(1031, 212);
            Controls.Add(tbKomm_name);
            Controls.Add(dgvKomms);
            Controls.Add(btnUpdateTech);
            Controls.Add(btnDeleteTech);
            Controls.Add(btnAddNewKomms);
            Controls.Add(label2);
            Name = "Komms";
            Text = "Komms";
            FormClosed += Komms_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvKomms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbKomm_name;
        private Button btnUpdateTech;
        private Button btnDeleteTech;
        private Button btnAddNewKomms;
        private Label label2;
        private DataGridView dgvKomms;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}