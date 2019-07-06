using System;

namespace Simple.Domain
{
    public class Rating
    {
        public Guid Id{ get; }
        public string RatedByName { get; }
        private int _rating;        

        public Rating(Guid ratingId, string ratedByName)
        {
            Id = ratingId;
        }

        public Rating(string ratedByName) : this(Guid.NewGuid(), ratedByName)
        {}

        public int GetRating()
        {
            return _rating;
        }

        public void SetRating(int rating)
        {
            if(rating < 0 || rating > 5)
                throw new ArgumentOutOfRangeException(nameof(rating), "Rating must be between 0 and 5 stars.");
            
            _rating = rating;
        }
    }
}
