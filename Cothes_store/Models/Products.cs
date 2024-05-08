using static System.Net.Mime.MediaTypeNames;

namespace Cothes_store.Models
{
    public class Products
    {
        public int product_id {  get; set; }
        public string? product_name { get; set;}
        public string? description { get; set;}
        public int price { get; set;}
        public int quantity { get; set;}
        public string? category_name {  get; set;}
        public string? gander { get; set; }
        public string? marka { get; set; }
        public string? size { get; set; }
        public byte[]? imageData { get; set; }
    }
}
