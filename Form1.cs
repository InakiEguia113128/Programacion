using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pila
{
    public partial class frmPila : Form
    {
        Pila oPila = new Pila("",5);
        public frmPila()
        {
            InitializeComponent();
        }

        private void frmPila_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {         
            string elemento = txtElemento.Text;
            oPila.Anadir(elemento);

            CargarLista(lstElementos); 
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El primer elemento es {oPila.Primero()}");
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            oPila.Extraer();
            CargarLista(lstElementos);
        }

        public void CargarLista(ListBox lstElementos)
        {
            lstElementos.Items.Clear();
            foreach (string st in oPila.Array)
            {
                if (st != null)
                {
                    lstElementos.Items.Add(st);
                }
            }
            if (lstElementos.Items.Count == oPila.Array.Length)
            {
                MessageBox.Show("Se alcanzo el limte de elementos");
                btnAgregar.Enabled = false;
            }

        }

        private void btnEstaVacia_Click(object sender, EventArgs e)
        {
            if (oPila.EstaVacia() == true)
            {
                lblEstado.Text = "La pila no tiene elementos";
            }
            else
            {
                lblEstado.Text = "La pila contiene elementos";
            }
        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }
    }
}
