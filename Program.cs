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
            exercicio10();
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
    }
}
