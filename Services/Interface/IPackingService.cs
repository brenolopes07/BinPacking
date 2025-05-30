using testel2tecnologia.Domain.Entity;

namespace testel2tecnologia.Services.Interface
{
    public interface IPackingService
    {
        List<Caixa> OrganizarProdutoEmCaixas(List<Produto> produtos);
        bool CabeNaCaixa(Caixa caixa, Produto produto);
    }
}
