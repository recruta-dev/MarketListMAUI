namespace MarketList_MAUI.ViewModels;

public abstract class ViewModelBase<TypeT> : INotifyPropertyChanged where TypeT : class
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
	private ObservableCollection<TypeT>? _itemCollection;
	public ObservableCollection<TypeT>? ItemCollection
	{
		get => _itemCollection;
		set
		{ 
			_itemCollection = value; 
			OnPropertyChanged(nameof(ItemCollection));
		}
	}

	protected virtual void Load() => throw new NotImplementedException();
	public ICommand LoadCommand => new Command(Load);
    
    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
