using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudBike.Models.ViewModels
{
    public class MotorBikeViewModel
    {
        public MotorBike MotorBike { get; set; }
        public IEnumerable<Make> Makes { get; set; }
        public IEnumerable<Model> Models { get; set; }
        public IEnumerable<Currency> Currencies { get; set; }

        private List<Currency> CList = new List<Currency>();
        private List<Currency> CreateList()
        {
            CList.Add(new Currency("USD", "USD"));
            CList.Add(new Currency("SEK", "SEK"));
            CList.Add(new Currency("EUR", "EUR"));
            return CList;
        }

        public MotorBikeViewModel()
        {
            Currencies = CreateList();
        }

    }


    public class Currency
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public Currency(String id, String name)
        {
            Id = id;
            Name = name;
        }
    }
}
