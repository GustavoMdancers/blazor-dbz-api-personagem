using BlazorDbzPersonagem.Models;

namespace BlazorDbzPersonagem.Services;

public class DbzService
{
    private readonly HttpClient _http;

    public DbzService(HttpClient http) => _http = http;

    public async Task<Personagem?> ObterPersonagemAsync(int id)
    {
        try
        {
            return await _http.GetFromJsonAsync<Personagem>($"characters/{id}");
        }
        catch (HttpRequestException)
        {
            return null; // 404 ou erro de rede
        }
    }
}