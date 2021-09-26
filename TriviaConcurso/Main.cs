using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriviaConcurso.Herramientas;

namespace TriviaConcurso
{
    public partial class Main : Form
    {
        List<Form> stackFormas = new List<Form>();
        public Main()
        {
            InitializeComponent();
        }

        private void AdministrarButton_Click(object sender, EventArgs e)
        {
           
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form forma=null;
            switch (e.ClickedItem.Text)
            {
                case "Administrar":
                    forma = ControlFormas.VerificaForma(typeof(Administrar)) ?? new Administrar() { MdiParent = this, WindowState = FormWindowState.Normal };
                    break;
                case "Jugar":
                    forma = ControlFormas.VerificaForma(typeof(Jugar)) ?? new Jugar() { MdiParent = this, Dock=DockStyle.Fill, WindowState = FormWindowState.Maximized };
                    
                    break;
            }
            ControlFormas.EnlistaForma(forma);
            Menu.Enabled = forma.Name != "Jugar";
            //forma.WindowState = FormWindowState.Normal;
            forma.Visible = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        public void HabilitaMenu() 
        {
            Menu.Enabled = true;
        }
    }
}
