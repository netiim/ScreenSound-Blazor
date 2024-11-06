using ScreenSound.API.Requests;
using ScreenSound.API.Response;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Json;

namespace ScreenSound.Web.Services;

public class ArtistaAPI
{
    private readonly HttpClient _httpClient;

    public ArtistaAPI(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient("API");
    }

    public async Task<ICollection<ArtistaResponse>?> GetArtistasAsync()
    {
        return await _httpClient.GetFromJsonAsync<ICollection<ArtistaResponse>?>("artistas");
    }

    public async Task AddArtistaAsync(ArtistaRequest request)
    {
        await _httpClient.PostAsJsonAsync("artistas", request);
    }
}
