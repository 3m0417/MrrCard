using Xamarin.Forms;

namespace MrrCard.Views
{
    public partial class MainPage : ContentPage
    {

        ToolbarItem toolbarItem;

        public MainPage()
        {
            InitializeComponent();

            ShowToolbar();

        }

        private void ShowToolbar()
        {
            if (Device.OS == TargetPlatform.iOS)
            {
                // move layout under the status bar
                this.Padding = new Thickness(0, 20, 0, 0);

                toolbarItem = new ToolbarItem("More", null, () =>
                {
                    //if (!response)
                    //{
                    //    response = true;

                    //}
                    //else
                    //    return;
                }, 0, 0);
                ToolbarItems.Add(toolbarItem);
            }

            if (Device.OS == TargetPlatform.Android)
            {

                toolbarItem = new ToolbarItem("More", null, () =>
                {
                    //if (!response)
                    //{

                    //}
                    //else
                    //    return;
                }, 0, 0);
                ToolbarItems.Add(toolbarItem);

            }

            if (Device.OS == TargetPlatform.WinPhone)
            {
                toolbarItem = new ToolbarItem("More", null, () =>
                {
                    //if (!response)
                    //{
                    //    response = true;

                    //}
                    //else
                    //    return;
                }, 0, 0);
                ToolbarItems.Add(toolbarItem);
            }
        }

    }
}
