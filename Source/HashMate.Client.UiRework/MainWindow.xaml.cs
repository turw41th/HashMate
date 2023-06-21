using HashMate.Client.UiRework.Views;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace HashMate.Client.UiRework
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private Dictionary<string, Page> _pageInstances = new Dictionary<string, Page>();
        public MainWindow()
        {
            this.InitializeComponent();
            this.AppWindow.Resize(new Windows.Graphics.SizeInt32(550, 750));

            _pageInstances["TextToHash"] = new TextToHashView();
            _pageInstances["FileToHash"] = new FileToHashView();

            navigationView.SelectedItem = navigationView.MenuItems.OfType<NavigationViewItem>().First(item => (string)item.Tag == "TextToHash");

            contentFrame.Content = _pageInstances["TextToHash"];
        }

        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            var selectedItem = (NavigationViewItem)args.SelectedItem;
            string pageTag = selectedItem.Tag.ToString();

            if (_pageInstances.ContainsKey(pageTag))
            {
                contentFrame.Content = _pageInstances[pageTag];
            }
        }
    }
}
