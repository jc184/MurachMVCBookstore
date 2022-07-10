using MurachMVCBookstore.Models.DomainModels;
using MurachMVCBookstore.Models.Grid;
using System.Collections.Generic;

namespace MurachMVCBookstore.Models.ViewModels
{
    public class CartViewModel
    {
        public IEnumerable<CartItem> List { get; set; }
        public double Subtotal { get; set; }
        public RouteDictionary BookGridRoute { get; set; }
    }
}
