﻿using Xamarin.Forms;

namespace XamSpeak
{
    public class BaseContentPage<TViewModel> : ContentPage where TViewModel : BaseViewModel, new()
    {
        #region Fields
        TViewModel _viewModel;
        #endregion

        #region Constructors
        public BaseContentPage()
        {
            BindingContext = ViewModel;
            BackgroundColor = ColorConstants.ContentPageBackgroundColor;
            this.SetBinding(IsBusyProperty, nameof(BaseViewModel.IsInternetConnectionActive));
        }
        #endregion

        #region Properties
        protected TViewModel ViewModel => _viewModel ?? (_viewModel = new TViewModel());
        #endregion
    }
}
