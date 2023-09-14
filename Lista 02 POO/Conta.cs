using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Conta
{
    public string nomeTitular;

    public string numAgencia;

    public string numConta;

    public double saldoConta;
    
   

    public Conta(string nomeTitular, string numAgencia, string numConta, double saldoConta)
    {
        this.nomeTitular = nomeTitular;

        this.numAgencia = numAgencia;

        this.numConta = numConta;

        this.saldoConta = saldoConta;
    }

    //metodo do professor
    public double Depositar(double valor)
    {
        if (valor > 0)
        {
            this.saldoConta += valor;
            return this.saldoConta;
        }
        
        
        else
        {
            Console.WriteLine("Valor invalido!");
            return this.saldoConta;
        }
        

    }
    public double Sacar(double valor)
    {
        if (valor <= this.saldoConta && valor > 0)
        {
            this.saldoConta -= valor;

            


        }
        else
        {
            Console.WriteLine("Saldo insuficiente");

        }  
        return this.saldoConta;
    }

    public override string ToString()
    {
        return "\n Titular: "+this.nomeTitular + "\n Saldo R$ " + this.saldoConta+"\n";
    }


    /*public void Depositar(double valor)
    {

        if (valor > 0)
        {
            saldo += valor;

            Console.WriteLine($"Saldo após depósito: R$ {saldo}");            
        }

    }

    public double Sacar(double valor)
    {
        if(valor <= saldo)
        {
            saldo -= valor;

            Console.WriteLine($"Saldo atual após saque: R$ {saldo}");

            return saldo;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente");

            return saldo;
        }

    }*/

}