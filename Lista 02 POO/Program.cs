using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {

        /*
        Conta conta = new Conta("Joana", 789, 37069, 55000);

        Console.WriteLine($"Titular: {conta.nomeTitular}\nAgencia: {conta.numAgencia}\nConta: {conta.numConta}\n************\nSaldo: R$ {conta.saldoConta}");

        Console.WriteLine($"************\nValor do deposito: R$ 3.500,00");

        conta.Depositar(3500);

        Console.WriteLine($"Saldo atual após depósito: R$ {conta.saldoConta}");
        
        Console.WriteLine($"************\nValor do saque: R$ 5.000,00");

        conta.Sacar(5000);

        Console.WriteLine($"Saldo atual após saque: R$ {conta.saldoConta}");

        Console.ReadKey();

        */

        List<Conta> contas = new List<Conta>();

        while (true)
        {
            Console.WriteLine("Digite:\n 1 para cadastrar uma conta\n 2 para listar");
            int opcao =Convert.ToInt32(Console.ReadLine());
            if(opcao == 1)
            {
                Console.Write("Digite o nome do titular: ");
                string nomeTitular = Console.ReadLine();

                Console.Write("Digite o número da agência: ");
                string numAgencia = Console.ReadLine();

                Console.Write("Digite o número da conta: ");
                string numConta = Console.ReadLine();

                Console.Write("Digite o saldo inicial: ");
                double saldo = double.Parse(Console.ReadLine());

                Conta conta = new Conta(nomeTitular, numAgencia, numConta, saldo);
                contas.Add(conta);

                
            }

            else if (opcao == 2)
            {
                foreach (Conta conta in contas)
                {
                    Console.WriteLine(conta.ToString());
                }

            }
            else
            {
                break;
            }
               
        }
        


    }
}