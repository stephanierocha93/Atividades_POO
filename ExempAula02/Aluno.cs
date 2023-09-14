public class Aluno
{
    public string nome;
    public string cpf;
    public string matricula;
    //public DateOnly dataNasc;  NÃO ESTA FUNCIONANDO
    public double n1, n2;

    //###  EXEMPLO 01  ####

    /* public double Media()
    {
        double media = (n1 + n2) / 2;
        return media;
    }*/



    //###  EXEMPLO 02  ####
   /* public double Media(double n1, double n2)
    {
        double media = (n1 + n2) / 2;
        return media;
    }*/


    //###  EXEMPLO 03  ####
    public Aluno(string nome, string cpf)
    {
        this.nome = nome;
        this.cpf = cpf;
    }
}