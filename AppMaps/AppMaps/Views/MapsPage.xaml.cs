using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppMaps.Models;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace AppMaps.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapsPage : ContentPage
    {
        public MapsPage()
        {
            InitializeComponent();

            // Crear una mascota de ejemplo
            PetModel pet = new PetModel 
            {
                ID = 1,
                Name = "Loki",
                Age = 1,
                Breed = "Poomeranian",
                Latitude = 10.354465412342,
                Longitude = -1.349358538932
            };

            // Centrar el mapa con las coordenadas de la mascota
            MapControl.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    new Position(
                        pet.Latitude,
                        pet.Longitude
                    ), Distance.FromMiles(.5)
                )
            ); ;

            // Agregar un pin al mapa con las coordenadas de la mascota
            MapControl.Pins.Add(
                new Pin{
                    Type = PinType.Place,
                    Label = pet.Name,
                    Position = new Position (
                        pet.Latitude,
                        pet.Longitude
                    )
                }
            );

            // Ponemos los datos de la mascota en el cuadro blanco (BoxView)
            NameLabel.Text = pet.Name;
            AgeLabel.Text = $"{pet.Age} año" + (pet.Age > 1 ? "s" : "");
            BreedLabel.Text = pet.Breed;
        }
    }
}