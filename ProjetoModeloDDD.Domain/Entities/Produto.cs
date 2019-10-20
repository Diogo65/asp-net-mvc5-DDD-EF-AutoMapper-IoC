
namespace ProjetoModeloDDD.Domain.Entities
{
    public class Produto
    { //possui relacionamento com cliente
        //um cliente pode ter vários produtos
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Disponivel { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
