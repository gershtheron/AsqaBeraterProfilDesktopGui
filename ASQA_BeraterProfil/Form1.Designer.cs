namespace ASQA_BeraterProfil
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnProfil = new Button();
            btnTech = new Button();
            btnProjekt = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnProfil
            // 
            btnProfil.AutoSize = true;
            btnProfil.BackColor = Color.SkyBlue;
            btnProfil.FlatAppearance.BorderSize = 5;
            btnProfil.FlatAppearance.MouseDownBackColor = Color.SkyBlue;
            btnProfil.FlatAppearance.MouseOverBackColor = Color.PowderBlue;
            btnProfil.FlatStyle = FlatStyle.Popup;
            btnProfil.Font = new Font("Cooper Black", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfil.Location = new Point(22, 393);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(158, 78);
            btnProfil.TabIndex = 0;
            btnProfil.Text = "PROFIL";
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += button1_Click;
            // 
            // btnTech
            // 
            btnTech.AutoSize = true;
            btnTech.BackColor = Color.SkyBlue;
            btnTech.FlatAppearance.BorderSize = 5;
            btnTech.FlatAppearance.MouseDownBackColor = Color.SkyBlue;
            btnTech.FlatAppearance.MouseOverBackColor = Color.PowderBlue;
            btnTech.FlatStyle = FlatStyle.Popup;
            btnTech.Font = new Font("Cooper Black", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTech.Location = new Point(390, 393);
            btnTech.Name = "btnTech";
            btnTech.Size = new Size(154, 78);
            btnTech.TabIndex = 2;
            btnTech.Text = "TECH";
            btnTech.UseVisualStyleBackColor = false;
            btnTech.Click += btnTech_Click;
            // 
            // btnProjekt
            // 
            btnProjekt.AutoSize = true;
            btnProjekt.BackColor = Color.SkyBlue;
            btnProjekt.FlatAppearance.BorderSize = 5;
            btnProjekt.FlatAppearance.MouseDownBackColor = Color.SkyBlue;
            btnProjekt.FlatAppearance.MouseOverBackColor = Color.PowderBlue;
            btnProjekt.FlatStyle = FlatStyle.Popup;
            btnProjekt.Font = new Font("Cooper Black", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProjekt.Location = new Point(207, 393);
            btnProjekt.Name = "btnProjekt";
            btnProjekt.Size = new Size(167, 78);
            btnProjekt.TabIndex = 1;
            btnProjekt.Text = "PROJEKT";
            btnProjekt.UseVisualStyleBackColor = false;
            btnProjekt.Click += btnProjekt_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(572, 380);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnProfil);
            panel2.Controls.Add(btnProjekt);
            panel2.Controls.Add(btnTech);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(575, 492);
            panel2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(600, 520);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnProfil;
        private Button btnTech;
        private Button btnProjekt;
        private PictureBox pictureBox1;
        private Panel panel2;
    }
}
