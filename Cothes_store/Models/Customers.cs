namespace Cothes_store.Models
{
    public class Customers
    {
        public int customer_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string phone_number { get; set; }
        public DateOnly logDate { get; set; }
    }
}
