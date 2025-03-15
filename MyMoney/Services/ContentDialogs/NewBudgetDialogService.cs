﻿using MyMoney.ViewModels.ContentDialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf.Ui.Controls;
using Wpf.Ui;
using MyMoney.Views.ContentDialogs;

namespace MyMoney.Services.ContentDialogs
{
    public interface INewBudgetDialogService
    {
        public void SetViewModel(NewBudgetDialogViewModel viewModel);
        public NewBudgetDialogViewModel GetViewModel();
        public Task<ContentDialogResult> ShowDialogAsync(IContentDialogService dialogService);
    }

    public class NewBudgetDialogService : INewBudgetDialogService
    {
        private NewBudgetDialogViewModel _viewModel = new();

        public NewBudgetDialogViewModel GetViewModel()
        {
            return _viewModel;
        }

        public void SetViewModel(NewBudgetDialogViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public async Task<ContentDialogResult> ShowDialogAsync(IContentDialogService dialogService)
        {
            var host = dialogService.GetDialogHost();
            if (host == null)
                return ContentDialogResult.None;

            NewBudgetDialog newBudgetDialog = new(host, _viewModel)
            {
                PrimaryButtonText = "OK",
                CloseButtonText = "Cancel"
            };
            return await dialogService.ShowAsync(newBudgetDialog, CancellationToken.None);
        }
    }
}
