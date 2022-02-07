namespace TrabalhandoComArrays.Classes
{
    public static class TrabalhandoArrays
    {
        public static string ArrayInfo(int[] array)
        {
            string retorno = $"Soma: {array.Sum()}" + Environment.NewLine;
            retorno += $"Maior valor: {array.Max()}" + Environment.NewLine;
            retorno += $"Menor valor: {array.Min()}" + Environment.NewLine;
            retorno += $"Média dos valores: {array.Average()}" + Environment.NewLine;
            if ((array.Length % 2) != 0)
                retorno += $"Mediana dos valores: {array[(array.Length / 2)]}";
            else retorno += $"Mediana dos valores: {(array[(array.Length / 2) - 1] + array[(array.Length / 2)]) / 2} ";


            return retorno;
        }
    }
}