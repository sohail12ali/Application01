using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application01.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : TabbedPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}
	}
}