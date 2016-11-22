using CustomerRenderDemo;
using CustomerRenderDemo.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(MyTapPage), typeof(CustmomerRender))]
namespace CustomerRenderDemo.UWP
{

    class CustmomerRender : PageRenderer
    {
        AppBarButton takePhotoButton;
        Page page;
        CaptureElement captureElement;
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Page> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || Element == null)
            {
                return;
            }

            try
            {
                page = new Page();
                takePhotoButton = new AppBarButton
                {
                    VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center,
                    HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center,
                    Icon = new SymbolIcon(Symbol.Camera)
                };

                var commandBar = new CommandBar();
                commandBar.PrimaryCommands.Add(takePhotoButton);

                captureElement = new CaptureElement();
                captureElement.Stretch = Stretch.UniformToFill;

                var stackPanel = new StackPanel();
                stackPanel.Children.Add(captureElement);

                page.BottomAppBar = commandBar;
                page.Content = stackPanel;
                this.Children.Add(page);
            }
            catch (Exception e1)
            {

            }
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            page.Arrange(new Windows.Foundation.Rect(0, 0, finalSize.Width, finalSize.Height));
            return finalSize;
        }

    }
}
