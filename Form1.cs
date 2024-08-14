using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RegistroContactosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ButtonEnviar.Enabled = false;
        }
        private void validarCampo()
        {
            var vr = !string.IsNullOrEmpty(inputNombre.Text) &&
                !string.IsNullOrEmpty(inputTelefono.Text) &&
                !string.IsNullOrEmpty(inputMensaje.Text);
           ButtonEnviar.Enabled = vr;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string nombreIngreso = this.inputNombre.Text;
            string telefonoIngreso = this.inputTelefono.Text;
            string mensajeIngreso = this.inputMensaje.Text;

            string salida1 = nombreIngreso;
            string salida2 = telefonoIngreso;
            string salida3 = mensajeIngreso;

            this.labelResultado1.Text = salida1.ToString();
            this.labelResutado2.Text = salida2.ToString();
            this.labelResultado3.Text = salida3.ToString();
            MessageBox.Show("Formulario enviado Correctamente");
        }
       
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void InputNombre_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void validarNumero()
        {

            int resultadoNumerico = 0;
            bool value = Int32.TryParse(inputTelefono.Text, out resultadoNumerico);


            if (value)
            {
                Console.WriteLine($"Converted '{value}' to {resultadoNumerico}.");
            }
            else {
                if (inputTelefono.Text.Length == 0)
                {
                    inputTelefono.Text = inputTelefono.Text[..^0];
                    MessageBox.Show("El número de teléfono debe incluir unicamente números");
                }
                else {
                    inputTelefono.Text = inputTelefono.Text[..^1];
                    MessageBox.Show("El número de teléfono debe incluir unicamente números");
                }
               
                
            }
       
        }
        private void inputTelefono_TextChanged(object sender, EventArgs  e)
        {
            validarNumero();
            validarCampo();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inputMensaje_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        
    }
}
