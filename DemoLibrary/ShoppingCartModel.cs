using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class ShoppingCartModel
    {
        public delegate void MentionDiscount(decimal subtotal);
        public List<ProductModel> Items { get; set; } = new List<ProductModel>();
        
        public decimal GenerateTotal(MentionDiscount mentionDiscount,Func<List<ProductModel>,decimal,decimal> calculateDiscaountedTotal, Action<String> tellAboutDiscount)
        {
            decimal subTotal = Items.Sum(x => x.Price);
            mentionDiscount(subTotal);

            tellAboutDiscount("we are giving a big discount");

            return calculateDiscaountedTotal(Items,subTotal);

        }
    }
}
