namespace testel2tecnologia.Domain.Entity
{
    public static class CaixasDisponiveis
    {
        public static readonly Caixa Caixa1 = new Caixa { Tipo = "Caixa 1", Altura = 30, Largura = 40, Comprimento = 80 };
        public static readonly Caixa Caixa2 = new Caixa { Tipo = "Caixa 2", Altura = 80, Largura = 50, Comprimento = 40 };
        public static readonly Caixa Caixa3 = new Caixa { Tipo = "Caixa 3", Altura = 50, Largura = 80, Comprimento = 60 };

        public static List<Caixa> Todas => new List<Caixa> { Caixa1, Caixa2, Caixa3 };
    }
}
