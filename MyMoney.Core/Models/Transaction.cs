using CommunityToolkit.Mvvm.ComponentModel;

namespace MyMoney.Core.Models;

public partial class Transaction(DateTime date, string payee, Category category, Currency amount, string memo) : ObservableObject
{
    [ObservableProperty]
    private string _payee = payee;

    [ObservableProperty]
    private Category _category = category;

    [ObservableProperty]
    private Currency _amount = amount;

    [ObservableProperty]
    private string _memo = memo;

    [ObservableProperty]
    private DateTime _date = date;

    public string DateFormatted => Date.ToShortDateString();

    public string MonthAbbreviated => Date.ToString("MMM");

    public string AmountFormatted
    {
        get
        {
            if (Amount.Value > 0m)
            {
                return "+" + Amount;
            }

            if (Amount.Value == 0m)
            {
                return "$0.00";
            }

            return "-" + new Currency(Math.Abs(Amount.Value));
        }
    }
}
