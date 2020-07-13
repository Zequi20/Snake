namespace SnakeGame
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblDificultad = new System.Windows.Forms.Label();
            this.nDifi = new System.Windows.Forms.Label();
            this.tabControlPerfiles = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.npPerfil = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.mPerfil = new System.Windows.Forms.Label();
            this.tPerfil = new System.Windows.Forms.Label();
            this.pPerfil = new System.Windows.Forms.Label();
            this.nPerfil = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDirectorio = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tbCrearPerfil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.openProfile = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControlPerfiles.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(192, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "SNAKE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(10, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jugar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(11, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = "Salir";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(12, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 37);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ayuda";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(51, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 29);
            this.label10.TabIndex = 9;
            this.label10.Text = "Zona";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(303, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 29);
            this.label11.TabIndex = 10;
            this.label11.Text = "<1>";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblPerfil.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.ForeColor = System.Drawing.Color.DimGray;
            this.lblPerfil.Location = new System.Drawing.Point(11, 201);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(201, 37);
            this.lblPerfil.TabIndex = 11;
            this.lblPerfil.Text = "Perfiles";
            this.lblPerfil.Click += new System.EventHandler(this.label12_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(52, 125);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(179, 28);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Cuadricula";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblDificultad
            // 
            this.lblDificultad.AutoSize = true;
            this.lblDificultad.BackColor = System.Drawing.Color.Transparent;
            this.lblDificultad.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDificultad.ForeColor = System.Drawing.Color.White;
            this.lblDificultad.Location = new System.Drawing.Point(53, 207);
            this.lblDificultad.Name = "lblDificultad";
            this.lblDificultad.Size = new System.Drawing.Size(136, 21);
            this.lblDificultad.TabIndex = 15;
            this.lblDificultad.Text = "Velocidad";
            // 
            // nDifi
            // 
            this.nDifi.AutoSize = true;
            this.nDifi.BackColor = System.Drawing.Color.Transparent;
            this.nDifi.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nDifi.ForeColor = System.Drawing.Color.White;
            this.nDifi.Location = new System.Drawing.Point(303, 201);
            this.nDifi.Name = "nDifi";
            this.nDifi.Size = new System.Drawing.Size(67, 29);
            this.nDifi.TabIndex = 16;
            this.nDifi.Text = "<1>";
            this.nDifi.Click += new System.EventHandler(this.nDifi_Click);
            // 
            // tabControlPerfiles
            // 
            this.tabControlPerfiles.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlPerfiles.Controls.Add(this.tabPage2);
            this.tabControlPerfiles.Controls.Add(this.tabPage1);
            this.tabControlPerfiles.Controls.Add(this.tabPage3);
            this.tabControlPerfiles.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPerfiles.Location = new System.Drawing.Point(216, 129);
            this.tabControlPerfiles.Margin = new System.Windows.Forms.Padding(1);
            this.tabControlPerfiles.Name = "tabControlPerfiles";
            this.tabControlPerfiles.SelectedIndex = 0;
            this.tabControlPerfiles.Size = new System.Drawing.Size(409, 312);
            this.tabControlPerfiles.TabIndex = 17;
            this.tabControlPerfiles.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.npPerfil);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.mPerfil);
            this.tabPage2.Controls.Add(this.tPerfil);
            this.tabPage2.Controls.Add(this.pPerfil);
            this.tabPage2.Controls.Add(this.nPerfil);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.lblDirectorio);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(401, 282);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CargarPerfil";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(115, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "ExplorarPerfiles";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // npPerfil
            // 
            this.npPerfil.AutoSize = true;
            this.npPerfil.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npPerfil.Location = new System.Drawing.Point(262, 243);
            this.npPerfil.Name = "npPerfil";
            this.npPerfil.Size = new System.Drawing.Size(41, 16);
            this.npPerfil.TabIndex = 15;
            this.npPerfil.Text = "n/a";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 243);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(195, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "Partidas Jugadas:";
            // 
            // mPerfil
            // 
            this.mPerfil.AutoSize = true;
            this.mPerfil.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPerfil.Location = new System.Drawing.Point(262, 212);
            this.mPerfil.Name = "mPerfil";
            this.mPerfil.Size = new System.Drawing.Size(41, 16);
            this.mPerfil.TabIndex = 13;
            this.mPerfil.Text = "n/a";
            // 
            // tPerfil
            // 
            this.tPerfil.AutoSize = true;
            this.tPerfil.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPerfil.Location = new System.Drawing.Point(262, 183);
            this.tPerfil.Name = "tPerfil";
            this.tPerfil.Size = new System.Drawing.Size(41, 16);
            this.tPerfil.TabIndex = 12;
            this.tPerfil.Text = "n/a";
            // 
            // pPerfil
            // 
            this.pPerfil.AutoSize = true;
            this.pPerfil.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pPerfil.Location = new System.Drawing.Point(262, 153);
            this.pPerfil.Name = "pPerfil";
            this.pPerfil.Size = new System.Drawing.Size(41, 16);
            this.pPerfil.TabIndex = 11;
            this.pPerfil.Text = "n/a";
            // 
            // nPerfil
            // 
            this.nPerfil.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nPerfil.Location = new System.Drawing.Point(190, 110);
            this.nPerfil.Name = "nPerfil";
            this.nPerfil.Size = new System.Drawing.Size(211, 43);
            this.nPerfil.TabIndex = 10;
            this.nPerfil.Text = "n/a";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(82, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(234, 21);
            this.label13.TabIndex = 9;
            this.label13.Text = "Datos del perfil";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Menor Tiempo:";
            this.label12.Click += new System.EventHandler(this.label12_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mayor Tiempo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mayor Puntaje:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Jugador:";
            // 
            // lblDirectorio
            // 
            this.lblDirectorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDirectorio.BackColor = System.Drawing.Color.Transparent;
            this.lblDirectorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDirectorio.Font = new System.Drawing.Font("Lucida Console", 8F);
            this.lblDirectorio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDirectorio.Location = new System.Drawing.Point(181, 2);
            this.lblDirectorio.Name = "lblDirectorio";
            this.lblDirectorio.Size = new System.Drawing.Size(216, 64);
            this.lblDirectorio.TabIndex = 4;
            this.lblDirectorio.Text = "Directorio";
            this.lblDirectorio.Visible = false;
            this.lblDirectorio.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.tbCrearPerfil);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(401, 282);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CrearPerfil";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(287, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbCrearPerfil
            // 
            this.tbCrearPerfil.Location = new System.Drawing.Point(141, 49);
            this.tbCrearPerfil.Name = "tbCrearPerfil";
            this.tbCrearPerfil.Size = new System.Drawing.Size(221, 20);
            this.tbCrearPerfil.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.nDifi);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.lblDificultad);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.ForeColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(401, 282);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dificultad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(11, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 37);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tablero";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControlPerfiles);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tabControlPerfiles.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblDificultad;
        private System.Windows.Forms.Label nDifi;
        private System.Windows.Forms.TabControl tabControlPerfiles;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbCrearPerfil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openProfile;
        private System.Windows.Forms.Label lblDirectorio;
        private System.Windows.Forms.Label mPerfil;
        private System.Windows.Forms.Label tPerfil;
        private System.Windows.Forms.Label pPerfil;
        private System.Windows.Forms.Label nPerfil;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label npPerfil;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
    }
}