namespace LocalCarrier.App.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            LoadApplication(new LocalCarrier.App.App());
        }
    }
}