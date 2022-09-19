using System.Collections.Generic;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.InputModels;

namespace TechnicalRadiation.Services.Interfaces
{
    public interface INewsItemsService
    {
        IEnumerable<NewsItemsDto> GetAllNewsItems();
        NewsItemDetailDto GetNewsItemById(int id);
        IEnumerable<AlbumDto> GetAlbumsByArtistId(int artistId);
        IEnumerable<SongDto> GetSongsByArtistId(int artistId);
        int CreateNewArtist(ArtistInputModel artist);
        void UpdateArtist(int id, ArtistInputModel artist);
        void DeleteArtist(int id);
    }
}