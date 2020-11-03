using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EjemploRefreshView
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void refreshingActivado_Clicked(object sender, EventArgs e)
        {
            refresh.IsRefreshing = true;
        }

        private void refreshingDesctivado_Clicked(object sender, EventArgs e)
        {
            refresh.IsRefreshing = false;
        }
    }
}
