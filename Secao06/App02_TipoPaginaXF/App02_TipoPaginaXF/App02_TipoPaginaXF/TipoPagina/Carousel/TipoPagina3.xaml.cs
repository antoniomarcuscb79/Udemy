﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TipoPagina.Carousel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TipoPagina3 : ContentPage
    {
        public TipoPagina3()
        {
            InitializeComponent();
        }

        private void MudarPagina(object sender, EventArgs args)
        {
            //FORCA A MUDANCA DA PAGINA - METODO DEFINIDO NA ACAO CLICKED
            //App.Current.MainPage = new NavigationPage(new Navigation.Pagina1()) { BackgroundColor = Color.WhiteSmoke };
            App.Current.MainPage = new Tabbet.Abas();
            
        }
    }
}