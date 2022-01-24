/*
    This class is for the item database so all items not just
    ones in specific stores.
*/
namespace ProjectZeroModel
{
    public class Item
    {
        public string? ItemName { get; set; }
        public int ItemNumber { get; set; }
        public Double ItemPrice { get; set; }
        public string? ItemDesc { get; set; }
        public string? ItemCat { get; set; }
        public static Dictionary <int, Item>? _allItems = new Dictionary<int, Item>()
        {
            {000, new Item{ ItemName = "", ItemPrice = 0.00, ItemDesc = "No Description Available", ItemCat = "" }},
        };
        
    
    
    
    
    }

}
