namespace Cothes_store.Models
{
    public class Reviews
    {
        public int reviewId { get; set; }
        public int customer_id { get; set; }
        public string comment { get; set;}
        public DateOnly date {  get; set; }
        public int stars {  get; set; }


    }
}
