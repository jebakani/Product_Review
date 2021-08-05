using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductReviewManagement;
using System.Collections.Generic;

namespace ProductReviewTest
{
    [TestClass]
    public class UnitTest1
    {
        ReviewManager review;
        [TestInitialize]
        public void TestSetUp()
        {
            review = new ReviewManager();
            List<ProductReview> list = review.AddReviews();
        }
        [TestMethod]
        //UC2-Retrive top3  rated product from the list
        public void Top3BYRatingTest()
        {
            List<ProductReview> expected = new List<ProductReview> { new ProductReview() { productId = 8, userId = 67, rating = 20, review = "good", isLike = true }, new ProductReview() { productId = 7, userId = 6, rating = 19, review = "good", isLike = true }, new ProductReview() { productId = 8, userId = 9, rating = 18, review = "good", isLike = true } };
            List<ProductReview>  actual = review.Top3RatedProduct();
            expected.Equals(actual);
        }
        [TestMethod]
        //UC3-Count of person gave review
        public void CountOfUserReviewAProduct()
        {
            string expected = "1 3 7 2 3 3 8 3 2 3 6 3 5 2 4 2 10 1 9 3 ";
            string actual = review.CountOfUser();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        //UC4-Retrive all products data whoes rating greater than 3 and product id 1,4 or 9
        public void AllRecordRetrivalTest()
        {
            List<ProductReview> expected = new List<ProductReview> { new ProductReview() { productId = 1, userId = 3, rating = 10, review = "Average", isLike = true }new ProductReview() { productId = 4, userId = 11, rating = 6, review = "bad", isLike = false }, new ProductReview() { productId = 9, userId = 8, rating = 8, review = "Average", isLike = true }, new ProductReview() { productId = 1, userId = 9, rating = 13, review = "good", isLike = true }, new ProductReview() { productId = 9, userId = 2, rating = 5, review = "bad", isLike = false }, new ProductReview() { productId = 9, userId = 10, rating = 5, review = "bad", isLike = false } };
            List<ProductReview> actual = review.RetrivalRecordRatingGreaterThan3();
            expected.Equals(actual);
        }

    }
}
