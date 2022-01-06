using System;

namespace Ejercicio1;

public class Animal : IAnmial
{
    public string tipo { get; set; }

    public Animal(string tipo)
    {
        this.tipo = tipo;
    }

    public void andar()
    {
        Console.WriteLine("el animal está andando");
    }

    public bool esPerro()
    {
        return tipo.Equals("perro");
    }

    public void saltar()
    {
        Console.WriteLine("el animal está saltando");
    }
}