namespace FormularioEstudiantes
{
    public partial class Form1 : Form
    {
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //declarar las variables
            string nombres = texNombres.Text;
            string apellidos = texApellidos.Text;
            DateTime fechaMat = dtpFechaMatricula.Value;
            bool becado = chkBecado.Checked;




            //Agregar estudiantes (forma no recomendada
           //gvEstudiantes.Rows.Add(nombres, apellidos, fechaMat, becado);
        }
    }
}
