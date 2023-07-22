using Discoteque.Business.IServices;
using Discoteque.Data.Models;
namespace Discoteque.Business.Services;

public class ArtistService : IArtistService
{
    public async Task<IEnumerable<Artist>> GetArtistsAsync()
    {
        var rand= new Random();
        var artistList= new List<Artist>();

        artistList.Add(new Artist(){
        Id=rand.Next(101),
        Name="Bad Bunny",
        Label="Reaggaeton",
        IsOnTour=false
        });

        artistList.Add(new Artist(){
        Id=rand.Next(101),
        Name="Ferxxo",
        Label="Reaggaeton",
        IsOnTour=false
        });

        artistList.Add(new Artist(){
        Id=rand.Next(101),
        Name="Daddy Yankee",
        Label="Reaggaeton",
        IsOnTour=false
        });

        artistList.Add(new Artist(){
        Id=rand.Next(101),
        Name="Lasso",
        Label="Pop",
        IsOnTour=true
        });

        artistList.Add(new Artist(){
        Id=rand.Next(101),
        Name="J Balvin",
        Label="Reaggaeton",
        IsOnTour=false
        });
        return artistList;
    }
    public Task<Artist> GetById(int id)
    {
        throw new NotImplementedException();
    }
    public Task<Artist> CreateArtist(Artist artist)
    {
        throw new NotImplementedException();
    }
    public Task<Artist> UpdateArtist(Artist artist)
    {
        throw new NotImplementedException();
    }
}
