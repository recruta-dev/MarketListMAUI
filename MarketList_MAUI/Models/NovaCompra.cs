namespace MarketList_MAUI.Models;

public class NovaCompra
{
    public required Compra Compra { get; set; }
    public required IEnumerable<Item> Itens { get; set; }
}
