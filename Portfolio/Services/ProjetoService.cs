using Portfolio.Models;
using System.Net.Http.Json;

namespace Portfolio.Services
{
    public class ProjetoService
    {
        private readonly HttpClient _http;

        private const string _url = "https://raw.githubusercontent.com/fernandonline/portfolio-data/main/projects.json";

        public ProjetoService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Projeto>> GetProjetosAsync()
        {
            var data = await _http.GetFromJsonAsync<List<Projeto>>(_url);
            return data ?? [];
        }
    }
}