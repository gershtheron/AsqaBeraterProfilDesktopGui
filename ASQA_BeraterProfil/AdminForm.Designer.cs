namespace ASQA_BeraterProfil
{
    partial class AdminForm
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            btnSaveNewMitarbeiter = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            button8 = new Button();
            textBox6 = new TextBox();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightSteelBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(287, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(205, 198);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(btnSaveNewMitarbeiter);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(53, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 303);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Location = new Point(157, 201);
            button1.Name = "button1";
            button1.Size = new Size(111, 41);
            button1.TabIndex = 7;
            button1.Text = "Foto";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Location = new Point(41, 83);
            button2.Name = "button2";
            button2.Size = new Size(227, 38);
            button2.TabIndex = 6;
            button2.Text = "DELETE MITARBEITER";
            button2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(41, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(227, 33);
            comboBox1.TabIndex = 4;
            // 
            // btnSaveNewMitarbeiter
            // 
            btnSaveNewMitarbeiter.BackColor = Color.DarkKhaki;
            btnSaveNewMitarbeiter.Location = new Point(41, 201);
            btnSaveNewMitarbeiter.Name = "btnSaveNewMitarbeiter";
            btnSaveNewMitarbeiter.Size = new Size(111, 41);
            btnSaveNewMitarbeiter.TabIndex = 3;
            btnSaveNewMitarbeiter.Text = "Add New";
            btnSaveNewMitarbeiter.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(41, 164);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(227, 31);
            textBox2.TabIndex = 2;
            textBox2.Text = "Nachname";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 31);
            textBox1.TabIndex = 1;
            textBox1.Text = "Name";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(textBox6);
            panel2.Location = new Point(53, 367);
            panel2.Name = "panel2";
            panel2.Size = new Size(560, 142);
            panel2.TabIndex = 8;
            // 
            // button8
            // 
            button8.BackColor = Color.DarkKhaki;
            button8.Location = new Point(20, 63);
            button8.Name = "button8";
            button8.Size = new Size(108, 41);
            button8.TabIndex = 3;
            button8.Text = "Add New";
            button8.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(20, 26);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(108, 31);
            textBox6.TabIndex = 1;
            textBox6.Text = "KOMP_ID";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(134, 26);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(260, 85);
            dataGridView2.TabIndex = 8;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 1073);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminForm";
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private ComboBox comboBox1;
        private Button btnSaveNewMitarbeiter;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Panel panel2;
        private Button button8;
        private TextBox textBox6;
        private DataGridView dataGridView2;
    }
}