using System.ComponentModel;

namespace FormularioEstudiantes
{
    public partial class Form1 : Form
    {
        //BindingList, genera el ID autom�ticamente
        //Listar lista de estudiantes de forma gen�rica
        List<Estudiante> estudiantes = new List<Estudiante>();

        BindingList<Estudiante> estudiantesBinding = new BindingList<Estudiante>();

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
        //BOT�N AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                //declarar las variables
                string nombres = texNombres.Text;
                string apellidos = texApellidos.Text;
                DateTime fechaMat = dtpFechaMatricula.Value;
                bool becado = chkBecado.Checked;

                //Agregando estudiantes (forma recomendada)
                estudiantes.Add(new Estudiante
                {
                    IdEstudiante = estudiantes.Count + 1,
                    apellidos = apellidos,
                    nombres = nombres,
                    becado = becado,
                    fechamat = fechaMat
                });

                //Limpiar
                Limpiar();

                //Mensaje de registro exitoso
                MessageBox.Show("Registro exitoso");

                //Listar
                Listar();
            }
            catch (Exception)
            {

                //Mensaje de error
                MessageBox.Show("Error. No se guardo el registro");

                //throw ex;
            }

            //Agregar estudiantes (forma no recomendada
            //dgvEstudiantes.Rows.Add(nombres, apellidos, fechaMat, becado);
        }

        //BOT�N LISTAR
        private void btnListar_Click(object sender, EventArgs e)
        {

            //Listar los registros
            Listar();

            //Limpiar primero la tabla
            //dgvEstudiantes.DataSource = null;
            //dgvEstudiantes.DataSource = estudiantes;

        }

        //Limpiar los campos de texto
        void Limpiar()
        {
            texNombres.Text = "";
            texApellidos.Text = "";
            chkBecado.Checked = false;
            dtpFechaMatricula.Value = DateTime.Now;
        }

        //Listar los registros autom�ticamente
        void Listar()
        {
            dgvEstudiantes.DataSource = null;
            dgvEstudiantes.DataSource = estudiantes;
        }

        private void btnBinding_Click(object sender, EventArgs e)
        {
            //Bot�n Binding
            dgvEstudiantes.DataSource = estudiantesBinding;
        }

        private void btnInsertarBinding_Click(object sender, EventArgs e)
        {
            //Bot�n agregar - Binding
            try
            {

                //declarar las variables
                string nombres = texNombres.Text;
                string apellidos = texApellidos.Text;
                DateTime fechaMat = dtpFechaMatricula.Value;
                bool becado = chkBecado.Checked;

                //Agregando estudiantes (forma recomendada)
                estudiantesBinding.Add(new Estudiante
                {
                    IdEstudiante = estudiantesBinding.Count + 1,
                    apellidos = apellidos,
                    nombres = nombres,
                    becado = becado,
                    fechamat = fechaMat
                });

                //Limpiar
                Limpiar();

                //Mensaje de registro exitoso
                MessageBox.Show("Registro exitoso");

                //Listar
                //Listar();
            }
            catch (Exception)
            {

                //Mensaje de error
                MessageBox.Show("Error. No se guardo el registro");

                //throw ex;
            }
        }

        private void btnEliminarBinding_Click_1(object sender, EventArgs e)
        {
            //Bot�n eliminar Binding
            int elementofinal = estudiantesBinding.Count;
            estudiantesBinding.RemoveAt(elementofinal -1);
        }
    }
}
