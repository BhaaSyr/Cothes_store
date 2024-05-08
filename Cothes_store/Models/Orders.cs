namespace Cothes_store.Models
{
    public class Orders
    {
        public int order_id { get; set; }
        public int customer_id { get; set;}
        public DateOnly order_date { get; set;}
        public string total_amount { get; set;}
    }
}
