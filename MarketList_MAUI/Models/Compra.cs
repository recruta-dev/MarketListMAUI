namespace MarketList_MAUI.Models;

public class Compra : INotifyPropertyChanged
{
    public int Id { get; set; }
    public DateTime? RealizadaEm { get; set; }
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
