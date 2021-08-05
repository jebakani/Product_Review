using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management System");
            ReviewManager review = new ReviewManager();
            List<ProductReview> list= review.AddReviews();
            //review.CreateDataTable(list);
            review.IterateMethod(review.RetriveTheRecordOfUserId(10));
        }
    }
}
