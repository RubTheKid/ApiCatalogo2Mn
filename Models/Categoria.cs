namespace ApiCatalogo2.Models;

public class Categoria
{
    public int CategoriaId { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    
    //settin 1:n relationship
    public ICollection<Produto>? Produtos { get; set; }

}
