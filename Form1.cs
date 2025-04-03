namespace CRUD
{
    public partial class Form1 : Form
    {
        public List<Cerveza> ListaCervezas { get; set; }
        public Form1()
        {
            InitializeComponent();
            ListaCervezas = new List<Cerveza>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cervezaform cervezaform = new Cervezaform();
            if (cervezaform.ShowDialog() == DialogResult.OK)
            {
                this.ListaCervezas.Add(cervezaform.cerveza);
                dgvCervezas.DataSource = this.ListaCervezas.ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dgvCervezas.DataSource = this.ListaCervezas;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cerveza? cervezaSeleccionada = (Cerveza)this.dgvCervezas.CurrentRow.DataBoundItem;
                Cervezaform cervezaform = new Cervezaform(cervezaSeleccionada);
                if (cervezaform.ShowDialog() == DialogResult.OK)
                {
                    Cerveza? editar = this.ListaCervezas.FirstOrDefault(c => c == cervezaSeleccionada);
                    editar = cervezaform.cerveza;
                    this.dgvCervezas.DataSource = this.ListaCervezas.ToList();
                }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cerveza? cervezaSeleccionada = (Cerveza)this.dgvCervezas.CurrentRow.DataBoundItem;
            this.ListaCervezas.Remove(cervezaSeleccionada);
            this.dgvCervezas.DataSource = this.ListaCervezas.ToList();
        }
    }
}
