using System;
using SimpleCqrs.Domain;

namespace MovieCQRS.Domain.Models
{
    public class MovieReview : AggregateRoot
    {
        public string Content { get; set; }
        public string Reviewer { get; set; }
        public string Publication { get; set; }

        public MovieReview(Guid reviewId, string content, string reviewer, string publication)
        {
            //Implementation done in Part 2
        }
    }
}