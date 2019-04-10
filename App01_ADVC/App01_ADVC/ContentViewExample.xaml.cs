using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ADVC
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContentViewExample : ContentPage
	{
		//public List<string> Games { get; set; }
		
		public ContentViewExample()
		{
			InitializeComponent();
			

			this.BindingContext = new ViewModel.MainViewModel();

			 void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
			{
				cvGames.ScrollTo((int)Math.Floor(e.NewValue));
			}
			//var Games = new List<string> { "ALVIN", "JOSE", "JOAO" };

			//var images = new ObservableCollection<string>
			//{
			//	"https://www.google.com.br/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwi-wuOj78HhAhXbIbkGHTuyBiQQjRx6BAgBEAU&url=https%3A%2F%2Finstabug.com%2Fblog%2Fxamarin-development%2F&psig=AOvVaw3umwz4PSesc8h5gTs0LWOi&ust=1554860069098995",
			//	"https://www.google.com.br/search?hl=pt-BR&authuser=0&tbm=isch&source=hp&biw=1366&bih=625&ei=oParXJPJH7K65OUPruyCyAM&q=xamain&oq=xamain&gs_l=img.3..0i10i24l2.2860.3466..3642...0.0..0.132.752.0j6......1....1..gws-wiz-img.....0..0j35i39j0i30j0i5i30._v1Dxygplrs#imgdii=bT72l0f9ngNDVM:&imgrc=r8mIwFrsCmB2hM:",
			//	"https://www.google.com.br/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwia6Oe478HhAhUTA9QKHaLwAI8QjRx6BAgBEAU&url=https%3A%2F%2Fwww.netsolutions.com%2Finsights%2Fflutter-vs-react-native-vs-xamarin-which-framework-is-right-for-you%2F&psig=AOvVaw2w-rTFda6R6wOWjWCCIrOu&ust=1554860109766283"
			//};

			//MainCarouselView.ItemsSource = images;//Games;

		}

		private void CvGames_Focused(object sender, FocusEventArgs e)
		{
			cvGames.BackgroundColor = Color.Aqua;
		}
	}
}