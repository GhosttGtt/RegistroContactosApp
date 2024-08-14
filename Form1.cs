namespace RegistroContactosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreIngreso = this.InputNombre.Text;
            string telefonoIngreso = this.inputTelefono.Text;
            string mensajeIngreso = this.inputMensaje.Text;

            string salida1 = nombreIngreso;
            string salida2 = telefonoIngreso;
            string salida3 = mensajeIngreso;

            this.labelResultado1.Text = salida1.ToString();
            this.labelResutado2.Text = salida2.ToString();
            this.labelResultado3.Text = salida3.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void InputNombre_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void inputTelefono_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inputMensaje_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
