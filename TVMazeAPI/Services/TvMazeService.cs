using System.Net.Http.Json;
using TVMazeAPI.Models;

namespace TVMazeAPI.Services;

public class TvMazeService
{
    private const string BaseUrl = "https://api.tvmaze.com";
    private readonly HttpClient http;

    public TvMazeService(HttpClient http)
    {
        this.http = http;
    }

    public async Task<List<ScheduleItem>> GetScheduleAsync()
    {
        var items = await http.GetFromJsonAsync<List<ScheduleItem>>($"{BaseUrl}/schedule?country=GB");

        return items ?? new();
    }

    public async Task<List<SearchResult>> SearchShowsAsync(string query)
    {
        string escapedQuery = Uri.EscapeDataString(query);
        var results = await http.GetFromJsonAsync<List<SearchResult>>($"{BaseUrl}/search/shows?q={escapedQuery}");

        return results ?? new();
    }

    public async Task<Show?> GetShowAsync(int id)
    {
        var show = await http.GetFromJsonAsync<Show>($"{BaseUrl}/shows/{id}");
        return show;
    }

    public async Task<List<CastMember>> GetCastAsync(int id)
    {
        var cast = await http.GetFromJsonAsync<List<CastMember>>($"{BaseUrl}/shows/{id}/cast");

        return cast ?? new();
    }

    public async Task<List<Episode>> GetEpisodesAsync(int id)
    {
        var episodes = await http.GetFromJsonAsync<List<Episode>>($"{BaseUrl}/shows/{id}/episodes");

        return episodes ?? new();
    }
}