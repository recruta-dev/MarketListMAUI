namespace MarketList_MAUI.ViewModels;

public class ListaCompraViewModel : ViewModelBase<Compra, Item>
{
    private bool _exibirPopup;
    public bool ExibirPopup
    {
        get => _exibirPopup;
        set 
        { 
            _exibirPopup = value;
            OnPropertyChanged(nameof(ExibirPopup));
        }
    }

    public ListaCompraViewModel()
    {
        ExibirPopup = false;
    }

    protected override void Load()
    {
        CurrentItem = new Compra
        {
            Mercado = "Stok Center"
        };

        ItemCollection = new ObservableCollection<Item>
        {
            new Item {Descricao = "Amaciante para roupas pesadas", Nome = "AmaciLow"},
            new Item {Descricao = "Sabonete suave", Nome = "SaboSoft"},
            new Item {Descricao = "Detergente concentrado", Nome = "DeterMax"},
            new Item {Descricao = "Esponja de aço", Nome = "EsponClean"},
            new Item {Descricao = "Papel toalha absorvente", Nome = "Toalhinha"},
            new Item {Descricao = "Sacolas de lixo reciclável", Nome = "EcoLixo"},
            new Item {Descricao = "Desinfetante perfumado", Nome = "LimpPerfumado"},
            new Item {Descricao = "Shampoo hidratante", Nome = "HairCare"},
            new Item {Descricao = "Condicionador leve", Nome = "HairSoft"},
            new Item {Descricao = "Sabão em pó eficiente", Nome = "LavaPlus"},
            new Item {Descricao = "Desodorizador de ambientes", Nome = "AmbiFresh"},
            new Item {Descricao = "Limpa-vidros", Nome = "VidroLimpo"},
            new Item {Descricao = "Sabão líquido multiuso", Nome = "MultiLimp"},
            new Item {Descricao = "Água sanitária", Nome = "SanitClean"},
            new Item {Descricao = "Pano de microfibra", Nome = "MicroPano"},
            new Item {Descricao = "Lustra móveis", Nome = "MobiliClean"},
            new Item {Descricao = "Inseticida aerosol", Nome = "InsectAway"},
            new Item {Descricao = "Sabonete antibacteriano", Nome = "AntiBacSoap"},
            new Item {Descricao = "Protetor solar", Nome = "SunShield"},
            new Item {Descricao = "Gel antisséptico", Nome = "CleanHands"},
            new Item {Descricao = "Esponja dupla face", Nome = "DuplaLimpa"},
            new Item {Descricao = "Guardanapos decorados", Nome = "DecoraGuard"},
            new Item {Descricao = "Sabão de coco", Nome = "CocoLava"},
            new Item {Descricao = "Cera líquida para pisos", Nome = "BrilhoChão"},
            new Item {Descricao = "Saco a vácuo organizador", Nome = "VacOrganiza"},
            new Item {Descricao = "Desengordurante potente", Nome = "DesengClean"},
            new Item {Descricao = "Repelente spray", Nome = "SprayAway"},
            new Item {Descricao = "Sabão glicerinado", Nome = "GlicerLimp"},
            new Item {Descricao = "Bucha vegetal", Nome = "VegBucha"},
            new Item {Descricao = "Filtro de café reutilizável", Nome = "EcoFiltro"}
        };
    }

    private void TerminarCompra()
    {
        ExibirPopup = true;
    }
    private void AlterarValor()
    {
        CurrentItem!.ValorTotal = ItemCollection!.Sum(a => a.Valor);
    }
    private void Cancelar()
    {
        ExibirPopup = false;
    }
    private void Confirmar()
    {
        ExibirPopup = false;
    }

    public ICommand TerminarCompraCommand => new Command(TerminarCompra);
    public ICommand AlterarValorCommand => new Command(AlterarValor);
    public ICommand CancelarCommand => new Command(Cancelar);
    public ICommand ConfirmarCommand => new Command(Confirmar);
}
