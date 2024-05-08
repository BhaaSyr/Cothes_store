namespace Cothes_store.Models
{
    public class Order_Items
    {
        public int order_item_id { get; set; }
        public int order_id { get; set; }
        public int product_id { get; set;}
        public int quantity { get; set;}
        public int price_per_unit { get; set;}
    }
}
