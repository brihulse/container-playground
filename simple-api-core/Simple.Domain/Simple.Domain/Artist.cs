using System;
using System.Collections.Generic;

namespace Simple.Domain
{
    public class Artist
    {
        public Guid Id{ get; set; }
        public string Name { get; set; }

        public IEnumerable<Album> Albums { get; set; }

        public IEnumerable<Song> Songs { get; set; }

        public IEnumerable<Rating> Ratings{ get; set; }
    }
}
