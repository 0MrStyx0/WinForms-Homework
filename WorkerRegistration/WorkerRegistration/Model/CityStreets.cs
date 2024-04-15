using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerRegistration.Model
{
    public class CityStreets
    {
        public List<string> Baku { get; set; } = new List<string>()
       {
           "Narimanov",
           "Nasimi",
           "Yasamal",
           "Nizami"
       };

        public List<string> Moscow { get; set; } = new List<string>()
       {
           "Twerskaya",
           "Pushkin",
           "Boyarskiy pereulok",
           "Matreshkino"
       };

        public List<string> London { get; set; } = new List<string>()
       {
           "BakerStreet",
           "Hamish",
           "Birminghem",
           "TeaNox"
       };

        public List<string> NewYork { get; set; } = new List<string>()
       {
           "WallStreet",
           "District 1",
           "Five Avenyu",
           "Crossby"
       };
    }
}
