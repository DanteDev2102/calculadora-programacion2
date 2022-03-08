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
            double num1, num2;

            // primera forma (if else)
            try
            {
                num1 = Convert.ToDouble(textbox_numero1.Text);
                num2 = Convert.ToDouble(textbox_numero2.Text);
                if (metodo == "sumar")
                {
                    resultado.Text = (num1 + num2).ToString();
                }
                else if (metodo == "restar")
                {
                    resultado.Text = (num1 - num2).ToString();
                }
                else if (metodo == "multiplicar")
                {
                    resultado.Text = (num1 * num2).ToString();
                }
                else if (metodo == "dividir")
                {
                    resultado.Text = (num1 / num2).ToString();
                }
                errorMessage.Text = "";
            }
            catch (Exception)
            {
                errorMessage.Text = "ERROR: no es posible realizar la operacion";
            }

            // segunda forma (switch resmuido) y la mas optima en este caso
            //var operacion = metodo switch
            //{
            //  "sumar" => (num1 + num2).ToString(),
            //  "restar" => (num1 - num2).ToString(),
            //  "multiplicar" => (num1 * num2).ToString(),
            //  "dividir" => (num1 / num2).ToString()            
            //};
            // resultado.Text = operacion;

            // tercera forma (switch tradicional)
            //switch (metodo)
            //{
            //    case "sumar":
            //        resultado.Text = (num1 + num2).ToString();
            //        break;
            //    case "restar":
            //        resultado.Text = (num1 - num2).ToString();
            //        break;
            //    case "multiplicar":
            //        resultado.Text = (num1 * num2).ToString();
            //        break;
            //    case "dividir":
            //        resultado.Text = (num1 / num2).ToString();
            //        break;
            //}
            
            // para probar cualquiera de las soluciones solo se debe agregar el codigo al bloque try
        }

        private void button_sumar_Click(object sender, EventArgs e)
        {
            calcular("sumar");
        }
        private void button_restar_Click(object sender, EventArgs e)
        {
            calcular("restar");
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            resultado.Text = "";
            textbox_numero1.Text = "";
            textbox_numero2.Text = "";
        }

        private void button_dividir_Click_1(object sender, EventArgs e)
        {
            calcular("dividir");
        }

        private void button_multiplicar_Click_1(object sender, EventArgs e)
        {
            calcular("multiplicar");
        }

        private void label_numero1_Click(object sender, EventArgs e) { }
        private void label_numero2_Click(object sender, EventArgs e) { }
        private void result_Click(object sender, EventArgs e) { }
        private void textbox_numero1_TextChanged(object sender, EventArgs e) { }
        private void textbox_numero2_TextChanged(object sender, EventArgs e) { }
        private void resultado_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }

    }
}
