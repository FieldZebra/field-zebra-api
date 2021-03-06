using Field.Zebra.Domain.Catalog;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace Field.Zebra.Data
{
    public static class DbInitializer
    { 
        public static void Initializer(Field_Zebra_Api.Data.StoreContext context, ILogger logger)
        {
            if(!context.Items.Any())
            {
                var items = new Item[]
                {
                    new Item("T-Shirt", "Ohio State Block O", "Nike", "d1.jpg", 39.99m),
                    new Item("Shorts", "Casual shorts", "Nike", "d1.jpg", 49.99m)
                };
                context.Items.AddRange(items);
                context.SaveChanges();
            }
        }
    }
}