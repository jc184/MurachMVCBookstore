using MurachMVCBookstore.Models.DomainModels;
using MurachMVCBookstore.Models.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace MurachMVCBookstore.Models.ExtensionMethods
{
    public static class CartItemListExtensions
    {
        public static List<CartItemDTO> ToDTO(this List<CartItem> list) =>
            list.Select(ci => new CartItemDTO
            {
                BookId = ci.Book.BookId,
                Quantity = ci.Quantity
            }).ToList();
    }
}
