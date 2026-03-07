using System;

public class ItemPedido
{
	public int Id { get; set; }

    // O EF Core usa isso para carregar os dados do Pedido se necessário
    public Pedido Pedido { get; set; }

	public int ProdutoId { get; set; }

	//O EF COre usa isso para buscar o NOME e PREÇO do produto vinculado
	public Produto Produto { get; set; }

	public int Quantidade	{ get; set; } 
}
//O Desafio das Regras de Negócio O Desafio das Regras de Negócio