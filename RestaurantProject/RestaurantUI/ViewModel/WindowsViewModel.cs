using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RestaurantUI
{
    public class WindowsViewModel : BaseViewModel
    {
        #region Private Properties

        private Window _window;

        //The margin around the window to allow for a drop shadow
        private int _outerMarginSize = 10;

        //Curve edges around the window
        private int _windowRadius = 10;

        private WindowDockPosition _dockPosition = WindowDockPosition.Undocked;

        #endregion

        #region Public Properties

        //Minimun width of windows
        public double MinimumWidth { get; set; } = 400;

        //Minimum height of windows
        public double MinimumHeight { get; set; } = 400;

        // True if the window should be borderless because it is docked or maximized
        public bool Borderless { get { return (_window.WindowState == WindowState.Maximized || _dockPosition != WindowDockPosition.Undocked); } }

        //The size of the resize border around the window
        public int ResizeBorder { get { return Borderless ? 0 : 6; } }

        //The size of the resize border around the window, taking into account the outer margin
        public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder + OuterMarginSize); } }

        //The margin around the window to allow for a drop shadow
        public int OuterMarginSize
        {
            get { return Borderless ? 0 : _outerMarginSize; }
            set { _outerMarginSize = value; }
        }

        //The margin around the window to allow for a drop shadow
        public Thickness OuterMarginSizeThickness { get { return new Thickness(OuterMarginSize); } }

        // The padding of the inner content of the main window
        public Thickness InnerContentPadding { get; set; } = new Thickness(0);

        //Curve edges around the window
        public int WindowRadius
        {
            get { return Borderless ? 0 : _windowRadius; }
            set { _windowRadius = value; }
        }

        //The radius of the edges of the window
        public CornerRadius WindowCornerRadius { get { return new CornerRadius(WindowRadius); } }

        //The height of the title bar
        public int TitleHeight { get; set; } = 40;

        //The height of the title bar
        public GridLength TitleHeightLength { get { return new GridLength(TitleHeight + ResizeBorder); } }
        
        //The current page of the application
        public WindowPage CurrentPage { get; set; } = WindowPage.LogIn;

        #endregion

        #region Commands

        public ICommand MinimizeCommand { get; set; }
        public ICommand MaximizeCommand { get; set; }
        public ICommand CloseCommand { get; set; }

        #endregion

        public WindowsViewModel(Window window)
        {
            _window = window;

            _window.StateChanged += (sender, e) =>
            {
                ResizeAction();
            };

            MinimizeCommand = new BaseCommand(() => _window.WindowState = WindowState.Minimized);
            MaximizeCommand = new BaseCommand(() => _window.WindowState ^= WindowState.Maximized);
            CloseCommand = new BaseCommand(() => _window.Close());

            //Fix window resize issue
            var resizer = new WindowResizer(_window);

            //Listen out for dock changes
            resizer.WindowDockChanged += (dock) =>
            {
                _dockPosition = dock;
                ResizeAction();
            };
        }

        //Calls all properties of the window
        private void ResizeAction()
        {
            //OnPropertyChanged(nameof(Borderless));
            OnPropertyChanged(nameof(ResizeBorderThickness));
            OnPropertyChanged(nameof(OuterMarginSize));
            OnPropertyChanged(nameof(OuterMarginSizeThickness));
            OnPropertyChanged(nameof(WindowRadius));
            OnPropertyChanged(nameof(WindowCornerRadius));
        }
    }
}
