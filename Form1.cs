using System.Reflection.Metadata;

namespace ParametrosValorRef
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //implementação das sub-rotinas
        void porValor(double varA, double varB)
        {


            //altera o valor das variaveis locais que são passadas por valor
            //não altera os valores das variavies originais (declaradas no botão Por Valor)
            //essas alterações sãi válidas somente dentro deste escopo

            varA = varA * 2;
            varB = varB * 5;

        }

        void porReferencia(ref double varA, ref double varB)
        {
            //altera o valor das variaveis locais que são passadas por referência
            //altera os valores das variavies originais (declaradas no botão Por Referência)
            //essas alterações sãi válidas em todo o programa
            varA = varA * 2;
            varB = varB * 5;
        }

        void limparControles()
        {
            //limpa os controles de texto
            txtResA.Clear();
            txtResB.Clear();

        }

        private void btnValor_Click(object sender, EventArgs e)
        {
            //declaração das variavies originais
            double varA, varB;

            //entrada de dados
            varA = Convert.ToDouble(txtVarA.Text);
            varB = Convert.ToDouble(txtVarB.Text);

            //chama o procedimento porValor passando os parametros por valor
            //ou seja, passando somente os valores das variaveis originais
            porValor(varA, varB);

            //chama o procedimento limparControles para limpar os controles de texto
            limparControles();

            //saída de dados para verificar que não houve alteração no valor da variavel original
            //os valores das variaveis originais permanecem os mesmos
            txtResA.Text = varA.ToString();
            txtResB.Text = varB.ToString();


        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            //declaração das variaveis originais
            double varA, varB;

            //entrada de dados
            varA = Convert.ToDouble(txtVarA.Text);
            varB = Convert.ToDouble(txtVarB.Text);

            //chama o procedimento porReferencia passando os parametros por referência
            porReferencia(ref varA, ref varB);

            //chama o procedimento limparControles para limpar os controles de texto
            limparControles();

            //saida de dados para verificar que houve alteração no valor da variavel original
            //os valores das variaveis foram alterados, pois foram passados por referência
            txtResA.Text = varA.ToString();
            txtResB.Text = varB.ToString();
        }
    }

}