﻿using LibVLCSharp.Shared;

namespace LibVLCSharp.MAUI.Sample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((MainViewModel)BindingContext).OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            ((MainViewModel)BindingContext).OnDisappearing();
        }

        private void VideoView_MediaPlayerChanged(object sender, MediaPlayerChangedEventArgs e)
        {
            ((MainViewModel)BindingContext).OnVideoViewInitialized();
        }
    }
}