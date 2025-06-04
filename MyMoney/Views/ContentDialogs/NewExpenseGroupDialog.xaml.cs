using MyMoney.ViewModels.ContentDialogs;
using System.Windows.Controls;
using System.Windows.Input;
using Wpf.Ui.Controls;

namespace MyMoney.Views.ContentDialogs
{
    /// <summary>
    /// Interaction logic for NewExpenseGroupDialog.xaml
    /// </summary>
    public partial class NewExpenseGroupDialog : ContentDialog
    {
        public NewExpenseGroupDialog(ContentPresenter host, NewExpenseGroupDialogViewModel viewModel) : base(host)
        {
            InitializeComponent(); 
            DataContext = viewModel;
        }

        private void txtGroupName_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            txtGroupName.SelectAll();
        }

        private void txtGroupName_GotMouseCapture(object sender, MouseEventArgs e)
        {
            txtGroupName.SelectAll();
        }

        private void txtGroupName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtGroupName.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
                e.Handled = false;
            }
        }

        private void ContentDialog_Loaded(object sender, RoutedEventArgs e)
        {
            txtGroupName.Focus();
            txtGroupName.SelectAll();
        }
    }
}
