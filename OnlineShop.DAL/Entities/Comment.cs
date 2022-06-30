namespace OnlineShop.DAL.Entities
{
    public class Comment : BaseModel
    {
        public string Description { get; set; }
        public string Title { get; set; }
        public string ReviewPositive { get; set; }
        public string ReviewNegative { get; set; }
        public int Rating { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
