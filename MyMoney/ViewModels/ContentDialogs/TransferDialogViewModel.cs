using MyMoney.Core.Models;
using System.Collections.ObjectModel;

namespace MyMoney.ViewModels.ContentDialogs
{
    public partial class TransferDialogViewModel(ObservableCollection<string> accountNames) : ObservableObject
    {
        public ObservableCollection<string> Accounts { get; } = accountNames;

        [ObservableProperty]
        private string _transferFrom = string.Empty;

        [ObservableProperty]
        private string _transferTo = string.Empty;

        [ObservableProperty]
        private Currency _amount = new(0m);
    }
}
