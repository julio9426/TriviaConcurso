
namespace TriviaConcurso
{
    partial class Administrar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Secciones = new System.Windows.Forms.TabControl();
            this.Categorias = new System.Windows.Forms.TabPage();
            this.ListaCategorias = new System.Windows.Forms.GroupBox();
            this.TablaListaCategorias = new System.Windows.Forms.DataGridView();
            this.DetalleCategoria = new System.Windows.Forms.GroupBox();
            this.PremioUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.NuevaCategoriaBtn = new System.Windows.Forms.Button();
            this.IdCategoriaText = new System.Windows.Forms.Label();
            this.idCategoriaLabel = new System.Windows.Forms.Label();
            this.UpsertCategoria = new System.Windows.Forms.Button();
            this.NivelCategoriaCmb = new System.Windows.Forms.ComboBox();
            this.NivelCategoriaLabel = new System.Windows.Forms.Label();
            this.NombreCategoriaText = new System.Windows.Forms.TextBox();
            this.NombreCategoriaLabel = new System.Windows.Forms.Label();
            this.Preguntas = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TablaPreguntas = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CategoriaCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NuevaPreguntaBtn = new System.Windows.Forms.Button();
            this.IdPreguntaTxt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UpsertPreguntaBtn = new System.Windows.Forms.Button();
            this.TextoPreguntaTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Respuestas = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TablaRespuestas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CorrectaChk = new System.Windows.Forms.CheckBox();
            this.PreguntasCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NuevaRespuestaBtn = new System.Windows.Forms.Button();
            this.IdRespuestaTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UpsertRespuestaBtn = new System.Windows.Forms.Button();
            this.RespuestaTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Secciones.SuspendLayout();
            this.Categorias.SuspendLayout();
            this.ListaCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaListaCategorias)).BeginInit();
            this.DetalleCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PremioUpDown)).BeginInit();
            this.Preguntas.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaPreguntas)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.Respuestas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaRespuestas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Secciones
            // 
            this.Secciones.Controls.Add(this.Categorias);
            this.Secciones.Controls.Add(this.Preguntas);
            this.Secciones.Controls.Add(this.Respuestas);
            this.Secciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Secciones.Location = new System.Drawing.Point(0, 0);
            this.Secciones.Name = "Secciones";
            this.Secciones.SelectedIndex = 0;
            this.Secciones.Size = new System.Drawing.Size(800, 450);
            this.Secciones.TabIndex = 0;
            // 
            // Categorias
            // 
            this.Categorias.Controls.Add(this.ListaCategorias);
            this.Categorias.Controls.Add(this.DetalleCategoria);
            this.Categorias.Location = new System.Drawing.Point(4, 24);
            this.Categorias.Name = "Categorias";
            this.Categorias.Padding = new System.Windows.Forms.Padding(3);
            this.Categorias.Size = new System.Drawing.Size(792, 422);
            this.Categorias.TabIndex = 0;
            this.Categorias.Text = "Categorias";
            this.Categorias.UseVisualStyleBackColor = true;
            // 
            // ListaCategorias
            // 
            this.ListaCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaCategorias.Controls.Add(this.TablaListaCategorias);
            this.ListaCategorias.Location = new System.Drawing.Point(3, 128);
            this.ListaCategorias.Name = "ListaCategorias";
            this.ListaCategorias.Size = new System.Drawing.Size(786, 291);
            this.ListaCategorias.TabIndex = 1;
            this.ListaCategorias.TabStop = false;
            this.ListaCategorias.Text = "Lista Categorias";
            // 
            // TablaListaCategorias
            // 
            this.TablaListaCategorias.AllowUserToAddRows = false;
            this.TablaListaCategorias.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TablaListaCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TablaListaCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.TablaListaCategorias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.TablaListaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaListaCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaListaCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.TablaListaCategorias.Location = new System.Drawing.Point(3, 19);
            this.TablaListaCategorias.MultiSelect = false;
            this.TablaListaCategorias.Name = "TablaListaCategorias";
            this.TablaListaCategorias.RowTemplate.Height = 25;
            this.TablaListaCategorias.RowTemplate.ReadOnly = true;
            this.TablaListaCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaListaCategorias.ShowEditingIcon = false;
            this.TablaListaCategorias.Size = new System.Drawing.Size(780, 269);
            this.TablaListaCategorias.TabIndex = 0;
            this.TablaListaCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaListaCategorias_CellContentClick);
            this.TablaListaCategorias.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaListaCategorias_RowEnter);
            // 
            // DetalleCategoria
            // 
            this.DetalleCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetalleCategoria.Controls.Add(this.PremioUpDown);
            this.DetalleCategoria.Controls.Add(this.label5);
            this.DetalleCategoria.Controls.Add(this.NuevaCategoriaBtn);
            this.DetalleCategoria.Controls.Add(this.IdCategoriaText);
            this.DetalleCategoria.Controls.Add(this.idCategoriaLabel);
            this.DetalleCategoria.Controls.Add(this.UpsertCategoria);
            this.DetalleCategoria.Controls.Add(this.NivelCategoriaCmb);
            this.DetalleCategoria.Controls.Add(this.NivelCategoriaLabel);
            this.DetalleCategoria.Controls.Add(this.NombreCategoriaText);
            this.DetalleCategoria.Controls.Add(this.NombreCategoriaLabel);
            this.DetalleCategoria.Location = new System.Drawing.Point(3, 3);
            this.DetalleCategoria.Name = "DetalleCategoria";
            this.DetalleCategoria.Size = new System.Drawing.Size(786, 122);
            this.DetalleCategoria.TabIndex = 0;
            this.DetalleCategoria.TabStop = false;
            this.DetalleCategoria.Text = "Detalle Categoria";
            // 
            // PremioUpDown
            // 
            this.PremioUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PremioUpDown.Location = new System.Drawing.Point(168, 94);
            this.PremioUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.PremioUpDown.Name = "PremioUpDown";
            this.PremioUpDown.Size = new System.Drawing.Size(120, 23);
            this.PremioUpDown.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Premio Categoria";
            // 
            // NuevaCategoriaBtn
            // 
            this.NuevaCategoriaBtn.Location = new System.Drawing.Point(363, 25);
            this.NuevaCategoriaBtn.Name = "NuevaCategoriaBtn";
            this.NuevaCategoriaBtn.Size = new System.Drawing.Size(141, 31);
            this.NuevaCategoriaBtn.TabIndex = 7;
            this.NuevaCategoriaBtn.Text = "Nueva Categoria";
            this.NuevaCategoriaBtn.UseVisualStyleBackColor = true;
            this.NuevaCategoriaBtn.Click += new System.EventHandler(this.NuevaCategoriaBtn_Click);
            // 
            // IdCategoriaText
            // 
            this.IdCategoriaText.AutoSize = true;
            this.IdCategoriaText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdCategoriaText.Location = new System.Drawing.Point(168, 25);
            this.IdCategoriaText.Name = "IdCategoriaText";
            this.IdCategoriaText.Size = new System.Drawing.Size(15, 17);
            this.IdCategoriaText.TabIndex = 6;
            this.IdCategoriaText.Text = "0";
            // 
            // idCategoriaLabel
            // 
            this.idCategoriaLabel.AutoSize = true;
            this.idCategoriaLabel.Location = new System.Drawing.Point(29, 25);
            this.idCategoriaLabel.Name = "idCategoriaLabel";
            this.idCategoriaLabel.Size = new System.Drawing.Size(71, 15);
            this.idCategoriaLabel.TabIndex = 5;
            this.idCategoriaLabel.Text = "Id Categoria";
            // 
            // UpsertCategoria
            // 
            this.UpsertCategoria.Location = new System.Drawing.Point(363, 58);
            this.UpsertCategoria.Name = "UpsertCategoria";
            this.UpsertCategoria.Size = new System.Drawing.Size(141, 25);
            this.UpsertCategoria.TabIndex = 4;
            this.UpsertCategoria.Text = "Guarda Categoria";
            this.UpsertCategoria.UseVisualStyleBackColor = true;
            this.UpsertCategoria.Click += new System.EventHandler(this.UpsertCategoria_Click);
            // 
            // NivelCategoriaCmb
            // 
            this.NivelCategoriaCmb.FormattingEnabled = true;
            this.NivelCategoriaCmb.Items.AddRange(new object[] {
            "Basico",
            "Intermedio",
            "Avanzado",
            "Experto",
            "Heroe"});
            this.NivelCategoriaCmb.Location = new System.Drawing.Point(168, 68);
            this.NivelCategoriaCmb.Name = "NivelCategoriaCmb";
            this.NivelCategoriaCmb.Size = new System.Drawing.Size(121, 23);
            this.NivelCategoriaCmb.TabIndex = 3;
            // 
            // NivelCategoriaLabel
            // 
            this.NivelCategoriaLabel.AutoSize = true;
            this.NivelCategoriaLabel.Location = new System.Drawing.Point(29, 68);
            this.NivelCategoriaLabel.Name = "NivelCategoriaLabel";
            this.NivelCategoriaLabel.Size = new System.Drawing.Size(95, 15);
            this.NivelCategoriaLabel.TabIndex = 2;
            this.NivelCategoriaLabel.Text = "Ronda Categoria";
            this.NivelCategoriaLabel.Click += new System.EventHandler(this.NivelCategoriaLabel_Click);
            // 
            // NombreCategoriaText
            // 
            this.NombreCategoriaText.Location = new System.Drawing.Point(168, 44);
            this.NombreCategoriaText.Name = "NombreCategoriaText";
            this.NombreCategoriaText.Size = new System.Drawing.Size(100, 23);
            this.NombreCategoriaText.TabIndex = 1;
            // 
            // NombreCategoriaLabel
            // 
            this.NombreCategoriaLabel.AutoSize = true;
            this.NombreCategoriaLabel.Location = new System.Drawing.Point(29, 46);
            this.NombreCategoriaLabel.Name = "NombreCategoriaLabel";
            this.NombreCategoriaLabel.Size = new System.Drawing.Size(102, 15);
            this.NombreCategoriaLabel.TabIndex = 0;
            this.NombreCategoriaLabel.Text = "NombreCategoria";
            // 
            // Preguntas
            // 
            this.Preguntas.Controls.Add(this.groupBox3);
            this.Preguntas.Controls.Add(this.groupBox4);
            this.Preguntas.Location = new System.Drawing.Point(4, 24);
            this.Preguntas.Name = "Preguntas";
            this.Preguntas.Padding = new System.Windows.Forms.Padding(3);
            this.Preguntas.Size = new System.Drawing.Size(792, 422);
            this.Preguntas.TabIndex = 1;
            this.Preguntas.Text = "Preguntas";
            this.Preguntas.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.TablaPreguntas);
            this.groupBox3.Location = new System.Drawing.Point(3, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(786, 282);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista Preguntas";
            // 
            // TablaPreguntas
            // 
            this.TablaPreguntas.AllowUserToAddRows = false;
            this.TablaPreguntas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TablaPreguntas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.TablaPreguntas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.TablaPreguntas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.TablaPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaPreguntas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaPreguntas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.TablaPreguntas.Location = new System.Drawing.Point(3, 19);
            this.TablaPreguntas.MultiSelect = false;
            this.TablaPreguntas.Name = "TablaPreguntas";
            this.TablaPreguntas.RowTemplate.Height = 25;
            this.TablaPreguntas.RowTemplate.ReadOnly = true;
            this.TablaPreguntas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaPreguntas.ShowEditingIcon = false;
            this.TablaPreguntas.Size = new System.Drawing.Size(780, 260);
            this.TablaPreguntas.TabIndex = 0;
            this.TablaPreguntas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaPreguntas_RowEnter);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.CategoriaCmb);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.NuevaPreguntaBtn);
            this.groupBox4.Controls.Add(this.IdPreguntaTxt);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.UpsertPreguntaBtn);
            this.groupBox4.Controls.Add(this.TextoPreguntaTxt);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(786, 128);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalle Pregunta";
            // 
            // CategoriaCmb
            // 
            this.CategoriaCmb.FormattingEnabled = true;
            this.CategoriaCmb.Location = new System.Drawing.Point(168, 45);
            this.CategoriaCmb.Name = "CategoriaCmb";
            this.CategoriaCmb.Size = new System.Drawing.Size(390, 23);
            this.CategoriaCmb.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Categoria";
            // 
            // NuevaPreguntaBtn
            // 
            this.NuevaPreguntaBtn.Location = new System.Drawing.Point(584, 25);
            this.NuevaPreguntaBtn.Name = "NuevaPreguntaBtn";
            this.NuevaPreguntaBtn.Size = new System.Drawing.Size(141, 31);
            this.NuevaPreguntaBtn.TabIndex = 7;
            this.NuevaPreguntaBtn.Text = "Nueva Pregunta";
            this.NuevaPreguntaBtn.UseVisualStyleBackColor = true;
            this.NuevaPreguntaBtn.Click += new System.EventHandler(this.NuevaPreguntaBtn_Click);
            // 
            // IdPreguntaTxt
            // 
            this.IdPreguntaTxt.AutoSize = true;
            this.IdPreguntaTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdPreguntaTxt.Location = new System.Drawing.Point(168, 25);
            this.IdPreguntaTxt.Name = "IdPreguntaTxt";
            this.IdPreguntaTxt.Size = new System.Drawing.Size(15, 17);
            this.IdPreguntaTxt.TabIndex = 6;
            this.IdPreguntaTxt.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Id Pregunta";
            // 
            // UpsertPreguntaBtn
            // 
            this.UpsertPreguntaBtn.Location = new System.Drawing.Point(584, 69);
            this.UpsertPreguntaBtn.Name = "UpsertPreguntaBtn";
            this.UpsertPreguntaBtn.Size = new System.Drawing.Size(141, 25);
            this.UpsertPreguntaBtn.TabIndex = 4;
            this.UpsertPreguntaBtn.Text = "Guarda Pregunta";
            this.UpsertPreguntaBtn.UseVisualStyleBackColor = true;
            this.UpsertPreguntaBtn.Click += new System.EventHandler(this.UpsertPreguntaBtn_Click);
            // 
            // TextoPreguntaTxt
            // 
            this.TextoPreguntaTxt.Location = new System.Drawing.Point(168, 71);
            this.TextoPreguntaTxt.Name = "TextoPreguntaTxt";
            this.TextoPreguntaTxt.Size = new System.Drawing.Size(390, 23);
            this.TextoPreguntaTxt.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Texto Pregunta";
            // 
            // Respuestas
            // 
            this.Respuestas.Controls.Add(this.groupBox1);
            this.Respuestas.Controls.Add(this.groupBox2);
            this.Respuestas.Location = new System.Drawing.Point(4, 24);
            this.Respuestas.Name = "Respuestas";
            this.Respuestas.Padding = new System.Windows.Forms.Padding(3);
            this.Respuestas.Size = new System.Drawing.Size(792, 422);
            this.Respuestas.TabIndex = 2;
            this.Respuestas.Text = "Respuestas";
            this.Respuestas.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TablaRespuestas);
            this.groupBox1.Location = new System.Drawing.Point(3, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 310);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Respuestas";
            // 
            // TablaRespuestas
            // 
            this.TablaRespuestas.AllowUserToAddRows = false;
            this.TablaRespuestas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TablaRespuestas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.TablaRespuestas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.TablaRespuestas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.TablaRespuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaRespuestas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaRespuestas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.TablaRespuestas.Location = new System.Drawing.Point(3, 19);
            this.TablaRespuestas.MultiSelect = false;
            this.TablaRespuestas.Name = "TablaRespuestas";
            this.TablaRespuestas.RowTemplate.Height = 25;
            this.TablaRespuestas.RowTemplate.ReadOnly = true;
            this.TablaRespuestas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaRespuestas.ShowEditingIcon = false;
            this.TablaRespuestas.Size = new System.Drawing.Size(780, 288);
            this.TablaRespuestas.TabIndex = 0;
            this.TablaRespuestas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaRespuestas_CellContentClick);
            this.TablaRespuestas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaRespuestas_RowEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.CorrectaChk);
            this.groupBox2.Controls.Add(this.PreguntasCmb);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.NuevaRespuestaBtn);
            this.groupBox2.Controls.Add(this.IdRespuestaTxt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.UpsertRespuestaBtn);
            this.groupBox2.Controls.Add(this.RespuestaTxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(786, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle Respuesta";
            // 
            // CorrectaChk
            // 
            this.CorrectaChk.AutoSize = true;
            this.CorrectaChk.Location = new System.Drawing.Point(487, 73);
            this.CorrectaChk.Name = "CorrectaChk";
            this.CorrectaChk.Size = new System.Drawing.Size(71, 19);
            this.CorrectaChk.TabIndex = 10;
            this.CorrectaChk.Text = "Correcta";
            this.CorrectaChk.UseVisualStyleBackColor = true;
            this.CorrectaChk.CheckedChanged += new System.EventHandler(this.CorrectaChk_CheckedChanged);
            // 
            // PreguntasCmb
            // 
            this.PreguntasCmb.FormattingEnabled = true;
            this.PreguntasCmb.Location = new System.Drawing.Point(168, 45);
            this.PreguntasCmb.Name = "PreguntasCmb";
            this.PreguntasCmb.Size = new System.Drawing.Size(390, 23);
            this.PreguntasCmb.TabIndex = 9;
            this.PreguntasCmb.SelectedIndexChanged += new System.EventHandler(this.PreguntasCmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pregunta";
            // 
            // NuevaRespuestaBtn
            // 
            this.NuevaRespuestaBtn.Location = new System.Drawing.Point(584, 25);
            this.NuevaRespuestaBtn.Name = "NuevaRespuestaBtn";
            this.NuevaRespuestaBtn.Size = new System.Drawing.Size(141, 31);
            this.NuevaRespuestaBtn.TabIndex = 7;
            this.NuevaRespuestaBtn.Text = "Nueva Respuesta";
            this.NuevaRespuestaBtn.UseVisualStyleBackColor = true;
            this.NuevaRespuestaBtn.Click += new System.EventHandler(this.NuevaRespuestaBtn_Click);
            // 
            // IdRespuestaTxt
            // 
            this.IdRespuestaTxt.AutoSize = true;
            this.IdRespuestaTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdRespuestaTxt.Location = new System.Drawing.Point(168, 25);
            this.IdRespuestaTxt.Name = "IdRespuestaTxt";
            this.IdRespuestaTxt.Size = new System.Drawing.Size(15, 17);
            this.IdRespuestaTxt.TabIndex = 6;
            this.IdRespuestaTxt.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id Respuesta";
            // 
            // UpsertRespuestaBtn
            // 
            this.UpsertRespuestaBtn.Location = new System.Drawing.Point(584, 69);
            this.UpsertRespuestaBtn.Name = "UpsertRespuestaBtn";
            this.UpsertRespuestaBtn.Size = new System.Drawing.Size(141, 25);
            this.UpsertRespuestaBtn.TabIndex = 4;
            this.UpsertRespuestaBtn.Text = "Guarda Respuesta";
            this.UpsertRespuestaBtn.UseVisualStyleBackColor = true;
            this.UpsertRespuestaBtn.Click += new System.EventHandler(this.UpsertRespuestaBtn_Click);
            // 
            // RespuestaTxt
            // 
            this.RespuestaTxt.Location = new System.Drawing.Point(168, 71);
            this.RespuestaTxt.Name = "RespuestaTxt";
            this.RespuestaTxt.Size = new System.Drawing.Size(313, 23);
            this.RespuestaTxt.TabIndex = 1;
            this.RespuestaTxt.TextChanged += new System.EventHandler(this.RespuestaTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Texto Respuesta";
            // 
            // Administrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Secciones);
            this.Name = "Administrar";
            this.Text = "Administrar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Administrar_FormClosed);
            this.Load += new System.EventHandler(this.Administrar_Load);
            this.Secciones.ResumeLayout(false);
            this.Categorias.ResumeLayout(false);
            this.ListaCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaListaCategorias)).EndInit();
            this.DetalleCategoria.ResumeLayout(false);
            this.DetalleCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PremioUpDown)).EndInit();
            this.Preguntas.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaPreguntas)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Respuestas.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaRespuestas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Secciones;
        private System.Windows.Forms.TabPage Categorias;
        private System.Windows.Forms.TabPage Preguntas;
        private System.Windows.Forms.TabPage Respuestas;
        private System.Windows.Forms.GroupBox ListaCategorias;
        private System.Windows.Forms.GroupBox DetalleCategoria;
        private System.Windows.Forms.DataGridView TablaListaCategorias;
        private System.Windows.Forms.Button UpsertCategoria;
        private System.Windows.Forms.ComboBox NivelCategoriaCmb;
        private System.Windows.Forms.Label NivelCategoriaLabel;
        private System.Windows.Forms.TextBox NombreCategoriaText;
        private System.Windows.Forms.Label NombreCategoriaLabel;
        private System.Windows.Forms.Label IdCategoriaText;
        private System.Windows.Forms.Label idCategoriaLabel;
        private System.Windows.Forms.Button NuevaCategoriaBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView TablaRespuestas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button NuevaRespuestaBtn;
        private System.Windows.Forms.Label IdRespuestaTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UpsertRespuestaBtn;
        private System.Windows.Forms.TextBox RespuestaTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CorrectaChk;
        private System.Windows.Forms.ComboBox PreguntasCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown PremioUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView TablaPreguntas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox CategoriaCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button NuevaPreguntaBtn;
        private System.Windows.Forms.Label IdPreguntaTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button UpsertPreguntaBtn;
        private System.Windows.Forms.TextBox TextoPreguntaTxt;
        private System.Windows.Forms.Label label7;
    }
}