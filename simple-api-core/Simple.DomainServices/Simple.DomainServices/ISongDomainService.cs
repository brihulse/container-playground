using System;
using Simple.Domain;

namespace Simple.DomainServices
{
    public interface ISongDomainService
    {
        Song GetSong(string title);
        Song GetSong(Guid songId);
        void AddSong(Song newSong);
        void UpdateSong(Song songToUpdate);
        void RateSong(Song song, Rating rating);
    }
}