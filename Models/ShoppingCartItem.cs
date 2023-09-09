using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Headers;

namespace MoShop.Models
{
    //This is where the columns of the database are created
    public class ShoppingCartItem
    {
        [Key]
        public string ShirtID {  get; set; }

        [Column (TypeName = "nvarchar(50)")]
        public string Size {  get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Price { get; set; }

    }

    public class ShoppingCart
    { 
        public List<ShoppingCartItem> Items { get; } = new List<ShoppingCartItem>();

        public void AddItem (ShoppingCartItem item)
        {
            Items.Add (item);
        }

        public void RemoveItem (string productID, string size) 
        { 
            var itemToRemove = Items.FirstOrDefault(item => item.ShirtID == productID && item.Size == size);
            if(itemToRemove != null)
            {
                Items.Remove (itemToRemove);
            }
        }

        public int calculatePrice()
        {
            var price = 0;
            foreach (var item in Items)
            {
                price = price + Int32.Parse (item.Price); 
            }

            return price;
        }
    }



}
