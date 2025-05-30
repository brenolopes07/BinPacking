using testel2tecnologia.Domain.Entity;
using testel2tecnologia.Services.Interface;

namespace testel2tecnologia.Services
{
    public class PackingService : IPackingService
    {
        public  List<Caixa> OrganizarProdutoEmCaixas(List<Produto> produtos)
        {
            var caixasUsadas = new List<Caixa>();
            var produtosNaoCaberam = new List<Produto>();

            foreach (var produto in produtos)
            {
                bool colocado = false;

                foreach (var caixa in caixasUsadas)
                {
                    if (CabeNaCaixa (caixa, produto))
                    {
                       caixa.CaixaProdutos.Add (new CaixaProduto 
                       {
                            Caixa = caixa,
                            Produto = produto,
                            ProdutoId = produto.ProdutoId,
                            CaixaId = caixa.CaixaId
                       });

                        colocado = true;
                        break;
                    }
                }

                if (!colocado)
                {
                    var caixaDisponivel = CaixasDisponiveis.Todas.FirstOrDefault(c => CabeNaCaixa(c, produto));

                    if(caixaDisponivel == null)
                    {
                        produtosNaoCaberam.Add(produto);
                        continue;
                    }

                    var novaCaixa = new Caixa
                    {
                        Tipo = caixaDisponivel.Tipo,
                        Altura = caixaDisponivel.Altura,
                        Largura = caixaDisponivel.Largura,
                        Comprimento = caixaDisponivel.Comprimento,
                        CaixaProdutos = new List<CaixaProduto>()
                    };

                    novaCaixa.CaixaProdutos.Add(new CaixaProduto
                    {
                        Caixa = novaCaixa,
                        Produto = produto,
                        ProdutoId = produto.ProdutoId
                    });

                    caixasUsadas.Add(novaCaixa);    
                }

            }

            return caixasUsadas;
        }

        public bool CabeNaCaixa(Caixa caixa, Produto produto)
        {
            return produto.Altura <= caixa.Altura && 
                   produto.Largura <= caixa.Largura && 
                   produto.Comprimento <= caixa.Comprimento;
        }

        
    }
}
