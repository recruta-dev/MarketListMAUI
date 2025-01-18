namespace MarketList_MAUI.Models;

[Table("Item")]
public class Item : INotifyPropertyChanged
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public int IdCompra { get; set; }

    private string? _nome;

    [MaxLength(80)]
    public string? Nome
    {
        get => _nome;
        set 
        { 
            _nome = value;
            OnPropertyChanged(nameof(Nome));
        }
    }

    [MaxLength(200)]
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

    private bool _habilitado;
    public bool Habilitado
    {
        get => _habilitado;
        set 
        { 
            _habilitado = value;
            OnPropertyChanged(nameof(Habilitado));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
