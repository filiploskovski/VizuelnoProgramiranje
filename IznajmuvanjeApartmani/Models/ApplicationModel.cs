using System.Collections.Generic;
using System.Linq;

namespace IznajmuvanjeApartmani.Models
{
    public class Apartments
    {
        public string Address { get; set; }
        public int Price { get; set; }
    }

    public class City
    {
        public string Name { get; set; }
        public int PostalCode { get; set; }
        public List<Apartments> Apartments { get; set; } = new List<Apartments>();
    }

    public static class ApplicationMemory
    {
        public static List<City> Cities { get; set; } = new List<City>();

        public static List<string> GetCitiesForListBox()
        {
            return Cities.Select(item => item.Name).ToList();
        }

        public static List<string> GetApartmestsForCityListBox(string city)
        {
            return Cities.FirstOrDefault(item => item.Name.ToLower() == city.ToLower()).Apartments
                .Select(item => item.Address).ToList();
        }
    }
}