namespace SistemaDeCadastroDeFuncionarios
{
    public class FuncionarioTerceirizado : Funcionario
    {
        public double HorasTrabalhadas { get; set; }
        public double ValorHora { get; set; }

        public FuncionarioTerceirizado(string nome, string cpf, double horasTrabalhadas, double valorHora)
            : base(nome, cpf, "Terceirizado")
        {
            HorasTrabalhadas = horasTrabalhadas;
            ValorHora = valorHora;
        }

        public override double CalcularSalario()
        {
            return HorasTrabalhadas * ValorHora;
        }

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Salário: {CalcularSalario():C}");
        }
    }

}
