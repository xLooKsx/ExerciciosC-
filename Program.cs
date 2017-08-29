using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            exercicio2();
            exercicio4();
            exercicio6();
            exercicio8();
            exercicio10();

            ex1();
            ex3();
            ex5();
            ex7();
            ex9();
            Console.ReadKey();
        }

        private static void exercicio2() {
            int num = 0;
            while ((7*num) < 200)
            {                
                Console.WriteLine("7 x " + num + " = " + 7 * num);
                num++;
            }
        }

        public static void exercicio4() {
            Console.WriteLine("Digite o valor de X");
            String entrada = Console.ReadLine();
            double numero = Convert.ToDouble(entrada);            
            double respImpar = 0;
            double respPar = 0;

            for (int i = 1; i < 19; i+=2)
            {
                respImpar += (numero / i);
            }

            for (int j = 2; j < 20; j+=2)
            {
                respPar -= (numero / j);
            }
            Console.WriteLine("O valor de S é :" + (respImpar+respPar));
        }

        public static void exercicio6() {

            Console.WriteLine("Digite o numero desejado para a tabuada ou digite -1 para sair:");
            String entrada = Console.ReadLine();
            int numero = Convert.ToInt16(entrada);
            while (numero != -1)
            {
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine(numero + "x" + i + " =" + (numero * i));
                }

                Console.WriteLine("Digite o numero desejado para a tabuada ou digite -1 para sair:");
                entrada = Console.ReadLine();
                numero = Convert.ToInt16(entrada);
            }
            Console.WriteLine("Programa Finalizado");
        }

        public static void exercicio8() {
            Console.WriteLine("Quantas notas deseja ler?");
            String entrada = Console.ReadLine();
            double numero = Convert.ToInt16(entrada);
            int cont = 0;
            double total = 0;
            double vlrNota = 0;

            String notasMenores = "";
            String notasMaiores = "";

            List<double> notas = new List<double>();
            while (cont < numero) {
                Console.Write("Insira o valor da primeira nota: ");
                String entradaNota = Console.ReadLine();
                vlrNota = Convert.ToInt16(entradaNota);
                notas.Add(vlrNota);
                total += vlrNota;
                cont++;
            }

            foreach (double notaDaVez in notas)
            {
                if (notaDaVez < (total / numero))
                {
                    notasMenores += notaDaVez+", ";

                }
                else {
                    notasMaiores += notaDaVez+", ";
                }
            }

            Console.WriteLine("Média: "+total/numero);
            Console.WriteLine("Notas maiores que a media: "+ notasMaiores);
            Console.WriteLine("Notas menores que a media: " + notasMenores);
        }

        public static void exercicio10() {
            Console.WriteLine("Digite o salario ou digite -1 para sair:");
            String entrada = Console.ReadLine();
            double numero = Convert.ToInt16(entrada);

            List<double> salarios = new List<double>();
            List<double> salarioAjustado = new List<double>();
            while (numero != -1)
            {
                salarios.Add(numero);

                Console.WriteLine("Digite o salario ou digite -1 para sair:");
                entrada = Console.ReadLine();
                numero = Convert.ToInt16(entrada);
            }
            Console.WriteLine("Digite o Valor de reajuste:");
            String entradaReajuste = Console.ReadLine();
            double vlrReajuste = Convert.ToInt16(entradaReajuste);

            foreach (double SalarioDaVez in salarios)
            {
                salarioAjustado.Add(SalarioDaVez + vlrReajuste);
            }
            foreach (double ajusteDaVez in salarioAjustado)
            {
                Console.WriteLine("Salarios Ajustados: " + ajusteDaVez);
            }
        }

        static void ex1()
        {
            int soma = 0;
            for (int i = 1; i <= 100; i++)
            {
                soma += i;
                Console.WriteLine(soma);
            }
            Console.ReadKey();
        }

        static void ex3()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }

        static void ex5()
        {
            int num = 5;
            int mult;

            for (int i = 0; i <= 10; i++)
            {
                mult = num * i;
                Console.WriteLine(mult);
            }
            int cont = 0;
            while (cont <= 10)
            {
                mult = num * cont;
                Console.WriteLine(mult);
                cont++;
            }
            Console.ReadKey();
        }

        static void ex7()
        {
            double valorCompra = 0.0, soma = 0.0;
            String tipoCompra;
            double[] vendasPrazo = new double[5];
            double[] vendasVista = new double[5];
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Qual o valor da venda: ");
                valorCompra = Convert.ToDouble(Console.Read());

                // v para vendas a vista, e p para vandas a prazo
                Console.WriteLine("Digite o codigo do tipe de venda: ");
                tipoCompra = Convert.ToString(Console.Read());

                if (tipoCompra == "v")
                {
                    vendasVista[i] = valorCompra;
                }
                else
                {
                    vendasPrazo[i] = valorCompra;
                }
            }

            for (int i = 0; i <= vendasPrazo.Length; i++)
            {
                soma += i;
            }
            Console.WriteLine("Este é o valor total das compras a prazo: " + soma);

            for (int i = 0; i <= vendasVista.Length; i++)
            {
                soma += i;
            }
            Console.WriteLine("Este é o valor total das compras a vista: " + soma);

            for (int i = 0; i <= vendasPrazo.Length; i++)
            {
                soma += i;
                for (int j = 0; j <= vendasVista.Length; j++)
                {
                    soma += j;
                }
            }
            Console.WriteLine("Este é o valor de vendas feitas hoje" + DateTime.Today + " é: " + soma);
        }

        static void ex9()
        {
            int soma = 0, media = 0;
            Console.WriteLine("Informe a quantidade de alunos que serão inseridos: ");
            String quant = Console.ReadLine();
            int quantidadeAlunos1 = Convert.ToInt32(quant);

            String[] nome = new String[quantidadeAlunos1];
            int[] nota = new int[quantidadeAlunos1];

            for (int i = 0; i < quantidadeAlunos1; i++)
            {
                Console.WriteLine("Insira o Nome do Aluno nº " + i);
                nome[i] = Console.ReadLine();

                Console.WriteLine("Insira a Nota do Aluno nº " + i);
                nota[i] = Convert.ToInt32(Console.ReadLine());

                soma = soma + nota[i];
            }
            media = soma / quantidadeAlunos1;

            Console.WriteLine("Alunos com Nota Maior que a Média da Turma");

            for (int i = 0; i < quantidadeAlunos1; i++)
            {
                if (nota[i] > media)
                {
                    Console.WriteLine(nome[i] + " - ");
                    Console.WriteLine(nota[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
