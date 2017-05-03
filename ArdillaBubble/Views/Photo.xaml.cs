using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;
using System.Windows.Media.Imaging;

namespace ArdillaBubble.Views
{
    public partial class Photo : Page
    {
        public Photo()
        {
            InitializeComponent();

         //   Media.Source = new BitmapImage(new Uri("1.jpg", UriKind.Relative));

            Image im = new Image();
            im.Source = new BitmapImage(new Uri("1.jpg", UriKind.Relative));
            LayoutRoot.Children.Add(im);

        }

        // Выполняется, когда пользователь переходит на эту страницу.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
   }

    }
}
