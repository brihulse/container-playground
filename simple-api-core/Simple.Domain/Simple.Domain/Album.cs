using System;
using System.Collections.Generic;

namespace Simple.Domain
{
    public class Album
    {
        public Guid Id{ get; set; }
        public IEnumerable<Artist> Artists { get; set; }
        public Dictionary<int, Song> Songs{ get; set; }
        public IEnumerable<Rating> Ratings { get; set; }
        public TimeSpan Length { get; set; }
    }
}
