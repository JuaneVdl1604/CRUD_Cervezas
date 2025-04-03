using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Cervezaform : Form
    {
        public Cerveza cerveza { get; set; }
        public Cervezaform()
        {
            InitializeComponent();
            this.cerveza = new Cerveza();
        }
        public Cervezaform(Cerveza cerveza) : this()
        {
            this.cerveza = cerveza;
            txtID.Text = cerveza.Id.ToString();
            txtNombre.Text = cerveza.Name;
            txtEstilo.Text = cerveza.Estilo;
            txtAlcohol.Text = cerveza.Alcohol.ToString();
            txtPrecio.Text = cerveza.Precio.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.cerveza.Id = 1;
            this.cerveza.Name = txtNombre.Text;
            this.cerveza.Estilo = txtEstilo.Text;
            this.cerveza.Alcohol = double.Parse(txtAlcohol.Text);
            this.cerveza.Precio = double.Parse(txtPrecio.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}

