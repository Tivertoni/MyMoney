using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MyMoney.Core.Models
{
    public partial class BudgetExpenseCategory : ObservableObject
    {
        [ObservableProperty]
        private int _id = 0;

        [ObservableProperty]
        private string _categoryName = string.Empty;

        [ObservableProperty]
        private ObservableCollection<BudgetItem> _subItems = [];

        [ObservableProperty]
        private int _selectedSubItemIndex = 1;

        public Currency CategoryTotal
        {
            get
            {
                decimal total = 0;
                foreach (var item in SubItems)
                {
                    total += Math.Abs(item.Amount.Value);
                }
                return new Currency(total);
            }
        }
    }
}
