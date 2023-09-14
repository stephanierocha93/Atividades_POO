using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //###  EXEMPLO 01  ####

            /*Aluno aluno1 = new Aluno();
            aluno1.nome = "Maria";
            aluno1.cpf = "12345678901";
            aluno1.matricula = "01";
            aluno1.n1 = 30;
            aluno1.n2 = 8;
            double media = aluno1.Media();
            Console.WriteLine($"A média do aluno(a) {aluno1.nome} é {media}");

            Aluno aluno2 = new Aluno();
            aluno2.nome = "João";
            aluno2.cpf = "98765432102";
            aluno2.matricula = "01";
            aluno2.n1 = 45;
            aluno2.n2 = 35;
            aluno2.Media();
            media = aluno2.Media();
            Console.WriteLine($"A média do  aluno(a) {aluno2.nome} é {media}");

            Console.ReadKey();*/

            //###  EXEMPLO 02  ####

            Aluno aluno1 = new Aluno();
            aluno1.nome = "Maria";
            aluno1.cpf = "12345678901";
            aluno1.matricula = "01";
            
            double media = aluno1.Media(20,45);
            Console.WriteLine($"A média do aluno(a) {aluno1.nome} é {media}");

            Aluno aluno2 = new Aluno();
            aluno2.nome = "João";
            aluno2.cpf = "98765432102";
            aluno2.matricula = "01";
            ;
            media = aluno2.Media(30,25);
            Console.WriteLine($"A média do  aluno(a) {aluno2.nome} é {media}");

            Console.ReadKey();


            //###  EXEMPLO 03  ####
        }

    }
}
