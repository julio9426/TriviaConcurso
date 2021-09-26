using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TriviaConcurso.Entidades;
using TriviaConcurso.Herramientas;
using TriviaConcurso.Procesos;

namespace TriviaConcurso
{
    public partial class Administrar : Form,IEntidad
    {
        List<Categoria> categorias;
        List<Pregunta> preguntas;
        List<Respuesta> respuestas;

        public Administrar()
        {
            InitializeComponent();
        }

        public void CrearValoresDefecto()
        {
            if (categorias == null || categorias.Count == 0)
            {
                categorias.Add(new Categoria()
                {
                    Identificador = 0,
                    Descripcion = string.Empty
                });

                if (respuestas == null || respuestas.Count == 0)
                {
                    respuestas.Add(new Respuesta()
                    {
                        Identificador = 0,
                        IdentificadorPregunta = 0,
                        TextoRespuesta = string.Empty,
                        Correcta = false
                    });
                }

                if (preguntas ==null || preguntas.Count == 0)
                {
                    preguntas.Add(new Pregunta
                    {
                        Identificador = 0,
                        IdentificadorCategoria=0,
                        TextoPregunta = string.Empty
                    });
                }

            }
        }

        private void Administrar_Load(object sender, EventArgs e)
        {
            categorias = CargaArchivos<Categoria>.CargaArchivoJson(NombreArchivos.ArchivoCategorias);
            preguntas = CargaArchivos<Pregunta>.CargaArchivoJson(NombreArchivos.ArchivoPreguntas);
            respuestas = CargaArchivos<Respuesta>.CargaArchivoJson(NombreArchivos.ArchivoRespuestas);
            CrearValoresDefecto();
            CargaTablas(categorias, TablaListaCategorias);
            CargaTablas(preguntas, TablaPreguntas);
            CargaListas(categorias, CategoriaCmb,  "Descripcion", "Identificador");
            CargaTablas(respuestas,TablaRespuestas);
            CargaListas(preguntas, PreguntasCmb,  "TextoPregunta", "Identificador");
        }

        private void CargaTablas<T>(List<T> datos, DataGridView grid) 
        {
            if (datos == null || datos.Count() == 0) return; 
            DataTable datosTabla = datos.ComoDataTable();
            grid.DataSource = null;
            grid.Rows.Clear();
            grid.DataSource = datosTabla;
        }

        private void CargaListas<T>(List<T> datos, ComboBox lista,string campoDato, string campoValor) 
        {
            var actualSelectedIndex = lista.SelectedIndex;
            if (datos == null || datos.Count() == 0) return;
            DataTable datosLista= datos.ComoDataTable();
            lista.DataSource = null;
            lista.Items.Clear();
            lista.DataSource = datosLista;
            lista.ValueMember = campoValor;
            lista.DisplayMember = campoDato;
            lista.SelectedIndex = actualSelectedIndex;

        }

        private void TablaListaCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdCategoriaText.Text= TablaListaCategorias.Rows[e.RowIndex].Cells["Identificador"].Value.ToString();
            NombreCategoriaText.Text = TablaListaCategorias.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
            NivelCategoriaCmb.SelectedIndex = int.Parse(TablaListaCategorias.Rows[e.RowIndex].Cells["RondaCategoria"].Value.ToString());
            PremioUpDown.Value = int.Parse(TablaListaCategorias.Rows[e.RowIndex].Cells["Premio"].Value.ToString());
        }

        private void UpsertCategoria_Click(object sender, EventArgs e)
        {
            var categoria= categorias.Where(c => c.Identificador == int.Parse(IdCategoriaText.Text)).FirstOrDefault();
            
            if (categoria == null) categoria = new Categoria() { Identificador= int.Parse(IdCategoriaText.Text) };
            
            categoria.Descripcion = NombreCategoriaText.Text;
            categoria.RondaCategoria = (Nivel)NivelCategoriaCmb.SelectedIndex;
            categoria.Premio = (int) PremioUpDown.Value;

            if (categorias.Count <= categoria.Identificador) categorias.Add(categoria);
            categorias= GuardaArchivos<Categoria>.GuardaArchivo(NombreArchivos.ArchivoCategorias,categorias);
            
            CargaTablas(categorias,TablaListaCategorias);
            CargaListas<Categoria>(categorias, CategoriaCmb, "Descripcion", "Identificador");
           
            LimpiaDatos(SeccionesAdmin.Categorias);

        }

