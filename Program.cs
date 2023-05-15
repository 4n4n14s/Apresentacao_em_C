﻿using System;
using System.Collections.Generic;

namespace didaticos.redimencionador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa ananias = new Pessoa ("lorenzo", 5, 25, 0.67);


            Console.WriteLine ($"eu sou {ananias.Name} e tenho {ananias.Idade}" +
                $" anos nasci no " +
                $"ano de {ananias.calculaAno(ananias.Idade, false)} e meu imc é " +
                $"{ananias.calculaImc(ananias.Peso,ananias.Altura)}" +
                $" minha força é {ananias.calcPower(ananias.Idade)}");
            foreach (var item in ananias.numeros)
            {
                Console.WriteLine(item);

            }


            Console.Read();
            


        }
        
    }
}
class Pessoa
{
    public string Name  {get; set;}
    public int Idade  {get; set;}
    public int Peso { get; set;}
    public double Altura { get; set;}

    public List<int> numeros { get; set;}



    public Pessoa(string name, int idade, int peso, double altura)
    {

        Name = name;
        Idade = idade;
        Peso = peso;
        Altura = altura;

        numeros = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            numeros.Add(i);

        }


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
