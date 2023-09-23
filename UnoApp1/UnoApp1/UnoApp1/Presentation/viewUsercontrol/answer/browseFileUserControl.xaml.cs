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
using Windows.Foundation;
using Windows.Foundation.Collections;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace UnoApp1.Presentation.viewUsercontrol.answer
{
    public sealed partial class browseFileUserControl : UserControl
    {
        public browseFileUserControl()
        {
            this.InitializeComponent();
        }

     

        private void btnBrowse_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, nameof(normall), true);
        }

        private void btnBrowse_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, nameof(uploadButtonHover), true);
        }

        private void btnBrowse_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, nameof(uploadButtonHover), true);
        }

        private void btnBrowse_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, nameof(normall), true);
        }

        private void btnBrowse_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, nameof(uploadButtonHover), true);
        }

        private void btnBrowse_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, nameof(normall), true);
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBrowse_PreviewKeyDown(object sender, KeyRoutedEventArgs e)
        {

        }
    }
}
