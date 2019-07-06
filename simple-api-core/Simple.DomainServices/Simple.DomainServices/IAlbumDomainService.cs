using System;
using Simple.Domain;

namespace Simple.DomainServices
{
    public interface IAlbumDomainService
    {
        Album GetAlbum(string title);
        Album GetAlbum(Guid albumId);
        void AddAlbum(Album albumToAdd);
        void UpdateAlbum (Album updatedAlbum);
        void RateAlbum(Album album, Rating rating);
    }
}