namespace SnakeGame
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.lbl_pausa = new System.Windows.Forms.Label();
            this.lbl_over = new System.Windows.Forms.Label();
            this.dif = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.puntos = new System.Windows.Forms.Label();
            this.tJuego = new System.Windows.Forms.Timer(this.components);
            this.lblT = new System.Windows.Forms.Label();
            this.TimeShow = new System.Windows.Forms.Label();
            this.pMenu = new System.Windows.Forms.Label();
            this.pSalir = new System.Windows.Forms.Label();
            this.Help = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nZona = new System.Windows.Forms.Label();
            this.Jugador = new System.Windows.Forms.Label();
            this.screen = new System.Windows.Forms.PictureBox();
            this.TiempoL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puntaje:";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(335, 3);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(19, 16);
            this.score.TabIndex = 2;
            this.score.Text = "0";
            // 
            // time
            // 
            this.time.Enabled = true;
            this.time.Interval = 80;
            this.time.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_pausa
            // 
            this.lbl_pausa.AutoSize = true;
            this.lbl_pausa.BackColor = System.Drawing.Color.Black;
            this.lbl_pausa.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pausa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_pausa.Location = new System.Drawing.Point(417, 3);
            this.lbl_pausa.Name = "lbl_pausa";
            this.lbl_pausa.Size = new System.Drawing.Size(205, 24);
            this.lbl_pausa.TabIndex = 4;
            this.lbl_pausa.Text = "Juego pausado";
            this.lbl_pausa.Visible = false;
            // 
            // lbl_over
            // 
            this.lbl_over.AutoSize = true;
            this.lbl_over.BackColor = System.Drawing.Color.Black;
            this.lbl_over.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_over.Font = new System.Drawing.Font("Lucida Console", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_over.ForeColor = System.Drawing.Color.LightYellow;
            this.lbl_over.Location = new System.Drawing.Point(205, 175);
            this.lbl_over.Name = "lbl_over";
            this.lbl_over.Size = new System.Drawing.Size(213, 35);
            this.lbl_over.TabIndex = 5;
            this.lbl_over.Text = "Game Over";
            this.lbl_over.Visible = false;
            this.lbl_over.Click += new System.EventHandler(this.lbl_over_Click);
            // 
            // dif
            // 
            this.dif.AutoSize = true;
            this.dif.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dif.Location = new System.Drawing.Point(592, 422);
            this.dif.Name = "dif";
            this.dif.Size = new System.Drawing.Size(16, 13);
            this.dif.TabIndex = 6;
            this.dif.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 11);
            this.label2.TabIndex = 7;
            this.label2.Text = "Velocidad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // puntos
            // 
            this.puntos.AutoSize = true;
            this.puntos.BackColor = System.Drawing.Color.Black;
            this.puntos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.puntos.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntos.ForeColor = System.Drawing.Color.LightYellow;
            this.puntos.Location = new System.Drawing.Point(2, 151);
            this.puntos.Name = "puntos";
            this.puntos.Size = new System.Drawing.Size(108, 21);
            this.puntos.TabIndex = 8;
            this.puntos.Text = "Puntaje";
            this.puntos.Visible = false;
            this.puntos.Click += new System.EventHandler(this.puntos_Click);
            // 
            // tJuego
            // 
            this.tJuego.Interval = 990;
            this.tJuego.Tick += new System.EventHandler(this.tJuego_Tick);
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.BackColor = System.Drawing.Color.Black;
            this.lblT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblT.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.ForeColor = System.Drawing.Color.LightYellow;
            this.lblT.Location = new System.Drawing.Point(2, 220);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(0, 19);
            this.lblT.TabIndex = 9;
            this.lblT.Visible = false;
            this.lblT.Click += new System.EventHandler(this.lblT_Click);
            // 
            // TimeShow
            // 
            this.TimeShow.AutoSize = true;
            this.TimeShow.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeShow.Location = new System.Drawing.Point(79, 421);
            this.TimeShow.Name = "TimeShow";
            this.TimeShow.Size = new System.Drawing.Size(34, 13);
            this.TimeShow.TabIndex = 10;
            this.TimeShow.Text = "0:0";
            this.TimeShow.Click += new System.EventHandler(this.TimeShow_Click);
            // 
            // pMenu
            // 
            this.pMenu.AutoSize = true;
            this.pMenu.BackColor = System.Drawing.Color.Black;
            this.pMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pMenu.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pMenu.ForeColor = System.Drawing.Color.LightYellow;
            this.pMenu.Location = new System.Drawing.Point(462, 151);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(160, 24);
            this.pMenu.TabIndex = 11;
            this.pMenu.Text = "Ir al Menu";
            this.pMenu.Visible = false;
            this.pMenu.Click += new System.EventHandler(this.pMenu_Click);
            // 
            // pSalir
            // 
            this.pSalir.AutoSize = true;
            this.pSalir.BackColor = System.Drawing.Color.Black;
            this.pSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pSalir.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pSalir.ForeColor = System.Drawing.Color.LightYellow;
            this.pSalir.Location = new System.Drawing.Point(542, 220);
            this.pSalir.Name = "pSalir";
            this.pSalir.Size = new System.Drawing.Size(80, 24);
            this.pSalir.TabIndex = 12;
            this.pSalir.Text = "Salir";
            this.pSalir.Visible = false;
            this.pSalir.Click += new System.EventHandler(this.pSalir_Click);
            // 
            // Help
            // 
            this.Help.AutoSize = true;
            this.Help.BackColor = System.Drawing.Color.Black;
            this.Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help.ForeColor = System.Drawing.Color.LightYellow;
            this.Help.Location = new System.Drawing.Point(532, 87);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(85, 24);
            this.Help.TabIndex = 13;
            this.Help.Text = "Ayuda";
            this.Help.Visible = false;
            this.Help.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Zona";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nZona
            // 
            this.nZona.AutoSize = true;
            this.nZona.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nZona.Location = new System.Drawing.Point(335, 421);
            this.nZona.Name = "nZona";
            this.nZona.Size = new System.Drawing.Size(16, 13);
            this.nZona.TabIndex = 16;
            this.nZona.Text = "1";
            this.nZona.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Jugador
            // 
            this.Jugador.AutoSize = true;
            this.Jugador.BackColor = System.Drawing.Color.Black;
            this.Jugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Jugador.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Bold);
            this.Jugador.ForeColor = System.Drawing.Color.LightYellow;
            this.Jugador.Location = new System.Drawing.Point(4, 7);
            this.Jugador.Name = "Jugador";
            this.Jugador.Size = new System.Drawing.Size(61, 11);
            this.Jugador.TabIndex = 17;
            this.Jugador.Text = "Default";
            this.Jugador.Click += new System.EventHandler(this.Jugador_Click);
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.Black;
            this.screen.Cursor = System.Windows.Forms.Cursors.Default;
            this.screen.Location = new System.Drawing.Point(2, 25);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(620, 390);
            this.screen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.screen.TabIndex = 0;
            this.screen.TabStop = false;
            this.screen.Click += new System.EventHandler(this.screen_Click);
            // 
            // TiempoL
            // 
            this.TiempoL.AutoSize = true;
            this.TiempoL.BackColor = System.Drawing.Color.Black;
            this.TiempoL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TiempoL.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TiempoL.ForeColor = System.Drawing.Color.LightYellow;
            this.TiempoL.Location = new System.Drawing.Point(542, 391);
            this.TiempoL.Name = "TiempoL";
            this.TiempoL.Size = new System.Drawing.Size(80, 24);
            this.TiempoL.TabIndex = 18;
            this.TiempoL.Text = "Salir";
            this.TiempoL.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tiempo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_pausa);
            this.Controls.Add(this.pSalir);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.lbl_over);
            this.Controls.Add(this.puntos);
            this.Controls.Add(this.TiempoL);
            this.Controls.Add(this.Jugador);
            this.Controls.Add(this.nZona);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TimeShow);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dif);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.screen);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.screen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox screen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Label lbl_pausa;
        private System.Windows.Forms.Label lbl_over;
        public System.Windows.Forms.Label dif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label puntos;
        private System.Windows.Forms.Timer tJuego;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label TimeShow;
        private System.Windows.Forms.Label pMenu;
        private System.Windows.Forms.Label pSalir;
        private System.Windows.Forms.Label Help;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label nZona;
        public System.Windows.Forms.Label Jugador;
        private System.Windows.Forms.Label TiempoL;
        private System.Windows.Forms.Label label3;
    }
}

