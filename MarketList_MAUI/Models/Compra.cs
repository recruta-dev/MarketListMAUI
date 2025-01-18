namespace MarketList_MAUI.Models;

[Table("Compra")]
public class Compra : INotifyPropertyChanged
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public DateTime? RealizadaEm { get; set; }

    [MaxLength(80)]
    public string? Mercado { get; set; }

    private decimal _valorTotal;
    public decimal ValorTotal
    {
        get => _valorTotal;
        set 
        { 
            _valorTotal = value;
            OnPropertyChanged(nameof(ValorTotal));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
