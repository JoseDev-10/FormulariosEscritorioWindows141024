namespace FormularioEstudiantes
{
    public partial class Form1 : Form
    {
        //BindingList
        //Listar lista de estudiantes de forma genérica
        List<Estudiante> estudiantes = new List<Estudiante>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //BOTÓN AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try {

                //declarar las variables
                string nombres = texNombres.Text;
                string apellidos = texApellidos.Text;
                DateTime fechaMat = dtpFechaMatricula.Value;
                bool becado = chkBecado.Checked;

                //Agregando estudiantes (forma recomendada)
                estudiantes.Add(new Estudiante
                {
                    IdEstudiante = estudiantes.Count+1,
                    apellidos = apellidos,
                    nombres = nombres,
                    becado = becado,
                    fechamat = fechaMat
                });
                //Mensaje de registro exitoso
                MessageBox.Show("Registro exitoso");
            }
            catch (Exception) {

                //Mensaje de error
                MessageBox.Show("Error. No se guardo el registro");

                //throw ex;
            }

            //Agregar estudiantes (forma no recomendada
            //dgvEstudiantes.Rows.Add(nombres, apellidos, fechaMat, becado);
        }

        //BOTÓN LISTAR
        private void btnListar_Click(object sender, EventArgs e)
        {
            //Limpiar primero la tabla
            dgvEstudiantes.DataSource = null;

            dgvEstudiantes.DataSource = estudiantes;

        }
    }
}
