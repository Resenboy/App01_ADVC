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

            lblWelcome.FontFamily = Device.OnPlatform(null, "Bangers-Regular.ttf#Bangers", null);

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

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentViewExample());
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            await Navigation.PopAsync(true);
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TabPage());
        }
    }
}
