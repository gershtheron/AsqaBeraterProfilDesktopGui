namespace ASQA_BeraterProfil
{
    partial class Add_Tech
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
            lbTech = new ListBox();
            tbAddTechName = new TextBox();
            button3 = new Button();
            btnAddNewTech = new Button();
            label10 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(lbTech);
            panel1.Controls.Add(tbAddTechName);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnAddNewTech);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(21, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 286);
            panel1.TabIndex = 1;
            // 
            // lbTech
            // 
            lbTech.FormattingEnabled = true;
            lbTech.ItemHeight = 25;
            lbTech.Location = new Point(28, 74);
            lbTech.Name = "lbTech";
            lbTech.Size = new Size(348, 129);
            lbTech.TabIndex = 61;
            // 
            // tbAddTechName
            // 
            tbAddTechName.Location = new Point(166, 19);
            tbAddTechName.Name = "tbAddTechName";
            tbAddTechName.Size = new Size(210, 31);
            tbAddTechName.TabIndex = 60;
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
            // btnAddNewTech
            // 
            btnAddNewTech.Location = new Point(40, 221);
            btnAddNewTech.Name = "btnAddNewTech";
            btnAddNewTech.Size = new Size(91, 36);
            btnAddNewTech.TabIndex = 54;
            btnAddNewTech.Text = "ADD";
            btnAddNewTech.UseVisualStyleBackColor = true;
            btnAddNewTech.Click += btnAddNewTech_Click;
            btnAddNewTech.KeyDown += btnAddNewTech_KeyDown;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(40, 19);
            label10.Name = "label10";
            label10.Size = new Size(109, 25);
            label10.TabIndex = 52;
            label10.Text = "TECH NAME";
            // 
            // Add_Tech
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(450, 335);
            Controls.Add(panel1);
            Name = "Add_Tech";
            Text = "Add_Tech";
            Load += Add_Tech_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox lbTech;
        private TextBox tbAddTechName;
        private Button button3;
        private Button btnAddNewTech;
        private Label label10;
    }
}