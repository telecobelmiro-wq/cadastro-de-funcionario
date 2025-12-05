using System;

public abstract class Funcionario
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Tipo { get; set; }

    public abstract double CalcularSalario();

    public Funcionario(string nome, string cpf, string tipo)
    {
        Nome = nome;
        Cpf = cpf;
        Tipo = tipo;
    }

    public virtual void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"CPF: {Cpf}");
        Console.WriteLine($"Tipo: {Tipo}");
    }
}
