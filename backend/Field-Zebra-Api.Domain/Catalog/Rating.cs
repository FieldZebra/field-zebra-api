using System;
namespace Field.Zebra.Domain.Catalog
{
    public class Rating{

        public int Star { get; set; }
        public string UserName { get; set; }
        public string Review { get; set; }

        public int Id { get; set; }

        public Rating(int star, string userName, string review)
            {
            if(star < 1 || star > 5)
            {
                throw new ArgumentException("star rating must be an integer: 1, 2, 3, 4, or 5.");
            }
            if (string.IsNullOrEmpty(userName))
            {
                throw new ArgumentException("Username cannot be null");
            }
            this.Star = star;
            this.UserName = userName;
            this.Review = review;
        }
    }

    
 
}

