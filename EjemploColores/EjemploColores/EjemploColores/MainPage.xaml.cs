using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EjemploColores
{
    public partial class MainPage : ContentPage
    {
		public MainPage()
		{
			var red = new BoxView {BackgroundColor = Color.Red };
			var orange = new BoxView {BackgroundColor = Color.FromHex("FF6A00") };
			var yellow = new BoxView {BackgroundColor = Color.FromHsla(0.167, 1.0, 0.5, 1.0) };
			var green = new BoxView {BackgroundColor = Color.FromRgb(38, 127, 0) };
			var blue = new BoxView {BackgroundColor = Color.FromRgba(0, 38, 255, 255) };
			var indigo = new BoxView {BackgroundColor = Color.FromRgb(0, 72, 255) };
			var violet = new BoxView {BackgroundColor = Color.FromHsla(0.82, 1, 0.25, 1) };
			var transparentLabel = new Label { Text = "Transparente"};
			var transparent = new BoxView {BackgroundColor = Color.Transparent };
			var @defaultLabel = new Label { Text = "Por defecto" };
			var @default = new BoxView {BackgroundColor = Color.Default };
			var accentLabel = new Label { Text = "Accent" };
			var accent = new BoxView {BackgroundColor = Color.Accent };


			Content = new StackLayout
			{
				Padding = new Thickness(0, 20, 0, 0),
				Children = {
					red, orange, yellow, green, blue, indigo, violet,
					transparentLabel,transparent,@defaultLabel,@default,accentLabel, accent
				}
			};
		}
	}
}
