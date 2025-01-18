namespace MarketList_MAUI.ViewModels;

public abstract class ViewModelBase<TypeT, ListTypeT> : INotifyPropertyChanged where TypeT : class where ListTypeT : class
{
	private TypeT? _currentItem;
	public TypeT? CurrentItem
	{
		get => _currentItem;
		set
		{ 
			_currentItem = value; 
			OnPropertyChanged(nameof(CurrentItem));
		}
	}
	private ObservableCollection<ListTypeT>? _itemCollection;
	public ObservableCollection<ListTypeT>? ItemCollection
	{
		get => _itemCollection;
		set
		{ 
			_itemCollection = value; 
			OnPropertyChanged(nameof(ItemCollection));
		}
	}

	public ViewModelBase()
	{
		CurrentItem = Activator.CreateInstance<TypeT>();
		ItemCollection = Activator.CreateInstance<ObservableCollection<ListTypeT>>();
	}

	protected virtual void Load() => throw new NotImplementedException();
	public ICommand LoadCommand => new Command(Load);
    
    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}

public class ViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}