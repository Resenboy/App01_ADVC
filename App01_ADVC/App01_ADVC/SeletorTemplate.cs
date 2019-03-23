﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App01_ADVC
{
    public class SeletorTemplate : DataTemplateSelector
    {
        DataTemplate ItemPessoaObrigatoria;
        DataTemplate ItemPessoaNObrigatoria;

        public SeletorTemplate()
        {
            ItemPessoaObrigatoria = new DataTemplate(typeof(Templates.ItemPessoaObrigatorioViewCell));
            ItemPessoaNObrigatoria = new DataTemplate(typeof(Templates.ItemPessoaNObrigatorioViewCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            MainPage.Pessoa pessoa = item as MainPage.Pessoa;

            if (pessoa.IsRequired)
            {
                return ItemPessoaObrigatoria;
            }
            else
            {
                return ItemPessoaNObrigatoria;
            }
        }
    }
}
