namespace DersModelYapisi.Models
{
    public class CardProduct
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal price { get; set; }
    }
}
