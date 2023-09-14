public class Program
{

    static void Main(string[] args)
    {
 
        Funcionarios funcionario1 = new Funcionarios();
        Console.WriteLine($"Digite a matricula do funcionário 1: {funcionario1.matricula}");
        funcionario1.matricula = Console.ReadLine();
        Console.WriteLine($"Digite o nome do funcionário 1: {funcionario1.nome}");
        funcionario1.nome = Console.ReadLine();
        Console.WriteLine($"Digite o CPF do funcionário 1: {funcionario1.cpf}");
        funcionario1.cpf = Console.ReadLine();
        Console.WriteLine($"Digite o valor do salário do funcionário 1:");
        funcionario1.salario = Convert.ToDouble(Console.ReadLine());



         Funcionarios funcionario2 = new Funcionarios();
         Console.WriteLine($"Digite a matricula do funcionário 2: {funcionario2.matricula}");
         funcionario2.matricula = Console.ReadLine();
         Console.WriteLine($"Digite o nome do funcionário 2: {funcionario2.nome}");
         funcionario2.nome = Console.ReadLine();
         Console.WriteLine($"Digite o CPF do funcionário 2: {funcionario2.cpf}");
         funcionario2.cpf = Console.ReadLine();
         Console.WriteLine($"Digite o valor do salário do funcionário 2:");
         funcionario2.salario = Convert.ToDouble(Console.ReadLine());

         if(funcionario1.salario > funcionario2.salario)
         {
             Console.WriteLine($" O funcionario {funcionario1.nome} possui o salario de {funcionario1.salario} maior que o do funcionario {funcionario2.nome}");
         }
         if (funcionario2.salario > funcionario1.salario)
         {
             Console.WriteLine($" O funcionario {funcionario2.nome} possui o salario de {funcionario2.salario} maior que o do funcionario {funcionario1.nome}");
         }

    }


}



