namespace MarketList_MAUI.ViewModels;

[QueryProperty(nameof(IdCompra), "IdCompra")]
public class HistoricoDetailViewModel : ViewModelBase<Item, Item>
{
    public HistoricoDetailViewModel() { }

    private int _idCompra;
    public int IdCompra
    {
        get => _idCompra;
        set
        {
            _idCompra = value;
            OnPropertyChanged(nameof(IdCompra));
        }
    }


    protected override void Load()
    {
        ItemCollection = RepositorioItens.ObterItens(a => a.IdCompra == IdCompra);
    }

    public static class RepositorioItens
    {
        public static ObservableCollection<Item> ObterItens(Func<Item, bool>? action = null)
        {
            var itens = new ObservableCollection<Item>
            {
                new Item {Id = 1, Descricao = "Amaciante para roupas pesadas", IdCompra = 1, Nome = "AmaciLow", Status = true, Valor = 20M},
                new Item {Id = 2, Descricao = "Sabonete suave", IdCompra = 2, Nome = "SaboSoft", Status = false, Valor = 5M},
                new Item {Id = 3, Descricao = "Detergente concentrado", IdCompra = 3, Nome = "DeterMax", Status = true, Valor = 8M},
                new Item {Id = 4, Descricao = "Esponja de aço", IdCompra = 4, Nome = "EsponClean", Status = false, Valor = 3M},
                new Item {Id = 5, Descricao = "Papel toalha absorvente", IdCompra = 5, Nome = "Toalhinha", Status = true, Valor = 15M},
                new Item {Id = 6, Descricao = "Sacolas de lixo reciclável", IdCompra = 6, Nome = "EcoLixo", Status = false, Valor = 10M},
                new Item {Id = 7, Descricao = "Desinfetante perfumado", IdCompra = 7, Nome = "LimpPerfumado", Status = true, Valor = 12M},
                new Item {Id = 8, Descricao = "Shampoo hidratante", IdCompra = 8, Nome = "HairCare", Status = false, Valor = 25M},
                new Item {Id = 9, Descricao = "Condicionador leve", IdCompra = 9, Nome = "HairSoft", Status = true, Valor = 22M},
                new Item {Id = 10, Descricao = "Sabão em pó eficiente", IdCompra = 1, Nome = "LavaPlus", Status = false, Valor = 18M},
                new Item {Id = 11, Descricao = "Desodorizador de ambientes", IdCompra = 2, Nome = "AmbiFresh", Status = true, Valor = 30M},
                new Item {Id = 12, Descricao = "Limpa-vidros", IdCompra = 3, Nome = "VidroLimpo", Status = false, Valor = 14M},
                new Item {Id = 13, Descricao = "Sabão líquido multiuso", IdCompra = 4, Nome = "MultiLimp", Status = true, Valor = 11M},
                new Item {Id = 14, Descricao = "Água sanitária", IdCompra = 5, Nome = "SanitClean", Status = false, Valor = 6M},
                new Item {Id = 15, Descricao = "Pano de microfibra", IdCompra = 6, Nome = "MicroPano", Status = true, Valor = 8M},
                new Item {Id = 16, Descricao = "Lustra móveis", IdCompra = 7, Nome = "MobiliClean", Status = false, Valor = 20M},
                new Item {Id = 17, Descricao = "Inseticida aerosol", IdCompra = 8, Nome = "InsectAway", Status = true, Valor = 18M},
                new Item {Id = 18, Descricao = "Sabonete antibacteriano", IdCompra = 9, Nome = "AntiBacSoap", Status = false, Valor = 7M},
                new Item {Id = 19, Descricao = "Protetor solar", IdCompra = 1, Nome = "SunShield", Status = true, Valor = 35M},
                new Item {Id = 20, Descricao = "Gel antisséptico", IdCompra = 2, Nome = "CleanHands", Status = false, Valor = 12M},
                new Item {Id = 21, Descricao = "Esponja dupla face", IdCompra = 3, Nome = "DuplaLimpa", Status = true, Valor = 5M},
                new Item {Id = 22, Descricao = "Guardanapos decorados", IdCompra = 4, Nome = "DecoraGuard", Status = false, Valor = 10M},
                new Item {Id = 23, Descricao = "Sabão de coco", IdCompra = 5, Nome = "CocoLava", Status = true, Valor = 14M},
                new Item {Id = 24, Descricao = "Cera líquida para pisos", IdCompra = 6, Nome = "BrilhoChão", Status = false, Valor = 22M},
                new Item {Id = 25, Descricao = "Saco a vácuo organizador", IdCompra = 7, Nome = "VacOrganiza", Status = true, Valor = 40M},
                new Item {Id = 26, Descricao = "Desengordurante potente", IdCompra = 8, Nome = "DesengClean", Status = false, Valor = 25M},
                new Item {Id = 27, Descricao = "Repelente spray", IdCompra = 9, Nome = "SprayAway", Status = true, Valor = 18M},
                new Item {Id = 28, Descricao = "Sabão glicerinado", IdCompra = 1, Nome = "GlicerLimp", Status = false, Valor = 16M},
                new Item {Id = 29, Descricao = "Bucha vegetal", IdCompra = 2, Nome = "VegBucha", Status = true, Valor = 8M},
                new Item {Id = 30, Descricao = "Filtro de café reutilizável", IdCompra = 3, Nome = "EcoFiltro", Status = false, Valor = 12M},
                new Item {Id = 31, Descricao = "Kit de panos de prato", IdCompra = 4, Nome = "PanosKit", Status = true, Valor = 20M},
                new Item {Id = 32, Descricao = "Removedor de manchas", IdCompra = 5, Nome = "ManchaAway", Status = false, Valor = 15M},
                new Item {Id = 33, Descricao = "Perfume de ambientes", IdCompra = 6, Nome = "AmbiPerfume", Status = true, Valor = 18M},
                new Item {Id = 34, Descricao = "Rodo de limpeza com borracha", IdCompra = 7, Nome = "RodoFlex", Status = false, Valor = 30M},
                new Item {Id = 35, Descricao = "Álcool gel", IdCompra = 8, Nome = "GelClean", Status = true, Valor = 10M},
                new Item {Id = 36, Descricao = "Desinfetante hospitalar", IdCompra = 9, Nome = "HospClean", Status = false, Valor = 25M},
                new Item {Id = 37, Descricao = "Sabonete líquido floral", IdCompra = 1, Nome = "FloralSoap", Status = true, Valor = 8M},
                new Item {Id = 38, Descricao = "Papel alumínio resistente", IdCompra = 2, Nome = "AlumFlex", Status = false, Valor = 12M},
                new Item {Id = 39, Descricao = "Escova de limpeza multiuso", IdCompra = 3, Nome = "MultiBrush", Status = true, Valor = 15M},
                new Item {Id = 40, Descricao = "Desodorizador para carros", IdCompra = 4, Nome = "CarFresh", Status = false, Valor = 10M},
                new Item {Id = 41, Descricao = "Filtro de ar purificador", IdCompra = 5, Nome = "AirClean", Status = true, Valor = 40M},
                new Item {Id = 42, Descricao = "Esponja mágica removedora", IdCompra = 6, Nome = "MagicClean", Status = false, Valor = 18M},
                new Item {Id = 43, Descricao = "Limpa pedras e azulejos", IdCompra = 7, Nome = "StoneTile", Status = true, Valor = 20M},
                new Item {Id = 44, Descricao = "Limpador de telas eletrônicas", IdCompra = 8, Nome = "ScreenClean", Status = false, Valor = 14M},
                new Item {Id = 45, Descricao = "Lava-louças em gel", IdCompra = 9, Nome = "GelLavaLouças", Status = true, Valor = 22M},
                new Item {Id = 46, Descricao = "Protetor para tecidos", IdCompra = 1, Nome = "TextilProtect", Status = false, Valor = 25M},
                new Item {Id = 47, Descricao = "Cera automotiva líquida", IdCompra = 2, Nome = "AutoShine", Status = true, Valor = 35M},
                new Item {Id = 48, Descricao = "Polidor de inox", IdCompra = 3, Nome = "InoxPolish", Status = false, Valor = 28M},
                new Item {Id = 49, Descricao = "Removedor de ferrugem", IdCompra = 4, Nome = "RustAway", Status = true, Valor = 18M},
                new Item {Id = 50, Descricao = "Desinfetante com lavanda", IdCompra = 5, Nome = "LavandaClean", Status = false, Valor = 12M},
                new Item {Id = 51, Descricao = "Saco plástico reforçado", IdCompra = 6, Nome = "PlastFlex", Status = true, Valor = 8M},
                new Item {Id = 52, Descricao = "Limpador perfumado de couro", IdCompra = 7, Nome = "LeatherFresh", Status = false, Valor = 32M},
                new Item {Id = 53, Descricao = "Água oxigenada multiuso", IdCompra = 8, Nome = "OxiMulti", Status = true, Valor = 5M},
                new Item {Id = 54, Descricao = "Sabonete glicerinado", IdCompra = 9, Nome = "GlicerSoft", Status = false, Valor = 6M},
                new Item {Id = 55, Descricao = "Álcool em spray portátil", IdCompra = 1, Nome = "PocketClean", Status = true, Valor = 8M},
                new Item {Id = 56, Descricao = "Produto anti-odor para tecidos", IdCompra = 2, Nome = "OdorFree", Status = false, Valor = 19M},
                new Item {Id = 57, Descricao = "Esponja biodegradável", IdCompra = 3, Nome = "BioEsponja", Status = true, Valor = 10M},
                new Item {Id = 58, Descricao = "Lustra-móveis perfumado", IdCompra = 4, Nome = "PerfumeMóveis", Status = false, Valor = 15M},
                new Item {Id = 59, Descricao = "Removedor de gordura pesada", IdCompra = 5, Nome = "GreaseOff", Status = true, Valor = 22M},
                new Item {Id = 60, Descricao = "Sabonete líquido infantil", IdCompra = 6, Nome = "KidsClean", Status = false, Valor = 8M},
                new Item {Id = 61, Descricao = "Limpador de superfícies", IdCompra = 7, Nome = "SurfaceClean", Status = true, Valor = 12M},
                new Item {Id = 62, Descricao = "Removedor de manchas em tecidos", IdCompra = 8, Nome = "TextilClear", Status = false, Valor = 20M},
                new Item {Id = 63, Descricao = "Desinfetante concentrado", IdCompra = 9, Nome = "SuperSanit", Status = true, Valor = 25M},
                new Item {Id = 64, Descricao = "Sabão em barra natural", IdCompra = 1, Nome = "NaturalBar", Status = false, Valor = 8M},
                new Item {Id = 65, Descricao = "Limpador de metais", IdCompra = 2, Nome = "MetalShine", Status = true, Valor = 30M},
                new Item {Id = 66, Descricao = "Pano de chão ultraabsorvente", IdCompra = 3, Nome = "AbsorbPlus", Status = false, Valor = 18M},
                new Item {Id = 67, Descricao = "Sabonete neutro premium", IdCompra = 4, Nome = "PremiumSoap", Status = true, Valor = 15M},
                new Item {Id = 68, Descricao = "Cera para madeira escura", IdCompra = 5, Nome = "DarkWood", Status = false, Valor = 28M},
                new Item {Id = 69, Descricao = "Repelente de insetos elétrico", IdCompra = 6, Nome = "InsectGuard", Status = true, Valor = 35M},
                new Item {Id = 70, Descricao = "Detergente lava-louças", IdCompra = 7, Nome = "DishClean", Status = false, Valor = 10M},
                new Item {Id = 71, Descricao = "Lustra vidro", IdCompra = 8, Nome = "GlassShine", Status = true, Valor = 12M},
                new Item {Id = 72, Descricao = "Sabonete com esfoliante natural", IdCompra = 9, Nome = "ExfoClean", Status = false, Valor = 14M},
                new Item {Id = 73, Descricao = "Produto limpa estofados", IdCompra = 1, Nome = "SofaClean", Status = true, Valor = 22M},
                new Item {Id = 74, Descricao = "Limpador multiuso com lavanda", IdCompra = 2, Nome = "LavandaMulti", Status = false, Valor = 10M},
                new Item {Id = 75, Descricao = "Esponja para limpeza pesada", IdCompra = 3, Nome = "HeavyScrub", Status = true, Valor = 5M},
                new Item {Id = 76, Descricao = "Removedor de mofo em spray", IdCompra = 4, Nome = "MoldAway", Status = false, Valor = 18M},
                new Item {Id = 77, Descricao = "Álcool líquido perfumado", IdCompra = 5, Nome = "PerfumeClean", Status = true, Valor = 8M},
                new Item {Id = 78, Descricao = "Protetor de superfícies contra manchas", IdCompra = 6, Nome = "ProtectGuard", Status = false, Valor = 22M},
                new Item {Id = 79, Descricao = "Limpa rejunte de pisos", IdCompra = 7, Nome = "TileClean", Status = true, Valor = 25M},
                new Item {Id = 80, Descricao = "Limpador de bancadas", IdCompra = 8, Nome = "CounterClean", Status = false, Valor = 20M},
                new Item {Id = 81, Descricao = "Limpador ecológico de vidro", IdCompra = 9, Nome = "EcoGlass", Status = true, Valor = 15M},
                new Item {Id = 82, Descricao = "Sabão líquido de coco", IdCompra = 1, Nome = "CocoLiquid", Status = false, Valor = 18M},
                new Item {Id = 83, Descricao = "Cera líquida para azulejos", IdCompra = 2, Nome = "TileWax", Status = true, Valor = 12M},
                new Item {Id = 84, Descricao = "Repelente natural de insetos", IdCompra = 3, Nome = "InsectNatural", Status = false, Valor = 28M},
                new Item {Id = 85, Descricao = "Lustra inox perfumado", IdCompra = 4, Nome = "PerfumeInox", Status = true, Valor = 20M},
                new Item {Id = 86, Descricao = "Sabonete hidratante com aloe vera", IdCompra = 5, Nome = "AloeSoap", Status = false, Valor = 8M},
                new Item {Id = 87, Descricao = "Removedor de manchas para vidros", IdCompra = 6, Nome = "GlassClear", Status = true, Valor = 14M},
                new Item {Id = 88, Descricao = "Desinfetante potente", IdCompra = 7, Nome = "PowerSanit", Status = false, Valor = 12M},
                new Item {Id = 89, Descricao = "Kit de limpeza básica", IdCompra = 8, Nome = "BasicCleanKit", Status = true, Valor = 50M},
                new Item {Id = 90, Descricao = "Spray multiuso perfumado", IdCompra = 9, Nome = "PerfumeSpray", Status = false, Valor = 15M}
            };

            if (action is null)
                return itens; 

            return new ObservableCollection<Item>(itens.Where(action).OrderByDescending(a => a.Status));
        }
    }
}
