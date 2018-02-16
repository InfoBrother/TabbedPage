using Xamarin.Forms;

namespace TabbedPageDemo
{
	public partial class MainPage : TabbedPage
    {
		public MainPage()
		{
			InitializeComponent();

            Children.Add(new Cplusplus());
            Children.Add(new csharp());
            Children.Add(new xamarin());
		}
	}
}
