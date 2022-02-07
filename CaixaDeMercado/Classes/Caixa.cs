namespace CaixaDeMercado.Classes
{
    public class Caixa
    {
        public double CalcularValorFinal(Produto produto, int quantidade)
        {
            double valorfinal = 0;
            switch (produto.Tipo)
            {
                case 1:
                    valorfinal = (produto.Valor * quantidade) * 0.9;
                    break;
                case 2:
                    valorfinal = (produto.Valor * quantidade) * 0.8;
                    break;
                case 3:
                    if (quantidade >= 5) valorfinal = (produto.Valor * quantidade) * 0.9;
                    break;
                default:
                    Console.WriteLine("Tipo inválido");
                    break;
            }
            return valorfinal;
        }
    }
}