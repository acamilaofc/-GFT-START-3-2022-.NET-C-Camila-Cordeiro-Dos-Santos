namespace CalcularImpostos.Classes
{
    public class Impostos
    {
        private double Valor { get; set; }
        private double ICMS { get; set; }
        private double IPI { get; set; }
        private double Confins { get; set; }
        private double ResultadoFinal { get; set; }

        public Impostos(double valor)
        {
            this.Valor = valor;
            this.ICMS = valor * 0.30;
            this.IPI = valor >= 25000 ? valor * 0.10 : valor * 0.05;
            this.Confins = valor >= 17000 ? valor * 0.08 : 0;
            this.ResultadoFinal = this.Valor + this.ICMS + this.IPI + this.Confins;
        }

        public override string ToString()
        {
            string retorno = $"ICMS: {this.ICMS.ToString("0.0")}" + Environment.NewLine;
            retorno += $"IPI: {this.IPI.ToString("0.0")}" + Environment.NewLine;
            retorno += $"CONFINS: {this.Confins.ToString("0.0")}" + Environment.NewLine;
            retorno += $"Valor Final: {this.ResultadoFinal.ToString("0.0")}";

            return retorno;
        }
    }
}