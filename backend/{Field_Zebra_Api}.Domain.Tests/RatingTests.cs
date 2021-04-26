using Field.Zebra.Domain.Catalog;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _Field_Zebra_Api_.Domain.Tests
{
    [TestClass]
    public class RatingTests
    {
        [TestMethod]
        public void Can_Create_New_Rating()
        {

            var rating = new Rating(1, "Mike", "Great fit!");

            Assert.AreEqual(1, rating.Star);
            Assert.AreEqual("Mike", rating.UserName);
            Assert.AreEqual("Great fit!", rating.Review);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_With_Bad_Start_Throws_Error()
        {
            var rating = new Rating(0, "Name", "Review");
        }
    }
}
