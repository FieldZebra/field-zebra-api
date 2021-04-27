using System.Collections.Generic;
using System;

namespace Field.Zebra.Domain.Catalog
{
    public class Item
    {
        private string v1;
        private string v2;
        private string v3;
        private decimal v4;

        public int ID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set;}
        public string Description { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public List<Rating> Ratings { get; set; }

        
        public Item(string name,  string description, string brand, string imageUrl, decimal price){
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Item name cannot be null");
            }
            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentException("Item description cannot be null");
            }

            if(string.IsNullOrEmpty(imageUrl)) {
                throw new ArgumentException("Image path cannot be null");
            }

            if(string.IsNullOrEmpty(brand))
            {
                throw new ArgumentException("Item brand cannot be null");
            }
            if (price < 0.00m || price>1000.00m)
            {
                throw new ArgumentException("Item price must be a positive amount less than $1000.00");
            }
            this.Name=name;
            this.ImageUrl = imageUrl;
            this.Description=description;
            this.Brand=brand;
            this.Price=price;
            this.Ratings = new List<Rating>();
        }

        public Item(string v1, string v2, string v3, decimal v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        public void AddRating(Rating rating){
            this.Ratings.Add(rating);
            
        }   
    }
    

}
