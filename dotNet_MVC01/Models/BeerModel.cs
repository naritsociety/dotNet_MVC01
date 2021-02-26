using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNet_MVC01.Models
{
    public class BeerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

    }

    public class Beer
    {
        public List<BeerModel> GetAllBeer()
        {
            return new List<BeerModel>
            {
                new BeerModel { Id =1, Name="Redhorse", Type="Lager" },
                new BeerModel { Id =2, Name="Furious", Type="IPA" },
                new BeerModel { Id =3, Name="Guinness", Type="Stout" },
                new BeerModel { Id =4, Name="Sierra", Type="Ale" },
                new BeerModel { Id =5, Name="Stella", Type="Pilsner" },
            };
        }
    }
}
