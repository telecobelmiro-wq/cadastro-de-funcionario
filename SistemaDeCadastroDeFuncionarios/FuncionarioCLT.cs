namespace SistemaDeCadastroDeFuncionarios
{

    public class FuncionarioClt : Funcionario
    {
        public double SalarioBase { get; set; }

        public FuncionarioClt(string nome, string cpf, double salarioBase)
            : base(nome, cpf, "CLT")
        {
            SalarioBase = salarioBase;
        }

        public override double CalcularSalario()
        {
            return SalarioBase;
        }

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Salário: {CalcularSalario():C}");
        }
    }

    
}
