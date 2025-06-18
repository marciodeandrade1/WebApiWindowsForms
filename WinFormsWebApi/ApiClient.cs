using System.Net.Http.Headers;
using System.Net.Http.Json;
using WinFormsWebApi.Models;

namespace WinFormsWebApi
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;
        public ApiClient(string baseUrl)
        {
            _baseUrl = baseUrl;
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<List<Produto>> GetProdutosAsync()
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/api/produtos");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<Produto>>();
        }
        public async Task<Produto> GetProdutoAsync(int id)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/api/produtos/{id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Produto>();
        }
        public async Task<Produto> AddProdutoAsync(Produto produto)
        {
            var response = await _httpClient.PostAsJsonAsync($"{_baseUrl}/api/produtos", produto);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Produto>();
        }
        public async Task UpdateProdutoAsync(int id, Produto produto)
        {
            var response = await _httpClient.PutAsJsonAsync($"{_baseUrl}/api/produtos/{id}", produto);
            response.EnsureSuccessStatusCode();
        }
        public async Task DeleteProdutoAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{_baseUrl}/api/produtos/{id}");
            response.EnsureSuccessStatusCode();
        }



    }
}
