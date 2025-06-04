using CommunityToolkit.Mvvm.ComponentModel;

namespace MyMoney.Core.Models
{
    public partial class AccountDashboardDisplayItem : ObservableObject
    {
        [ObservableProperty]
        private string _accountName = string.Empty;

        [ObservableProperty]
        private Currency _total = new Currency(0m);

        public static AccountDashboardDisplayItem FromAccount(Account account)
        {
            AccountDashboardDisplayItem displayItem = new()
            {
                AccountName = account.AccountName,
                Total = account.Total
            };
            return displayItem;
        }

        public static AccountDashboardDisplayItem FromInitializers(string accountName, Currency total)
        {
            AccountDashboardDisplayItem displayItem = new()
            {
                AccountName = accountName,
                Total = total
            };
            return displayItem;
        }
    }
}
