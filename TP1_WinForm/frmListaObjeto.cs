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
    public partial class frmListaObjeto : Form
    {
        public frmListaObjeto()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Rellene el cuadro");
                return;
            }
            lbxIzquierda.Items.Add(txtNuevo.Text.Trim());
            txtNuevo.Text = "";
            actulizarRegistros();
            txtNuevo.Focus();
        }

        private void btnEnviarTodos_Click(object sender, EventArgs e)
        {
            if (lbxIzquierda.Items.Count == 0)
            {
                return;
            }
            for (int i = (lbxIzquierda.Items.Count - 1); i >= 0; i--)
            {
                if (!existe(lbxIzquierda.Items[i]))
                {
                    lbxDereacha.Items.Add(lbxIzquierda.Items[i]);
                    lbxIzquierda.Items.Remove(lbxIzquierda.Items[i]);
                }
            }
            actulizarRegistros();
        }

        private void btnEnviarUno_Click(object sender, EventArgs e)
        {
            if (lbxIzquierda.SelectedIndex < 0)
            {
                return;
            }
            if (!existe(lbxIzquierda.SelectedItem))
            {
                lbxDereacha.Items.Add(lbxIzquierda.SelectedItem);
                lbxIzquierda.Items.RemoveAt(lbxIzquierda.SelectedIndex);
            }
            else
            {
                MessageBox.Show("no se puede pasar porque ya existe en el otro lado");
            }
            actulizarRegistros();
        }

        
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lbxDereacha.SelectedIndex > -1)
            {
                lbxDereacha.Items.RemoveAt(lbxDereacha.SelectedIndex);
            }
            actulizarRegistros();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (lbxDereacha.SelectedIndex < 0)
            {
                return;
            }
            lbxIzquierda.Items.Add(lbxDereacha.SelectedItem);
            lbxDereacha.Items.RemoveAt(lbxDereacha.SelectedIndex);
            actulizarRegistros();
        }

        private void actulizarRegistros()
        {
            lblCntDer.Text = lbxDereacha.Items.Count.ToString();
            lblCntIzq.Text = lbxIzquierda.Items.Count.ToString();
        }

        public bool existe(object item)
        {
            foreach (var item2 in lbxDereacha.Items)
            {
                if (item.ToString() == item2.ToString())
                {
                    return true;
                }
            }
            return false;
        }

    }
}
