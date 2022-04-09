using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DemoSqlite.Services;
using DemoSqlite.Models;

namespace DemoSqlite.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        ArtistaService service = new ArtistaService();
        public Page1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            try
            {
                
                service.Create(new Artista { Nombre = txtNombre.Text });
                DisplayAlert("OK", "OK", "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", "ERROR", "ERROR");
                throw ex;
            }
            
        }

        private void btnListaa_Clicked(object sender, EventArgs e)
        {            
            lvArtistas.ItemsSource = service.Get();
        }

        private void btnGuardarGrupal_Clicked(object sender, EventArgs e)
        {
            List<Artista> artistas = new List<Artista>();
            for (int i = 0; i < 3; i++)            
                artistas.Add(new Artista { Nombre = txtNombre.Text });


            service.CreateRange(artistas);
            DisplayAlert("OK", "OK", "OK");
        }

        private void btnEliminar_Clicked(object sender, EventArgs e)
        {
            service.DeleteAll();
        }
    }
}