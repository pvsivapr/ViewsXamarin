using System;

using Xamarin.Forms;

namespace ViewsDemo
{
    public class ViewTab : TabbedPage
    {
        public ViewTab()
        {
            var navigationPage = new NavigationPage(new LabelDemo());
            navigationPage.Icon = "null";
            navigationPage.Title = "Label";

            Children.Add (navigationPage);
        }

    }
}

