namespace Calculadora_Estruturada
{
    public partial class Form1 : Form
    {

        public float num1 = 0;
        public float num2 = 0;

        Calculadora calculadora = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            //Estrutura
            //res.Text = "O Resultado é: " + (num1 + num2).ToString(); 

            //POO

            calculadora = new Calculadora(num1, num2);
            res.Text = "O Resultado é: " + calculadora.Soma().ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            //Estrutura
            //res.Text = "O Resultado é: " + (num1 - num2).ToString();

            //POO

            calculadora = new Calculadora(num1, num2);
            res.Text = "O Resultado é: " + calculadora.Subtrair(num1, num2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtNum1.Text);
            num2 = float.Parse(txtNum2.Text);
            //Estrutura
            //res.Text = "O Resultado é: " + (num1 * num2).ToString();

            //POO

            calculadora = new Calculadora(num1, num2);
            res.Text = "O Resultado é: " + calculadora.Multiplicacao().ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtNum1.Text);
            num2 = float.Parse(txtNum2.Text);
            //Estrutura
            //res.Text = "O Resultado é: " + (num1 / num2).ToString();

            //POO

            calculadora = new Calculadora(num1, num2);
            res.Text = "O Resultado é: " + calculadora.Dividir().ToString();
        }
    }
}