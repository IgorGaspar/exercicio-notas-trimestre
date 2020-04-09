using System;
using System.Globalization;

namespace ExercicioNotasTrimestre {
    class Program {
        static void Main(string[] args) {

            /* Programa que solicita ao usuário entrar com os dados
             * do aluno, as notas do mesmo, realiza o cálculo da
             * média das notas do aluno e retorna se ele foi aprovado
             * ou reprovado neste ano. */

            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " 
                + aluno.Media().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.Aprovado()) {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " 
                    + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) 
                    + " PONTOS");
            }
        }
    }
}
