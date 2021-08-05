using System;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management System");
            ReviewManager review = new ReviewManager();
            review.AddReviews();
            review.IterateMethod(review.Top3RatedProduct());
            review.IterateMethod(review.RetrivalRecordRatingGreaterThan3());
            review.IterateMethod(review.SkipTop5Record());
            review.CountOfUser();
        }
    }
}
