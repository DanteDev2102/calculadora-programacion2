namespace clase_basic
{
    public partial class Form1 : Form
    {
        private string opcion = "";
        public Form1()
        {
            InitializeComponent();
        }

        public int soloNumeros(int tecla)
        {
            return tecla switch
            {
                08 or
                46 or
                48 or
                49 or
                50 or
                51 or
                52 or
                53 or
                54 or
                55 or
                56 or
                57 or
                127 => tecla,
                _ => 0,
            };
        }
        public void calcular(string metodo)
        {
            try
            {
                double num1 = Convert.ToDouble(textbox_numero1.Text);
                double num2 = Convert.ToDouble(textbox_numero2.Text);
                double operacion = metodo switch
                {
                    "sumar" => (num1 + num2),
                    "restar" => (num1 - num2),
                    "multiplicar" => (num1 * num2),
                    "dividir" => (num1 / num2),
                    _ => throw new Exception()
                };
                if (double.IsInfinity(operacion) || double.IsNaN(operacion))
                {
                    throw new Exception();
                }
                errorMessage.Text = "";
                resultado.Text = operacion.ToString();
            }
            catch (Exception)
            {
                errorMessage.Text = "ERROR: operación no valida";
            }

        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            resultado.Clear();
            textbox_numero1.Clear();
            textbox_numero2.Clear();
        }
        private void textbox_numero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(soloNumeros(e.KeyChar));
        }
        private void textbox_numero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(soloNumeros(e.KeyChar));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            resultado.ReadOnly = true;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            opcion = comboBox_operaciones.Text.ToString();
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            calcular(opcion);
        }
    }
}

