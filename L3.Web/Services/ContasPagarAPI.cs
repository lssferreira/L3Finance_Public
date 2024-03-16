using Shared.DTOs.Requests;
using Shared.DTOs.Response;
using System.Net.Http.Json;

namespace L3.Web.Services;

public class ContasPagarAPI
{
    private readonly HttpClient _httpClient;

    public ContasPagarAPI(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient("API");
    }

    public async Task<ICollection<ContasPagarResponse>?> GetContasPagarAsync()
    {
        return await _httpClient.GetFromJsonAsync<ICollection<ContasPagarResponse>>("ContasPagar");
    }

    public async Task AddContasPagarAsync(ContasPagarRequest cpr)
    {
         await _httpClient.PostAsJsonAsync("ContasPagar", cpr);
    }


}
