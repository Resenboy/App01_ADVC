using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App01_ADVC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //ListaFuncionarios.ItemsSource = GetFuncionarios();

            ListaFuncionarios.ItemsSource = new List<Grupo>
            {
                new Grupo("Presidente", "CEO", "Presidente da empresa")
                {
                    new Pessoa{ Nome = "Alvaro", IsRequired = true, RankEficiencia = 8}
                },
            };

            //TheScroll.PropertyChanged += OnScrollViewPropertyChanged;
            //BearImage.SizeChanged += OnBearImageSizeChanged;
            //FixedStack.SizeChanged += OnTitleTextSizeChanged;
        }

        private List<Grupo> GetFuncionarios()
        {
            return new List<Grupo>
            {
                new Grupo("Presidente", "CEO", "Presidente da empresa")
                {
                    new Pessoa{ Nome = "Alvaro", IsRequired = true, RankEficiencia = 8}
                },

                new Grupo("Diretor", "Dir.", "Diretor da empresa")
                {
                    new Pessoa{ Nome = "Django", IsRequired = false, RankEficiencia =6 },
                    new Pessoa{ Nome = "Vinicius", IsRequired = true, RankEficiencia = 8}
                },

                new Grupo("Gerentes", "Ger.", "Gerente da empresa")
                {
                    new Pessoa{ Nome = "Bira", IsRequired = true, RankEficiencia = 7},
                    new Pessoa{ Nome = "Chines", IsRequired = false, RankEficiencia = 9}
                },

                new Grupo("Funcionarios", "Func.", "Funcionarios da empresa")
                {
                    new Pessoa{ Nome = "Bira",IsRequired = false},
                    new Pessoa{ Nome = "Chines",IsRequired = false},
                    new Pessoa{ Nome = "Django",IsRequired = false },
                    new Pessoa{ Nome = "Vinicius",IsRequired = true, RankEficiencia = 6},
                    new Pessoa{ Nome = "Alvaro",IsRequired = false},
                    new Pessoa{ Nome = "Bira",IsRequired = false},
                    new Pessoa{ Nome = "Chines",IsRequired = false},
                    new Pessoa{ Nome = "Django" ,IsRequired = false},
                    new Pessoa{ Nome = "Vinicius",IsRequired = false},
                    new Pessoa{ Nome = "Alvaro",IsRequired = false}
                }
            };
        }

        public class Grupo : List<Pessoa>
        {
            public string Titulo { get; set; }
            public string TituloCurto { get; set; }
            public string Descricao { get; set; }

            public Grupo(string titulo, string tituloCurto, string descricao)
            {
                Titulo = titulo;
                TituloCurto = tituloCurto;
                Descricao = descricao;
            }
        }

        public class Pessoa
        {
            public string Nome { get; set; }
            public int RankEficiencia { get; set; }
            public bool IsRequired { get; set; }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ListaFuncionarios.ItemTemplate = null;
            ListaFuncionarios.ItemTemplate = new DataTemplate(typeof(ViewCellTextFeed));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            ListaFuncionarios.ItemTemplate = null;
            ListaFuncionarios.ItemTemplate = new DataTemplate(typeof(ViewCellTextFeed1));
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            ListaFuncionarios.ItemTemplate = null;
            ListaFuncionarios.ItemTemplate = new DataTemplate(typeof(ViewCellTextFeed2));
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DemoPage());
        }


        //double _titleTextTop;
        //private void OnTitleTextSizeChanged(object sender, System.EventArgs e)
        //{
        //    FixedStack.SizeChanged -= OnTitleTextSizeChanged;

        //    //As soon as the news header has been repositioned, we can grab the actual screen top position
        //    _titleTextTop = FixedStack.Y;

        //    //Remark: GetScreenCoordinates will get the actual position on screen instead of the actual position inside the parent
        //    //_titleTextTop = GetScreenCoordinates(TitleText).Y;
        //}

        //private void OnBearImageSizeChanged(object sender, System.EventArgs e)
        //{
        //    BearImage.SizeChanged -= OnBearImageSizeChanged;

        //    //When the bear image has been loaded, reposition the news header to the bottom of this image
        //    FixedStack.Margin = new Thickness(0, BearImage.Height - 40, 0, 0);
        //}

        //private void OnScrollViewPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        //{
        //    if (e.PropertyName.Equals(ScrollView.ScrollYProperty.PropertyName))
        //    {
        //        var scrolled = ((ScrollView)sender).ScrollY;
        //        System.Diagnostics.Debug.WriteLine($"Y position: {scrolled.ToString()}");

        //        if (scrolled < _titleTextTop)
        //            FixedStack.TranslationY = (0 - scrolled);
        //        else
        //            FixedStack.TranslationY = (0 - _titleTextTop);
        //    }
        //}

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FixedScrollTest());
        }
    }
}
