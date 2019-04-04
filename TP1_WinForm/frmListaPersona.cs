using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace TP1_WinForm
{
    public partial class frmListaPersona : Form
    {
        private List<clsPersonas> listadoPersonas = new List<clsPersonas>();
        private BindingList<clsPersonas> listaBindeable;
        public frmListaPersona()
        {
            InitializeComponent();
            cargarColor();
            inizilizacion();
            listaBindeable = new BindingList<clsPersonas>(listadoPersonas);
            dgvLista.DataSource = listaBindeable;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!complobacion())
                {
                    MessageBox.Show("rellene todos los datos");
                    return;
                }
                clsPersonas persona = new clsPersonas(txtNombre.Text.ToString().Trim(), txtApellido.Text.ToString().Trim(), dtpFechaNac.Value.Date,
                                        SexoSeleccionado().Trim(), musicaSeleccionado().Trim(), cbxColor.SelectedItem.ToString());
                listadoPersonas.Add(persona);
                listaBindeable.ResetBindings();
                inizilizacion();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
            
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inizilizacion();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

           if(dgvLista.Rows.GetRowCount(DataGridViewElementStates.Selected)< 1){
                MessageBox.Show("Selceccione una fila");
                return;
            }
            clsPersonas persona = new clsPersonas();
            persona = (clsPersonas)dgvLista.CurrentRow.DataBoundItem;
            int i=listadoPersonas.IndexOf(persona);
            clsPersonas personaModificada = new clsPersonas(txtNombre.Text.ToString().Trim(), txtApellido.Text.ToString().Trim(), dtpFechaNac.Value.Date,
                                       SexoSeleccionado().Trim(), musicaSeleccionado().Trim(), cbxColor.SelectedItem.ToString());
            listadoPersonas[i] = personaModificada;
            listaBindeable.ResetBindings();
            inizilizacion();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsPersonas persona = new clsPersonas();

            if (dgvLista.Rows.GetRowCount(DataGridViewElementStates.Selected) < 1 )
            {
                MessageBox.Show("Selceccione una fila");
                return;
            }
            persona = (clsPersonas)dgvLista.CurrentRow.DataBoundItem;
            listadoPersonas.Remove(persona);
            listaBindeable.ResetBindings();
               

        }

        private void dgvLista_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rellenarFormulario();

        }

        private bool complobacion()
        {
            if(txtNombre.Text.Trim()!="" && txtApellido.Text.Trim()!="" && dtpFechaNac.Value.Date != DateTime.Now.Date
               && SexoSeleccionado()!=""&&musicaSeleccionado()!="" && cbxColor.SelectedIndex != -1)
            {
                return true;
            }
            return false;
        } 


        //busca si algun sexo fue seleccionado y lo devuelve
        private string SexoSeleccionado()
        {
            string sexo="";
            foreach (RadioButton item in gbxSexo.Controls)
            {
                if (item.Checked)
                {
                    sexo = item.Text.ToString();
                    
                }
            }
            return sexo;
        }

        //busca que estilos de musica fueron seleccionado
        // y lo devuelve en un estring separado por ","
        private string musicaSeleccionado()
        {
            string musica = "";
            foreach (CheckBox item in gbxEstiloMusical.Controls)
            {
                if (item.Checked)
                {
                    if (musica.Length > 0)
                    {
                        musica += ",";
                    }
                    musica += item.Text.Trim();
                }
            }
            return musica;
        }


        //caga inicial de colores
        private void cargarColor()
        {
            cbxColor.Items.Add("Rojo");
            cbxColor.Items.Add("Azul");
            cbxColor.Items.Add("Verde");
            cbxColor.Items.Add("Marron");
            cbxColor.Items.Add("Turquesa");
            cbxColor.Items.Add("Lila");
        }

        
        //vaica todos los controles de entrada
        private void inizilizacion()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            lblEdad.Text = "";
            dtpFechaNac.Value = DateTime.Now.Date;
            cbxColor.SelectedIndex = -1;
            foreach (CheckBox item in gbxEstiloMusical.Controls)
            {
                item.Checked = false;
            }
            foreach (RadioButton item in gbxSexo.Controls)
            {
                item.Checked = false;
            }
        }

        //rellena el formulario con las fila seleccionada del datagried
        private void rellenarFormulario() {
                Object objetoSeleccionado;
                objetoSeleccionado = dgvLista.CurrentRow.DataBoundItem;
                clsPersonas personaSeleccionada = (clsPersonas)objetoSeleccionado;
                txtApellido.Text = personaSeleccionada.Apellido;
                txtNombre.Text = personaSeleccionada.Nombre;
                dtpFechaNac.Value = personaSeleccionada.FechaNac;
                cbxColor.SelectedItem = personaSeleccionada.ColorFavorito;
                foreach (RadioButton item in gbxSexo.Controls)
                {
                    if (item.Text.ToString() == personaSeleccionada.Sexo)
                    {
                        item.Checked = true;
                    }
                }
            cargarMusica(personaSeleccionada.EstiloMusical);
               
        }


        //rellena pone en check los generos que con tenga el parametro estiloMusical
        private void cargarMusica(string estiloMusical)
        {
            string musica = estiloMusical;
            string genero;
            int i;
            while (musica.Length > 0)
            {
                i = musica.IndexOf(",");
                if (i < 0)
                {
                    i = musica.Length;
                }
                genero = musica.Substring(0, i);
                if (i == musica.Length)
                {
                    musica = musica.Remove(0, i);
                }
                else
                {
                    musica = musica.Remove(0, i + 1);
                }


                foreach (CheckBox item in gbxEstiloMusical.Controls)
                {
                    if (item.Text.ToString() == genero)
                    {
                        item.Checked = true;
                    }
                }
            }
        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaNac.Value.Date < DateTime.Today)
            {
                int edad = DateTime.Today.AddTicks(-dtpFechaNac.Value.Ticks).Year - 1;
                lblEdad.Text = edad.ToString();
            }
            else if(dtpFechaNac.Value.Date == DateTime.Today){
                return;
            }
            else
            {
               
                MessageBox.Show("Ingrese una fecha anterior a la actual");
                dtpFechaNac.Value = DateTime.Now;
            }
            

        }
    }
   
}
