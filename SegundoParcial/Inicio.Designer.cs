namespace SegundoParcial
{
    partial class Inicio
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
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbwelcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelInicio = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnSearchCity = new System.Windows.Forms.Button();
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.lbAddCity = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.panelDataGreed = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridViewCities = new System.Windows.Forms.DataGridView();
            this.panelCityForechast = new System.Windows.Forms.Panel();
            this.lbCity = new System.Windows.Forms.Label();
            this.dataGridViewCityForechast = new System.Windows.Forms.DataGridView();
            this.btnForechast = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelInicio.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelDataGreed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).BeginInit();
            this.panelCityForechast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCityForechast)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(144, 13);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(0, 22);
            this.lbUsername.TabIndex = 0;
            // 
            // lbwelcome
            // 
            this.lbwelcome.AutoSize = true;
            this.lbwelcome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbwelcome.Location = new System.Drawing.Point(26, 13);
            this.lbwelcome.Name = "lbwelcome";
            this.lbwelcome.Size = new System.Drawing.Size(94, 22);
            this.lbwelcome.TabIndex = 1;
            this.lbwelcome.Text = "Welcome";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.89076F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(800, 108);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(675, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "LOG OUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SegundoParcial.Properties.Resources.perfil;
            this.pictureBox1.Location = new System.Drawing.Point(128, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelInicio
            // 
            this.panelInicio.BackColor = System.Drawing.Color.Navy;
            this.panelInicio.Controls.Add(this.panelSearch);
            this.panelInicio.Controls.Add(this.lbAddCity);
            this.panelInicio.Controls.Add(this.pictureBox3);
            this.panelInicio.Controls.Add(this.pictureBox2);
            this.panelInicio.Controls.Add(this.btnAddCity);
            this.panelInicio.Location = new System.Drawing.Point(30, 114);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(735, 324);
            this.panelInicio.TabIndex = 3;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.Lime;
            this.panelSearch.Controls.Add(this.btnSearchCity);
            this.panelSearch.Controls.Add(this.comboBoxCities);
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(720, 324);
            this.panelSearch.TabIndex = 4;
            // 
            // btnSearchCity
            // 
            this.btnSearchCity.Image = global::SegundoParcial.Properties.Resources.buscar;
            this.btnSearchCity.Location = new System.Drawing.Point(317, 79);
            this.btnSearchCity.Name = "btnSearchCity";
            this.btnSearchCity.Size = new System.Drawing.Size(234, 161);
            this.btnSearchCity.TabIndex = 1;
            this.btnSearchCity.UseVisualStyleBackColor = true;
            this.btnSearchCity.Click += new System.EventHandler(this.BtnSearchCity_Click);
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.96639F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Items.AddRange(new object[] {
            "Afghanistan",
            "Algeria",
            "Andorra",
            "Rome"});
            this.comboBoxCities.Location = new System.Drawing.Point(53, 79);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(268, 46);
            this.comboBoxCities.TabIndex = 0;
            this.comboBoxCities.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // lbAddCity
            // 
            this.lbAddCity.AutoSize = true;
            this.lbAddCity.BackColor = System.Drawing.Color.DarkOrange;
            this.lbAddCity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.91597F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddCity.Location = new System.Drawing.Point(302, 69);
            this.lbAddCity.Name = "lbAddCity";
            this.lbAddCity.Size = new System.Drawing.Size(127, 28);
            this.lbAddCity.TabIndex = 3;
            this.lbAddCity.Text = "ADD CITY";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SegundoParcial.Properties.Resources.lluvia;
            this.pictureBox3.Location = new System.Drawing.Point(475, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(211, 240);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SegundoParcial.Properties.Resources.sol;
            this.pictureBox2.Location = new System.Drawing.Point(53, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnAddCity
            // 
            this.btnAddCity.Image = global::SegundoParcial.Properties.Resources.icono1;
            this.btnAddCity.Location = new System.Drawing.Point(284, 99);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(155, 157);
            this.btnAddCity.TabIndex = 0;
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panelDataGreed
            // 
            this.panelDataGreed.Controls.Add(this.btnForechast);
            this.panelDataGreed.Controls.Add(this.btnExit);
            this.panelDataGreed.Controls.Add(this.dataGridViewCities);
            this.panelDataGreed.Location = new System.Drawing.Point(28, 114);
            this.panelDataGreed.Name = "panelDataGreed";
            this.panelDataGreed.Size = new System.Drawing.Size(708, 324);
            this.panelDataGreed.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.Location = new System.Drawing.Point(574, 30);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 65);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.Button2_Click);
            // 
            // dataGridViewCities
            // 
            this.dataGridViewCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCities.Location = new System.Drawing.Point(55, 30);
            this.dataGridViewCities.Name = "dataGridViewCities";
            this.dataGridViewCities.RowTemplate.Height = 24;
            this.dataGridViewCities.Size = new System.Drawing.Size(487, 260);
            this.dataGridViewCities.TabIndex = 0;
            // 
            // panelCityForechast
            // 
            this.panelCityForechast.BackColor = System.Drawing.Color.Yellow;
            this.panelCityForechast.Controls.Add(this.dataGridViewCityForechast);
            this.panelCityForechast.Controls.Add(this.lbCity);
            this.panelCityForechast.Location = new System.Drawing.Point(28, 114);
            this.panelCityForechast.Name = "panelCityForechast";
            this.panelCityForechast.Size = new System.Drawing.Size(688, 324);
            this.panelCityForechast.TabIndex = 2;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.20168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCity.Location = new System.Drawing.Point(17, 17);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(134, 48);
            this.lbCity.TabIndex = 0;
            this.lbCity.Text = "Rome";
            this.lbCity.Click += new System.EventHandler(this.Label1_Click);
            // 
            // dataGridViewCityForechast
            // 
            this.dataGridViewCityForechast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCityForechast.Location = new System.Drawing.Point(55, 90);
            this.dataGridViewCityForechast.Name = "dataGridViewCityForechast";
            this.dataGridViewCityForechast.RowTemplate.Height = 24;
            this.dataGridViewCityForechast.Size = new System.Drawing.Size(594, 200);
            this.dataGridViewCityForechast.TabIndex = 1;
            this.dataGridViewCityForechast.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCityForechast_CellContentClick);
            // 
            // btnForechast
            // 
            this.btnForechast.BackColor = System.Drawing.Color.Lime;
            this.btnForechast.Location = new System.Drawing.Point(574, 120);
            this.btnForechast.Name = "btnForechast";
            this.btnForechast.Size = new System.Drawing.Size(82, 60);
            this.btnForechast.TabIndex = 2;
            this.btnForechast.Text = "Forechast";
            this.btnForechast.UseVisualStyleBackColor = false;
            this.btnForechast.Click += new System.EventHandler(this.BtnForechast_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCityForechast);
            this.Controls.Add(this.panelDataGreed);
            this.Controls.Add(this.panelInicio);
            this.Controls.Add(this.lbwelcome);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelInicio.ResumeLayout(false);
            this.panelInicio.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelDataGreed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).EndInit();
            this.panelCityForechast.ResumeLayout(false);
            this.panelCityForechast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCityForechast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbwelcome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbAddCity;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button btnSearchCity;
        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelDataGreed;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridViewCities;
        private System.Windows.Forms.Panel panelCityForechast;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.DataGridView dataGridViewCityForechast;
        private System.Windows.Forms.Button btnForechast;
    }
}