        private void NuevaCategoriaBtn_Click(object sender, EventArgs e)
        {
            LimpiaDatos(SeccionesAdmin.Categorias);
        }

        private void LimpiaDatos(SeccionesAdmin seccion) 
        {
            
            switch (seccion) 
            {
                case SeccionesAdmin.Categorias:
                    NombreCategoriaText.Text = string.Empty;
                    NivelCategoriaCmb.SelectedIndex = 0;
                    IdCategoriaText.Text = categorias == null ? "0" : categorias.Count().ToString();
                    break;
                case SeccionesAdmin.Preguntas:
                    TextoPreguntaTxt.Text = string.Empty;
                    CategoriaCmb.SelectedIndex = 0;
                    CategoriaCmb.Enabled = true;
                    IdPreguntaTxt.Text=preguntas==null?"0": preguntas.Count().ToString();
                    break;
                case SeccionesAdmin.Respuestas:
                    RespuestaTxt.Text = string.Empty;
                    PreguntasCmb.Enabled = true;
                    PreguntasCmb.SelectedIndex = 0;
                    IdRespuestaTxt.Text = respuestas == null ? "0" : respuestas.Count().ToString();
                    break;
            }
            
        }

        private void Administrar_FormClosed(object sender, FormClosedEventArgs e)
        {
            ControlFormas.RemueveForma(this);
        }

