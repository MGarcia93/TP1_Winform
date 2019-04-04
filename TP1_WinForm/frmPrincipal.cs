using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_WinForm
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void listadoDePersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaPersona listaPersona = new frmListaPersona();
            listaPersona.MdiParent = this;
            listaPersona.Show();
        }

        private void listadoDeObjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaObjeto listaObjeto = new frmListaObjeto();
            listaObjeto.MdiParent = this;
            listaObjeto.Show();
        }
    }
}
