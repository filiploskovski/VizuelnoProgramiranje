using System.Collections.Generic;
using System.Linq;

namespace PotrosuvackaKosnicka.Models
{
    public class CardModel
    {
        
    }

    public static class Card
    {
        public static List<ProductModel> CardList { get; set; } = new List<ProductModel>();

        public static List<string> GetAllInListBoxModel()
        {
            return CardList.Select(item => item.Name).ToList();
        }
    }
}