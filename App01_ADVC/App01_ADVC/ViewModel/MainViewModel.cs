using App01_ADVC.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace App01_ADVC.ViewModel
{
	public class MainViewModel : INotifyPropertyChanged
	{
		#region Property

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
		{
			if (EqualityComparer<T>.Default.Equals(storage, value))
			{
				return false;
			}

			storage = value;
			OnPropertyChanged(propertyName);
			return true;
		}

		#endregion

		public ObservableCollection<Game> Games { get; }

		private int _rating;
		public int Rating
		{
			get { return _rating; }
			set => SetProperty(ref _rating, value);
		}

		public MainViewModel()
		{
			Games = new ObservableCollection<Game>();

			Games.Add(new Game
			{
				Nome = "God of War",
				TituloBR = "O bom da guerra",
				Imagem = "bear.jpg",
				screenWidth = Application.Current.MainPage.Width / 2
		});

			Games.Add(new Game
			{
				Nome = "The last of us",
				TituloBR = "Nois que sobramus",
				Imagem = "https://www.google.com.br/search?hl=pt-BR&authuser=0&tbm=isch&source=hp&biw=1366&bih=625&ei=oParXJPJH7K65OUPruyCyAM&q=xamain&oq=xamain&gs_l=img.3..0i10i24l2.2860.3466..3642...0.0..0.132.752.0j6......1....1..gws-wiz-img.....0..0j35i39j0i30j0i5i30._v1Dxygplrs#imgdii=bT72l0f9ngNDVM:&imgrc=r8mIwFrsCmB2hM:",
				screenWidth = Application.Current.MainPage.Width / 2
			});

			Games.Add(new Game
			{
				Nome = "Mario Kart 8",
				TituloBR = "Correndo com meus Amig..Inimigos",
				Imagem = "https://www.google.com.br/url?sa=i&source=images&cd=&cad=rja&uact=8&ved=2ahUKEwia6Oe478HhAhUTA9QKHaLwAI8QjRx6BAgBEAU&url=https%3A%2F%2Fwww.netsolutions.com%2Finsights%2Fflutter-vs-react-native-vs-xamarin-which-framework-is-right-for-you%2F&psig=AOvVaw2w-rTFda6R6wOWjWCCIrOu&ust=1554860109766283",
				screenWidth = Application.Current.MainPage.Width / 2
			});

			Games.Add(new Game
			{
				Nome = "Super Mario Odyssey",
				TituloBR = "As viagens do Bigode"
			});

			Games.Add(new Game
			{
				Nome = "Halo",
				TituloBR = "E eu passei metiolate"
			});

		}

	}
}
