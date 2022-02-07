namespace CaixaDeMercado.Classes
{
    public class Produto
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }
        public int Tipo { get; private set; }

        public Produto(string Nome, double Valor, int Tipo)
        {
            this.Nome = Nome;
            this.Valor = Valor;
            this.Tipo = Tipo;
        }
    }
}