﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace RuaSegura
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Pin pinentra21 = new Pin()
            {
                Type = PinType.Place,
                Label = "Entra21",
                Address = "Av. Brasil, 610 - Ponta Aguda, Blumenau - SC, 89050-000",
                Position = new Position(-26.915287, -49.064202),
                Tag = "id_entra21",
            };

            map.Pins.Add(pinentra21);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(pinentra21.Position, Distance.FromMeters(1000)));
          
        }
    }
}
