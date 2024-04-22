namespace exemploTdd.Models
{
    public class Calculadora
    {
        private List<string> _historico = new List<string>();

        public int Somar(int a, int b)
        {
            AdicionarHistorico($"Soma de {a} com {b}");
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            AdicionarHistorico($"Subtração de {a} por {b}");
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            AdicionarHistorico($"Multiplicação de {a} por {b}");
            return a * b;
        }

        public int Dividir(int a, int b)
        {
            AdicionarHistorico($"Divisão de {a} por {b}");
            return a / b;
        }

        public void AdicionarHistorico(string operacao)
        {
            _historico.Add(operacao);
        }

        public List<string> ObterHistorico()
        {
            return _historico.TakeLast(3).ToList();
        }
    }
}