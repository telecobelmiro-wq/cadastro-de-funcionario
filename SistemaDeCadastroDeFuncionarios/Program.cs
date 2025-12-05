using System;
using System.Collections.Generic;
using SistemaDeCadastroDeFuncionarios;

public class Program
{
    static void Main()
    {
        List<Funcionario> funcionarios = new List<Funcionario>();

        int opcao = 0;
        do
        {
            Console.WriteLine("\nMENU DA EMPRESA TELECOM");
            Console.WriteLine("1 - Cadastrar funcionários");
            Console.WriteLine("2 - Listar funcionários");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha uma opção: ");

            string entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out opcao))
            {
                Console.WriteLine("Opção invalida. Digite somente numeros cara.");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    CadastrarFuncionario(funcionarios);
                    break;
                case 2:
                    ListarFuncionarios(funcionarios);
                    break;
                case 3:
                    Console.WriteLine("Fechando tudooo...");
                    break;
                default:
                    Console.WriteLine("Opção invalida.");
                    break;
            }

        } while (opcao != 3);
    }

    static void CadastrarFuncionario(List<Funcionario> funcionarios)
    {
        Console.WriteLine("\nEscolha o tipo de funcionario:");
        Console.WriteLine("1 - CLT");
        Console.WriteLine("2 - Estagiario");
        Console.WriteLine("3 - Terceirizado");
        Console.Write("Escolhe uma opção ai malandro: ");

        if (!int.TryParse(Console.ReadLine(), out int tipoFuncionario))
        {
            Console.WriteLine("Tipo invalido.");
            return;
        }

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("CPF: ");
        string cpf = Console.ReadLine();

        switch (tipoFuncionario)
        {
            case 1:
                Console.Write("Digite o salário base: ");
                if (!double.TryParse(Console.ReadLine(), out double salarioBase))
                {
                    Console.WriteLine("Valor invalido!");
                    return;
                }

                funcionarios.Add(new FuncionarioClt(nome, cpf, salarioBase));
                break;

            case 2:
                Console.Write("Digite o valor da bolsa auxílio: ");
                if (!double.TryParse(Console.ReadLine(), out double bolsaAuxilio))
                {
                    Console.WriteLine("Valor inválido!");
                    return;
                }

                Console.Write("Digite o valor do vale transporte: ");
                if (!double.TryParse(Console.ReadLine(), out double valeTransporte))
                {
                    Console.WriteLine("Valor invalido!");
                    return;
                }

                funcionarios.Add(new FuncionarioEstagiario(nome, cpf, bolsaAuxilio, valeTransporte));
                break;

            case 3:
                Console.Write("Digite o nmero de horas trabalhadas: ");
                if (!double.TryParse(Console.ReadLine(), out double horasTrabalhadas))
                {
                    Console.WriteLine("Valor invalido!");
                    return;
                }

                Console.Write("Digite o valor da hora: ");
                if (!double.TryParse(Console.ReadLine(), out double valorHora))
                {
                    Console.WriteLine("Valor invalido!");
                    return;
                }

                funcionarios.Add(new FuncionarioTerceirizado(nome, cpf, horasTrabalhadas, valorHora));
                break;

            default:
                Console.WriteLine("Opção de tipo inválida.");
                return;
        }

        Console.WriteLine("Funcionário cadastrado com sucesso daquele jeitão!");
    }

    static void ListarFuncionarios(List<Funcionario> funcionarios)
    {
        Console.WriteLine("\nLista de funcionarios:");

        if (funcionarios.Count == 0)
        {
            Console.WriteLine("Nenhum funcionario cadastrado.");
            return;
        }

        foreach (var funcionario in funcionarios)
        {
            funcionario.ExibirDados();
            Console.WriteLine("-----------------------------");
        }
    }
}
