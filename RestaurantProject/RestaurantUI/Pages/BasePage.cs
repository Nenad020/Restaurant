using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace RestaurantUI
{
     //A base page for all pages to gain base functionality
    public class BasePage<VM> : Page where VM : BaseViewModel, new()
    {
        #region Private Properties
        //The View Model associated with this page
        private VM _viewModel;
        #endregion

        #region Public Properties
        //Property when the page is first loaded
        public PageAnimations LoadAnimation { get; set; } = PageAnimations.SlideInFromRight;
        
        //Property when the page is unloaded
        public PageAnimations UnloadAnimation { get; set; } = PageAnimations.SlideOutToLeft;
        
        //The time any slide animation takes to complete
        public float AnimationSeconds { get; set; } = 0.8f;

        //The View Model associated with this page
        public VM ViewModel
        {
            get { return _viewModel; }
            set
            {
                if (_viewModel == value)
                    return;
                
                _viewModel = value;
                this.DataContext = _viewModel;
            }
        }
        #endregion

        public BasePage()
        {
            if (LoadAnimation != PageAnimations.None)
                Visibility = Visibility.Collapsed;
            
            this.Loaded += BasePage_LoadedAsync;
            ViewModel = new VM();
        }

        //Fire this event when page is loaded, to perfome animation
        private async void BasePage_LoadedAsync(object sender, System.Windows.RoutedEventArgs e)
        {
            await AnimateIn();
        }

        #region Animations
        //Animates the page in
        public async Task AnimateIn()
        {
            if (LoadAnimation == PageAnimations.None)
                return;

            switch (LoadAnimation)
            {
                case PageAnimations.SlideInFromRight:
                    await this.SlideInFromRightAsync(AnimationSeconds);

                    break;
            }
        }
        
        //Animates the page out
        public async Task AnimateOut()
        {
            if (UnloadAnimation == PageAnimations.None)
                return;

            switch (UnloadAnimation)
            {
                case PageAnimations.SlideOutToLeft:
                    await this.SlideOutToLeftAsync(AnimationSeconds);

                    break;
            }
        }
        #endregion
    }
}
