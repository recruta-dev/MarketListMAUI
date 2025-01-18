namespace MarketList_MAUI.Models;

public class Item : INotifyPropertyChanged
{
    public int Id { get; set; }
    public int IdCompra { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    
    private decimal _valor;
    public decimal Valor
    {
        get => _valor;
        set 
        { 
            _valor = value;
            OnPropertyChanged(nameof(Valor));
        }
    }

    private bool? _status;
    public bool? Status
    {
        get => _status;
        set 
        { 
            _status = value;
            OnPropertyChanged(nameof(Status));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
