using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public class Car
    {
        public string MarkaCar { get; set; }
        public string ModelCar { get; set; }
        public string BodyTipe { get; set; }
        public double EngineСapacity { get; set; }
        public int Price { get; set; }
        public string ManufacturerCountry { get; set; }
        public bool Electro { get; set; }
     
        public Car()
        {

        }
        public Car(string markaCar, string modelCar, string bodyTipe, double engineСapacity, int prise, string manuFacturerCountry, bool electro )
        {
            MarkaCar = markaCar;
            ModelCar = modelCar;
            BodyTipe = bodyTipe;
            EngineСapacity = engineСapacity;
            Price = prise;
            ManufacturerCountry = manuFacturerCountry;
            Electro = electro;
        }
    }
}
