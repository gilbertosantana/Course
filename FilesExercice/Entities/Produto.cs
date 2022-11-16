using System.Globalization;

namespace FilesExercice.Entities
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Unidade { get; set; }

        public Produto(string nome, double valor, int unidade)
        {
            Nome = nome;
            Valor = valor;
            Unidade = unidade;
        }

        public double Total()
        {
            return Valor * Unidade;
        }

        public override string ToString()
        {
            return Nome + "," + Total().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
