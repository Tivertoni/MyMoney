using CommunityToolkit.Mvvm.ComponentModel;

namespace MyMoney.Core.Models
{
    public partial class BudgetItem : ObservableObject
    {
        [ObservableProperty]
        private int _id = 0;

        [ObservableProperty]
        private string _category = string.Empty;

        [ObservableProperty]
        private Currency _amount = new(0m);

        [ObservableProperty]
        private Currency _actual = new(0m);
    }
}
