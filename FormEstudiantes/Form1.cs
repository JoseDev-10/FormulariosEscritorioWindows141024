namespace FormEstudiantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListarPer_Click(object sender, EventArgs e)
        {
            //Listar personas
            List<Persona> personas = new List<Persona>();

            for (int i = 1; i <= 20; i++)
            {
                personas.Add(new Persona
                {
                    PersonaId = i,
                    Nombres = "Nombres",
                    Apellidos = "Apellidos",
                    FechaNacimiento = "FechaNacimiento"
                });
            }
            //Mostrar la lista de los productos en la tabla
            dgvPersonas.DataSource = personas;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Mostrar las columnas registras y no generarlas automaticamente
            dgvPersonas.AutoGenerateColumns = false;
        }
    }
}
