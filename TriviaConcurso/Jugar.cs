using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TriviaConcurso.Entidades;
using TriviaConcurso.Herramientas;
using TriviaConcurso.Procesos;

namespace TriviaConcurso
{
    public partial class Jugar : Form
    {
        private Jugador jugador =null;
        private Pregunta pregunta = null;
        private Respuesta respuestaActual = null;
        private Categoria categoriaActual = null;
        private List<Categoria> categorias;
        private List<Pregunta> preguntas;
        private List<Respuesta> respuestas;
        bool gano = false;

        int ronda = 0;

        public Jugar()
        {
            InitializeComponent();
        }

        private void Jugar_FormClosed(object sender, FormClosedEventArgs e)
        {
            ControlFormas.RemueveForma(this);
            ((Main)this.MdiParent).HabilitaMenu();
        }

        private void Jugar_Load(object sender, EventArgs e)
        {
            categorias = CargaArchivos<Categoria>.CargaArchivoJson(NombreArchivos.ArchivoCategorias);
            preguntas = CargaArchivos<Pregunta>.CargaArchivoJson(NombreArchivos.ArchivoPreguntas);
            respuestas = CargaArchivos<Respuesta>.CargaArchivoJson(NombreArchivos.ArchivoRespuestas);

            JugadorGroup.Top = this.Top+200;
            JugadorGroup.Left = this.Left +300;
            JugadorGroup.Visible = jugador == null;
            MenuJuegoGrp.Visible = jugador!= null;
            JuegoGrp.Visible = jugador != null;

        }

        private void IniciarTablero() 
        {

            PreguntaTxt.Visible = false;
            RespuestasList.Visible = false;

            CategoriasList.Items.Clear();

            categorias.Where(c => c.RondaCategoria == (Nivel) ronda ).ToList()
                .ForEach(cat => {
                    if (preguntas.Where(p => p.IdentificadorCategoria == cat.Identificador).Count() >= 5)
                    {
                        CategoriasList.Items.Add($"{cat.Descripcion}                                                                        " +
                            $" #{cat.Identificador}");
                    }
                });

            CategoriasList.Visible=true;
            PuntajeTxt.Text = $"PUNTAJE: {jugador.Puntos}";
            RondaTxt.Text =$"RONDA: {ronda}";

        }

        private void NuevoUsuario_Click(object sender, EventArgs e)
        {
            jugador = new Jugador()
            {
                Identificador = int.Parse(IdentificacionTxt.Text),
                Nombre = NombreTxt.Text
            };
            
            Jugandolbl.Text = $"ESTA JUGANDO: *** {jugador.Nombre} *** ";
            JugadorGroup.Visible = false;
            MenuJuegoGrp.Visible = true;
            
            JuegoGrp.Visible = true;
        }      

        private void IniciarOpt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ronda = 0;
            IniciarTablero();
            IniciarOpt.Enabled = false;
        }

        private void CategoriasList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoria = ((System.Windows.Forms.ListBox)sender).SelectedItem.ToString().Split('#')[1];
            categoriaActual = categorias.Where(cat => cat.Identificador == double.Parse(categoria)).FirstOrDefault();
            var preguntasCategoria = preguntas.Where(p => p.IdentificadorCategoria == double.Parse(categoria) && p.ContadorRespuestas==4).ToList();
            
            pregunta = preguntasCategoria.TomaAleatorio();
            
            PreguntaTxt.Text =$"PREGUNTA:  {pregunta?.TextoPregunta}";
            CategoriasList.Visible = false;
            RespuestasList.Visible = true;

            InicializaRespuestas();
            PreguntaTxt.Visible = true;
            CategoriaTxt.Visible = false;
        }

        private void InicializaRespuestas() 
        {
            RespuestasList.Items.Clear();
            if (pregunta != null)
            {
                respuestas.Where(r => r.IdentificadorPregunta == pregunta.Identificador).ToList().ForEach(rta =>
                {
                    RespuestasList.Items.Add($"{rta.TextoRespuesta}                                                                                                   " +
                        $"#{rta.Identificador}#{rta.Correcta}");
                });
            }
        }

        private void RespuestasList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string respuesta = ((System.Windows.Forms.ListBox)sender).SelectedItem.ToString().Split('#')[1];
            respuestaActual = respuestas.Where(rta => rta.Identificador == double.Parse(respuesta)).FirstOrDefault();
            VerificaRespuesta();
            IniciarTablero();
        }

        private void VerificaRespuesta() 
        {
            if (respuestaActual != null) 
            {
                if (respuestaActual.Correcta)
                {
                    gano = true;
                    jugador.Puntos += categoriaActual.Premio;
                    PuntajeTxt.Text = jugador.Puntos.ToString();
                    if ((Nivel)ronda == Nivel.Heroe)
                    {
                        MessageBox.Show($"¡¡¡¡¡¡¡¡¡GANASTE : {jugador.Puntos} PUNTOS !!!!!!!!");
                        
                        this.Close();
                    }
                    else 
                    {
                        MessageBox.Show($"Bien Hecho sumaste : {categoriaActual.Premio} PUNTOS ");
                        ronda++;
                    }
                }
                else 
                {
                    jugador.Puntos = 0;
                    MessageBox.Show("****** HAZ PERDIDO *********");
                    this.Close();
                }

            }
        }

        private void SalirOpt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (gano)
            {
                MessageBox.Show($"Haz Finalizado Antes de completar \n todos los niveles ganaste : {jugador.Puntos} PUNTOS ");
            }
            this.Close();
        }
        private void GuardaJugador() 
        {
            if (jugador != null) 
            {
                List<Jugador> jugadores = CargaArchivos<Jugador>.CargaArchivoJson(NombreArchivos.ArchivoJugadores)?? new List<Jugador>();
                jugador.FechaJuego = DateTime.Now;
                jugadores.Add(jugador);
                GuardaArchivos<Jugador>.GuardaArchivo(NombreArchivos.ArchivoJugadores, jugadores);
            }
        }

        private void Jugar_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardaJugador();
        }
    }
}