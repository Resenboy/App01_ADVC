using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ADVC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabPage : ContentPage
    {
        
        public TabPage()
        {
            InitializeComponent();
            this.page1.CornerRadius = 30;
            //this.Appearing += (sender, e) => Label.Text = string.Format(Label.Text, Title);
        }

        int indexPaginaAtual = 0;
        private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            if (e.Direction == SwipeDirection.Left)
            {
                if (indexPaginaAtual == 0)
                {
                    indexPaginaAtual++;
                    this.page1.CornerRadius = 0;
                    this.page2.CornerRadius = 30;
                    this.frameColor.BackgroundColor = Color.DarkBlue;
                }
                else if (indexPaginaAtual == 1)
                {
                    indexPaginaAtual++;
                    this.page2.CornerRadius = 0;
                    this.page3.CornerRadius = 30;
                    this.frameColor.BackgroundColor = Color.DarkGreen;
                    frameColor.Content = new FixedScrollTest();
                }
                if (indexPaginaAtual < 2)
                    DisplayAlert("SWIPE", "Swipe para a direita, vai para página " + indexPaginaAtual.ToString(), "OK");
                else
                    DisplayAlert("SWIPE", "Swipe para a direita, mas já é a ultima. " + indexPaginaAtual.ToString(), "OK");
            }
            else if (e.Direction == SwipeDirection.Right)
            {
                if (indexPaginaAtual == 2)
                {
                    indexPaginaAtual--;
                    this.page3.CornerRadius = 0;
                    this.page2.CornerRadius = 30;
                    this.frameColor.BackgroundColor = Color.DarkBlue;
                }
                else if (indexPaginaAtual == 1)
                {
                    indexPaginaAtual--;
                    this.page1.CornerRadius = 30;
                    this.page2.CornerRadius = 0;
                    this.frameColor.BackgroundColor = Color.Purple;
                    frameColor.Content = new View1();
                }

                if (indexPaginaAtual > 0)
                    DisplayAlert("SWIPE", "Swipe para a Esquerda, vai para página " + indexPaginaAtual.ToString(), "OK");
                else
                    DisplayAlert("SWIPE", "Swipe para a esquerda, mas já é a ultima. " + indexPaginaAtual.ToString(), "OK");
            }
        }
    }
}