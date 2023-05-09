using System;

namespace didaticos.redimencionador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa ananias = new Pessoa ("ananias", 31, 80, 1.67);

            Console.WriteLine ($"eu sou {ananias.Name} e tenho {ananias.Idade}" +
                $" anos nasci no " +
                $"ano de {ananias.calculaAno(ananias.Idade, false)} e meu imc é " +
                $"{ananias.calculaImc(ananias.Peso,ananias.Altura)}" +
                $" minha força é {ananias.calcPower(ananias.Idade)}");
        }
    }
}
class Pessoa
{
    public string Name  {get; set;}
    public int Idade  {get; set;}
    public int Peso { get; set;}
    public double Altura { get; set;}

    public Pessoa(string name, int idade, int peso, double altura)
    {
    Name = name;
    Idade = idade;
    Peso = peso;
    Altura = altura;

    
    }
    public int calculaAno(int idade, bool aniversario)
    {
        if (aniversario == true)
        {
            int ano = 2023;
            int anoNacimento = ano - idade;
            return anoNacimento;


        }
        else
        {
            int ano = 2022;
            int anoNacimento = ano- idade;
            return anoNacimento;
        }

    }
    public double calculaImc(int peso, double altura)
    {
        double alturaQuadrado = altura * altura;
        return peso / alturaQuadrado;

    }public int calcPower(int idade)
    {
        int força = 10;

        for (int i = 1; i < idade; i++)
        {
            força = força + 10;
        }
        return força;
    }


}
