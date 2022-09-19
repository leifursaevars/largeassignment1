using System.Collections.Generic;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Repositories.Interfaces;
using TechnicalRadiation.Services.Interfaces;
using TechnicalRadiation.Models.Envelopes;

namespace TechnicalRadiation.Services.Implementations
{
    public class NewsItemsService : IArtistService
    {
        private readonly INewsItemsRepository _newsitemsRepository;

        public ArtistService(IArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
        }

        public IEnumerable<AlbumDto> GetAlbumsByArtistId(int artistId)
        {
            return _artistRepository.GetAlbumsByArtistId(artistId);
        }

        public IEnumerable<NewsItemsDto> GetAllNewsItems(int pageSize, int pageNumber)
        {
            IEnumerable<NewsItemsDto> newsitems = _newsitemsRepository.GetAllNewsItems();
            var Envelope = new Envelope<NewsItemsDto>(pageNumber, pageSize, newsitems);
            return Envelope;
        }

        public ArtistDetailsDto GetArtistById(int id)
        {
            return _artistRepository.GetArtistById(id);
        }

        public IEnumerable<SongDto> GetSongsByArtistId(int artistId)
        {
            return _artistRepository.GetSongsByArtistId(artistId);
        }
        
        public int CreateNewArtist(ArtistInputModel artist)
        {
            return _artistRepository.CreateNewArtist(artist);
        }

        public void UpdateArtist(int id, ArtistInputModel artist)
        {
            _artistRepository.UpdateArtist(id, artist);
        }

        public void DeleteArtist(int id)
        {
            _artistRepository.DeleteArtist(id);
        }
    }
}