using System;

public class Pedido
{
	public int Id { get; set; }

	public int NumeroPedido { get; set; }

	//Navegação: um pedido tem varios itens
	public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();

	public DateTime DataPedido { get; set; }

	public float ValorTotal { get; set; }
}
