using MyMoney.Core.Models;

namespace MyMoney.ViewModels.ContentDialogs
{
    public partial class NewAccountDialogViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _accountName = string.Empty;

        [ObservableProperty]
        private Currency _startingBalance = new(0m);
    }
}
