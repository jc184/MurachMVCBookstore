using MurachMVCBookstore.Models.DTOs;
using Newtonsoft.Json;

namespace MurachMVCBookstore.Models.DomainModels
{
    public class CartItem
    {
        public BookDTO Book { get; set; }
        public int Quantity { get; set; }

        [JsonIgnore]
        public double Subtotal => Book.Price * Quantity;
    }
}
