namespace MarketList_MAUI.Converters;

public class StatusToTextConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value == null) return "Pendente";
        if (value is bool status)
            return status == true ? "No carrinho" : "Em falta";

        return "Pendente";
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture) => throw new NotImplementedException();
}
