using System;
using System.Collections.Generic;
using System.Text;

namespace AppMaps.Models
{
    public class PetModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
