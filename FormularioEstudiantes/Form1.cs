using System.ComponentModel;

namespace FormularioEstudiantes
{
    public partial class Form1 : Form
    {
        //BindingList, genera el ID automáticamente
        //Listar lista de estudiantes de forma genérica
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
        //BOTÓN AGREGAR
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

        //BOTÓN LISTAR
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

        //Listar los registros automáticamente
        void Listar()
        {
            dgvEstudiantes.DataSource = null;
            dgvEstudiantes.DataSource = estudiantes;
        }

        private void btnBinding_Click(object sender, EventArgs e)
        {
            //Botón Binding
            dgvEstudiantes.DataSource = estudiantesBinding;
        }

        private void btnInsertarBinding_Click(object sender, EventArgs e)
        {
            //Botón agregar - Binding
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
            //Botón eliminar Binding
            int elementofinal = estudiantesBinding.Count;
            estudiantesBinding.RemoveAt(elementofinal - 1);
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            //Cuenta y muestra la cantidad de elementos de la vista
            MessageBox.Show(estudiantesBinding.Count.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Se ejecuta cada cierto tiempo
            //Cuenta y muestra la cantidad de elementos de la vista cada cierto tiempo
            //MessageBox.Show(estudiantesBinding.Count.ToString());

            //El Timer se detiene si cuenta 3 elementos
            if (estudiantesBinding.Count == 3)
            {
                timer1.Stop();
            }
            MessageBox.Show(estudiantesBinding.Count.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Iniciamos el Timer
            //timer1.Start();

            //Iniciamos y mostramos la hora en el formulario
            timerHora.Start();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Iniciamos el Timer
            timer1.Start();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            //Detenemos el timer
            timer1.Stop();
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            //Mostramos la fecha y hora en el label
            lblHora.Text = DateTime.Now.ToLocalTime().ToString();
        }
    }
}
