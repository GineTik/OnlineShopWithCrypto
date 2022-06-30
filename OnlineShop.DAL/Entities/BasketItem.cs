namespace OnlineShop.DAL.Entities
{
    public class BasketItem : BaseModel
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
    }
}
