namespace OnlineShop.DAL.Entities
{
    public class BasketItem : BaseModel
    {
        public int Amount { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