        private void TablaListaCategorias_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (TablaListaCategorias.Visible) 
            {
                IdCategoriaText.Text = TablaListaCategorias.Rows[e.RowIndex].Cells["Identificador"].Value.ToString();
                NombreCategoriaText.Text = TablaListaCategorias.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                NivelCategoriaCmb.SelectedIndex = int.Parse(TablaListaCategorias.Rows[e.RowIndex].Cells["RondaCategoria"].Value.ToString());
                PremioUpDown.Value = int.Parse(TablaListaCategorias.Rows[e.RowIndex].Cells["Premio"].Value.ToString());
            }

        }

        private void UpsertPreguntaBtn_Click(object sender, EventArgs e)
        {
            var pregunta = preguntas.Where(c => c.Identificador == int.Parse(IdPreguntaTxt.Text)).FirstOrDefault();

            if (pregunta == null) pregunta = new Pregunta() { Identificador= int.Parse(IdPreguntaTxt.Text) };

            pregunta.TextoPregunta = TextoPreguntaTxt.Text;
            pregunta.IdentificadorCategoria = int.Parse(CategoriaCmb.SelectedValue.ToString());
            
            if (preguntas.Count <= pregunta.Identificador) preguntas.Add(pregunta);
            
            preguntas= GuardaArchivos<Pregunta>.GuardaArchivo(NombreArchivos.ArchivoPreguntas,preguntas);
            CargaTablas(preguntas,TablaPreguntas);
            CargaListas<Pregunta>(preguntas, PreguntasCmb, "TextoPregunta", "Identificador");
            
            var countPreguntaCategoria = preguntas.Where(p => p.IdentificadorCategoria == int.Parse(CategoriaCmb.SelectedValue.ToString())).Count();
            var categoria = categorias.Where(c => c.Identificador == int.Parse(CategoriaCmb.SelectedValue.ToString())).FirstOrDefault();
            
            categoria.ContadorPreguntas = countPreguntaCategoria;
            categorias = GuardaArchivos<Categoria>.GuardaArchivo(NombreArchivos.ArchivoCategorias, categorias);
            CargaTablas(categorias, TablaListaCategorias);
            LimpiaDatos(SeccionesAdmin.Preguntas);

        }

        private void TablaPreguntas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (TablaPreguntas.Visible) 
            {
                IdPreguntaTxt.Text = TablaPreguntas.Rows[e.RowIndex].Cells["Identificador"].Value.ToString();
                CategoriaCmb.SelectedValue = TablaPreguntas.Rows[e.RowIndex].Cells["IdentificadorCategoria"].Value.ToString();
                CategoriaCmb.Enabled = false;
                TextoPreguntaTxt.Text = TablaPreguntas.Rows[e.RowIndex].Cells["TextoPregunta"].Value.ToString();
            }
        }

        private void NuevaPreguntaBtn_Click(object sender, EventArgs e)
        {
            LimpiaDatos(SeccionesAdmin.Preguntas);
        }

        private void UpsertRespuestaBtn_Click(object sender, EventArgs e)
        {
            var respuesta = respuestas.Where(c => c.Identificador == int.Parse(IdRespuestaTxt.Text)).FirstOrDefault();

            if (respuesta == null) respuesta = new Respuesta() { Identificador = int.Parse(IdRespuestaTxt.Text) };
            
            respuesta.TextoRespuesta = RespuestaTxt.Text;
            respuesta.Correcta = CorrectaChk.Checked;
            respuesta.IdentificadorPregunta = int.Parse(PreguntasCmb.SelectedValue.ToString());

            if (respuestas.Count <= respuesta.Identificador) respuestas.Add(respuesta);
            respuestas = GuardaArchivos<Respuesta>.GuardaArchivo(NombreArchivos.ArchivoRespuestas, respuestas);
            CargaTablas(respuestas, TablaRespuestas);

            var pregunta = preguntas.Where(p => p.Identificador== respuesta.IdentificadorPregunta).FirstOrDefault();
            var contadorRespuestas = respuestas.Where(r => r.IdentificadorPregunta == respuesta.IdentificadorPregunta).Count();
            
            pregunta.ContadorRespuestas = contadorRespuestas;
            preguntas=GuardaArchivos<Pregunta>.GuardaArchivo(NombreArchivos.ArchivoPreguntas,preguntas);
            CargaTablas(preguntas, TablaPreguntas);

            LimpiaDatos(SeccionesAdmin.Respuestas);
        }

        private void TablaRespuestas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TablaRespuestas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (TablaRespuestas.Visible)
            {

                IdRespuestaTxt.Text = TablaRespuestas.Rows[e.RowIndex].Cells["Identificador"].Value.ToString();
                PreguntasCmb.SelectedValue = TablaRespuestas.Rows[e.RowIndex].Cells["IdentificadorPregunta"].Value.ToString();
                PreguntasCmb.Enabled = false;
                RespuestaTxt.Text = TablaRespuestas.Rows[e.RowIndex].Cells["TextoRespuesta"].Value.ToString();
                CorrectaChk.Checked = bool.Parse(TablaRespuestas.Rows[e.RowIndex].Cells["Correcta"].Value.ToString());
                var pregunta = preguntas.Where(p => p.Identificador == int.Parse(PreguntasCmb.SelectedValue.ToString())).FirstOrDefault();
                //if (pregunta?.ContadorRespuestas < 4)
                //{
                //    UpsertRespuestaBtn.Enabled = true;
                //}
                //else 
                //{
                //    NuevaRespuestaBtn.Enabled = false;
                //}
            }
        }

        private void NuevaRespuestaBtn_Click(object sender, EventArgs e)
        {
            LimpiaDatos(SeccionesAdmin.Respuestas);
        }

        private void CorrectaChk_CheckedChanged(object sender, EventArgs e)
        {
           
           
        }

        private void PreguntasCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            CorrectaChk.Enabled = true;
            if (PreguntasCmb.Visible)
            {
                var existeCorrecta = respuestas.Where(r => r.IdentificadorPregunta == int.Parse(PreguntasCmb.SelectedValue.ToString()) && r.Correcta == true).Any();
                CorrectaChk.Enabled = !existeCorrecta;
                
                //var pregunta = preguntas.Where(p => p.Identificador == int.Parse(PreguntasCmb.SelectedValue.ToString())).FirstOrDefault();
                //if (pregunta?.ContadorRespuestas < 4)
                //{
                //    NuevaRespuestaBtn.Enabled = true;
                //}
                //else
                //{
                //    NuevaRespuestaBtn.Enabled = false;
                //}

            }
            

        }

        private void RespuestaTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void NivelCategoriaLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
