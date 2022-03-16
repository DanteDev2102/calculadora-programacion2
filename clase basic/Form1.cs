namespace clase_basic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void calcular(string metodo)
        {
            try
            {
                double num1 = Convert.ToDouble(textbox_numero1.Text);
                double num2 = Convert.ToDouble(textbox_numero2.Text);
                resultado.Text = num1.ToString();
                string operacion = metodo switch
                {
                    "sumar" => (num1 + num2).ToString(),
                    "restar" => (num1 - num2).ToString(),
                    "multiplicar" => (num1 * num2).ToString(),
                    "dividir" => (num1 / num2).ToString(),
                    _ => throw new NotImplementedException()
                };

                if (
                    double.IsNaN(Convert.ToDouble(resultado.Text)) ||
                    double.IsInfinity(Convert.ToDouble(resultado.Text))
                   )
                {
                    errorMessage.Text = "ERROR: no es posible realizar la operacion";
                }
                else
                {
                    errorMessage.Text = "";
                    resultado.Text = operacion;
                }
            }
            catch (Exception)
            {
                errorMessage.Text = "ERROR: no es posible realizar la operacion";
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_sumar.Checked)
            {
                calcular("sumar");
            }
        }
        private void radioButton_restar_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_restar.Checked)
            {
                calcular("restar");
            }
        }
        private void radioButton_multiplicar_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_multiplicar.Checked)
            {
                calcular("multiplicar");
            }
        }
        private void radioButton_dividir_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton_dividir.Checked)
            {
                calcular("dividir");
            }
        }
        private void button_reset_Click(object sender, EventArgs e)
        {
            resultado.Clear();
            textbox_numero1.Clear();
            textbox_numero2.Clear();
        }
        private void label_numero1_Click(object sender, EventArgs e) { }
        private void label_numero2_Click(object sender, EventArgs e) { }
        private void result_Click(object sender, EventArgs e) { }
        private void textbox_numero1_TextChanged(object sender, EventArgs e) { }
        private void textbox_numero2_TextChanged(object sender, EventArgs e) { }
        private void resultado_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void groupBox_Enter(object sender, EventArgs e) { }
    }
}

