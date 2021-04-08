using System;
namespace Field.Zebra.Domain.Catalog
{
    public class Rating{
        public int Star { get; set; }
        public string UserName { get; set; }
        public string Review { get; set; }
    }
}

public Rating( int stars, string userName, string review)
{
    if(stars < 1 || stars > 5)
    {
        throw new ArgumentException("star rating must be an integer: 1, 2, 3, 4, or 5.")
    }
    if (string.IsNullOrEmpty(userName))
    {
        throw new ArgumentException("Username cannot be null")
    }
    this.Star = stars;
    this.Username = userName;
    this.Review = review;
}