namespace SistemaDeCadastroDeFuncionarios
{
    public class FuncionarioEstagiario : Funcionario
    {
        public double BolsaAuxilio { get; set; }
        public double ValeTransporte { get; set; }

        public FuncionarioEstagiario(string nome, string cpf, double bolsaAuxilio, double valeTransporte) : base(nome, cpf, "Estagiário")
        {
            BolsaAuxilio = bolsaAuxilio;
            ValeTransporte = valeTransporte;
        }

        public override double CalcularSalario()
        {
            return BolsaAuxilio + ValeTransporte;
        }

        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Salário: {CalcularSalario():C}");
        }
    }

    
}
