using System.Collections.Generic;
using System;

namespace Simple.Domain
{
    public class Song
    {
        public Guid Id { get; set; }
        public IEnumerable<Artist> Artists { get; set; }
        public string Title { get; set; }
        public TimeSpan Length { get; set; }
        public IEnumerable<Rating> Ratings { get; set; }
    }
}
