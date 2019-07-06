using System;
using Simple.Domain;

namespace Simple.DomainServices
{
    public interface IArtistDomainService
    {
        Artist GetArtist(string name);
        Artist GetArtist(Guid artistId);
        void AddArtist(Artist newArtist);
        void UpdateArtist(Artist artistToUpdate);
        void RateArtist(Artist artist, Rating rating);
    }
}