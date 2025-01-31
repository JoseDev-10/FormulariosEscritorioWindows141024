namespace FormulariosEscritorioWindows141024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //Listar los productos
            List<Producto> productos = new List<Producto>();
            for (int i = 1; i <= 20; i++)
            {
                productos.Add(new Producto
                {
                    ProductoId = i,
                    Nombre = "Nombre",
                    Descripcion = "Descripcion",
                    Precio = 200
                });
            }
            //Mostrar la lista de los productos en la tabla
            dgvProductos.DataSource = productos;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Mostrar las columnas registras y no generarlas automaticamente
            dgvProductos.AutoGenerateColumns = false;
        }
    }
}