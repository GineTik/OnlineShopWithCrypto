namespace OnlineShop.DAL.Entities
{
    public class Product : BaseModel
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public string About { get; set; }
    }
}
