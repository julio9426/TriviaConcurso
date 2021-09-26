
namespace TriviaConcurso
{
    partial class Jugar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jugar));
            this.JugadorGroup = new System.Windows.Forms.GroupBox();
            this.NuevoUsuario = new System.Windows.Forms.Button();
            this.IdentificacionTxt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Jugandolbl = new System.Windows.Forms.Label();
            this.MenuJuegoGrp = new System.Windows.Forms.GroupBox();
            this.IniciarOpt = new System.Windows.Forms.LinkLabel();
            this.SalirOpt = new System.Windows.Forms.LinkLabel();
            this.SiguienteOpt = new System.Windows.Forms.LinkLabel();
            this.JuegoGrp = new System.Windows.Forms.GroupBox();
            this.CategoriaTxt = new System.Windows.Forms.Label();
            this.RespuestasList = new System.Windows.Forms.ListBox();
            this.CategoriasList = new System.Windows.Forms.ListBox();
            this.PreguntaTxt = new System.Windows.Forms.Label();
            this.PuntajeTxt = new System.Windows.Forms.Label();
            this.RondaTxt = new System.Windows.Forms.Label();
            this.JugadorGroup.SuspendLayout();
            this.MenuJuegoGrp.SuspendLayout();
            this.JuegoGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // JugadorGroup
            // 
            this.JugadorGroup.BackColor = System.Drawing.SystemColors.Desktop;
            this.JugadorGroup.Controls.Add(this.NuevoUsuario);
            this.JugadorGroup.Controls.Add(this.IdentificacionTxt);
            this.JugadorGroup.Controls.Add(this.label2);
            this.JugadorGroup.Controls.Add(this.NombreTxt);
            this.JugadorGroup.Controls.Add(this.label1);
            this.JugadorGroup.ForeColor = System.Drawing.SystemColors.Menu;
            this.JugadorGroup.Location = new System.Drawing.Point(389, 273);
            this.JugadorGroup.Name = "JugadorGroup";
            this.JugadorGroup.Size = new System.Drawing.Size(582, 181);
            this.JugadorGroup.TabIndex = 0;
            this.JugadorGroup.TabStop = false;
            this.JugadorGroup.Text = "Informacion Jugador";
            // 
            // NuevoUsuario
            // 
            this.NuevoUsuario.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.NuevoUsuario.Location = new System.Drawing.Point(440, 119);
            this.NuevoUsuario.Name = "NuevoUsuario";
            this.NuevoUsuario.Size = new System.Drawing.Size(114, 23);
            this.NuevoUsuario.TabIndex = 4;
            this.NuevoUsuario.Text = "Continuar";
            this.NuevoUsuario.UseVisualStyleBackColor = true;
            this.NuevoUsuario.Click += new System.EventHandler(this.NuevoUsuario_Click);
            // 
            // IdentificacionTxt
            // 
            this.IdentificacionTxt.Location = new System.Drawing.Point(152, 90);
            this.IdentificacionTxt.Mask = "0000000000";
            this.IdentificacionTxt.Name = "IdentificacionTxt";
            this.IdentificacionTxt.Size = new System.Drawing.Size(402, 23);
            this.IdentificacionTxt.TabIndex = 3;
            this.IdentificacionTxt.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identificacion";
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(152, 60);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(402, 23);
            this.NombreTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // Jugandolbl
            // 
            this.Jugandolbl.AutoSize = true;
            this.Jugandolbl.BackColor = System.Drawing.SystemColors.Desktop;
            this.Jugandolbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Jugandolbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Jugandolbl.Location = new System.Drawing.Point(109, 154);
            this.Jugandolbl.Name = "Jugandolbl";
            this.Jugandolbl.Size = new System.Drawing.Size(2, 34);
            this.Jugandolbl.TabIndex = 1;
            // 
            // MenuJuegoGrp
            // 
            this.MenuJuegoGrp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuJuegoGrp.BackColor = System.Drawing.SystemColors.ControlText;
            this.MenuJuegoGrp.Controls.Add(this.IniciarOpt);
            this.MenuJuegoGrp.Controls.Add(this.SalirOpt);
            this.MenuJuegoGrp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MenuJuegoGrp.Location = new System.Drawing.Point(109, 273);
            this.MenuJuegoGrp.Name = "MenuJuegoGrp";
            this.MenuJuegoGrp.Size = new System.Drawing.Size(244, 226);
            this.MenuJuegoGrp.TabIndex = 2;
            this.MenuJuegoGrp.TabStop = false;
            this.MenuJuegoGrp.Text = "MENU JUEGO";
            // 
            // IniciarOpt
            // 
            this.IniciarOpt.AutoSize = true;
            this.IniciarOpt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IniciarOpt.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IniciarOpt.LinkColor = System.Drawing.Color.White;
            this.IniciarOpt.Location = new System.Drawing.Point(79, 38);
            this.IniciarOpt.Name = "IniciarOpt";
            this.IniciarOpt.Size = new System.Drawing.Size(87, 29);
            this.IniciarOpt.TabIndex = 1;
            this.IniciarOpt.TabStop = true;
            this.IniciarOpt.Text = "INICIAR";
            this.IniciarOpt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IniciarOpt_LinkClicked);
            // 
            // SalirOpt
            // 
            this.SalirOpt.AutoSize = true;
            this.SalirOpt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SalirOpt.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalirOpt.LinkColor = System.Drawing.Color.White;
            this.SalirOpt.Location = new System.Drawing.Point(79, 91);
            this.SalirOpt.Name = "SalirOpt";
            this.SalirOpt.Size = new System.Drawing.Size(70, 29);
            this.SalirOpt.TabIndex = 0;
            this.SalirOpt.TabStop = true;
            this.SalirOpt.Text = "SALIR";
            this.SalirOpt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SalirOpt_LinkClicked);
            // 
            // SiguienteOpt
            // 
            this.SiguienteOpt.AutoSize = true;
            this.SiguienteOpt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SiguienteOpt.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SiguienteOpt.LinkColor = System.Drawing.Color.White;
            this.SiguienteOpt.Location = new System.Drawing.Point(225, 198);
            this.SiguienteOpt.Name = "SiguienteOpt";
            this.SiguienteOpt.Size = new System.Drawing.Size(230, 29);
            this.SiguienteOpt.TabIndex = 1;
            this.SiguienteOpt.TabStop = true;
            this.SiguienteOpt.Text = "Siguiente pregunta";
            // 
            // JuegoGrp
            // 
            this.JuegoGrp.BackColor = System.Drawing.SystemColors.ControlText;
            this.JuegoGrp.Controls.Add(this.CategoriaTxt);
            this.JuegoGrp.Controls.Add(this.RespuestasList);
            this.JuegoGrp.Controls.Add(this.CategoriasList);
            this.JuegoGrp.Controls.Add(this.SiguienteOpt);
            this.JuegoGrp.Controls.Add(this.PreguntaTxt);
            this.JuegoGrp.Controls.Add(this.PuntajeTxt);
            this.JuegoGrp.Controls.Add(this.RondaTxt);
            this.JuegoGrp.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.JuegoGrp.Location = new System.Drawing.Point(389, 227);
            this.JuegoGrp.Name = "JuegoGrp";
            this.JuegoGrp.Size = new System.Drawing.Size(798, 288);
            this.JuegoGrp.TabIndex = 3;
            this.JuegoGrp.TabStop = false;
            this.JuegoGrp.Text = "Tablero de Juego";
            this.JuegoGrp.Visible = false;
            // 
            // CategoriaTxt
            // 
            this.CategoriaTxt.AutoSize = true;
            this.CategoriaTxt.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoriaTxt.Location = new System.Drawing.Point(152, 46);
            this.CategoriaTxt.Name = "CategoriaTxt";
            this.CategoriaTxt.Size = new System.Drawing.Size(151, 30);
            this.CategoriaTxt.TabIndex = 7;
            this.CategoriaTxt.Text = "CATEGORIA:";
            // 
            // RespuestasList
            // 
            this.RespuestasList.BackColor = System.Drawing.SystemColors.ControlText;
            this.RespuestasList.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RespuestasList.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.RespuestasList.FormattingEnabled = true;
            this.RespuestasList.ItemHeight = 27;
            this.RespuestasList.Location = new System.Drawing.Point(158, 106);
            this.RespuestasList.Name = "RespuestasList";
            this.RespuestasList.Size = new System.Drawing.Size(424, 166);
            this.RespuestasList.TabIndex = 6;
            this.RespuestasList.Visible = false;
            this.RespuestasList.SelectedIndexChanged += new System.EventHandler(this.RespuestasList_SelectedIndexChanged);
            // 
            // CategoriasList
            // 
            this.CategoriasList.BackColor = System.Drawing.SystemColors.ControlText;
            this.CategoriasList.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoriasList.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.CategoriasList.FormattingEnabled = true;
            this.CategoriasList.ItemHeight = 27;
            this.CategoriasList.Location = new System.Drawing.Point(152, 106);
            this.CategoriasList.Name = "CategoriasList";
            this.CategoriasList.Size = new System.Drawing.Size(424, 166);
            this.CategoriasList.TabIndex = 5;
            this.CategoriasList.SelectedIndexChanged += new System.EventHandler(this.CategoriasList_SelectedIndexChanged);
            // 
            // PreguntaTxt
            // 
            this.PreguntaTxt.AutoSize = true;
            this.PreguntaTxt.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PreguntaTxt.Location = new System.Drawing.Point(152, 37);
            this.PreguntaTxt.Name = "PreguntaTxt";
            this.PreguntaTxt.Size = new System.Drawing.Size(116, 23);
            this.PreguntaTxt.TabIndex = 4;
            this.PreguntaTxt.Text = "PREGUNTA:";
            this.PreguntaTxt.Visible = false;
            // 
            // PuntajeTxt
            // 
            this.PuntajeTxt.AutoSize = true;
            this.PuntajeTxt.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PuntajeTxt.Location = new System.Drawing.Point(588, 30);
            this.PuntajeTxt.Name = "PuntajeTxt";
            this.PuntajeTxt.Size = new System.Drawing.Size(99, 23);
            this.PuntajeTxt.TabIndex = 1;
            this.PuntajeTxt.Text = "PUNTAJE:";
            // 
            // RondaTxt
            // 
            this.RondaTxt.AutoSize = true;
            this.RondaTxt.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RondaTxt.Location = new System.Drawing.Point(26, 30);
            this.RondaTxt.Name = "RondaTxt";
            this.RondaTxt.Size = new System.Drawing.Size(81, 23);
            this.RondaTxt.TabIndex = 0;
            this.RondaTxt.Text = "RONDA:";
            // 
            // Jugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1321, 696);
            this.Controls.Add(this.JuegoGrp);
            this.Controls.Add(this.MenuJuegoGrp);
            this.Controls.Add(this.Jugandolbl);
            this.Controls.Add(this.JugadorGroup);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Jugar";
            this.Text = "Jugar";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Jugar_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Jugar_FormClosed);
            this.Load += new System.EventHandler(this.Jugar_Load);
            this.JugadorGroup.ResumeLayout(false);
            this.JugadorGroup.PerformLayout();
            this.MenuJuegoGrp.ResumeLayout(false);
            this.MenuJuegoGrp.PerformLayout();
            this.JuegoGrp.ResumeLayout(false);
            this.JuegoGrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox JugadorGroup;
        private System.Windows.Forms.MaskedTextBox IdentificacionTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NuevoUsuario;
        private System.Windows.Forms.Label Jugandolbl;
        private System.Windows.Forms.LinkLabel SiguienteOpt;
        private System.Windows.Forms.LinkLabel SalirOpt;
        private System.Windows.Forms.GroupBox MenuJuegoGrp;
        private System.Windows.Forms.GroupBox JuegoGrp;
        private System.Windows.Forms.Label PuntajeTxt;
        private System.Windows.Forms.Label RondaTxt;
        private System.Windows.Forms.Label PreguntaTxt;
        private System.Windows.Forms.LinkLabel IniciarOpt;
        private System.Windows.Forms.ListBox CategoriasList;
        private System.Windows.Forms.ListBox RespuestasList;
        private System.Windows.Forms.Label CategoriaTxt;
    }
}