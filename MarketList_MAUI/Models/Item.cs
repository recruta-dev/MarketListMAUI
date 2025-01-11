namespace MarketList_MAUI.Models;

public class Item
{
    public int Id { get; set; }
    public int IdCompra { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public decimal? Valor { get; set; }
    public bool? Status { get; set; }
}
