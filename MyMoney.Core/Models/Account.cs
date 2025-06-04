using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MyMoney.Core.Models
{
    public partial class Account : ObservableObject
    {
        [ObservableProperty]
        private int _id;

        [ObservableProperty]
        private ObservableCollection<Transaction> _transactions = [];

        [ObservableProperty]
        private string _accountName = string.Empty;

        [ObservableProperty]
        private Currency _total = new (0m);
    }
}