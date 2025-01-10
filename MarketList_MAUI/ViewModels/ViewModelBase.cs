namespace MarketList_MAUI.ViewModels;

public class ViewModelBase : INotifyPropertyChanged
{
    protected void OnPropertyChanged(string propertyName) => PropertyChanged!(this, new PropertyChangedEventArgs(propertyName));
    public event PropertyChangedEventHandler? PropertyChanged;
}
