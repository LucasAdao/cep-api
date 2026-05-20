using CepApi.Dtos;
using CepApi.Interfaces;
using CepApi.Models;
using System.Dynamic;
using System.Text.Json;

namespace CepApi.Call
{
    public class BrasilApiCall : IBrasilApi
    {
        public async Task<ResponseGenerico<Endereco>> BuscarEnderecoPorCep(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");
            var response = new ResponseGenerico<Endereco>();

            using (var client = new HttpClient()) { 
                var responseBrasilApi = await client.SendAsync(request);
                var content = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<Endereco>(content);
                response.CodigoHttp = responseBrasilApi.StatusCode;
                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.DadosRetorno = objResponse;
                }
                else {
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(content);
                }
            }
            return response;
        }
    }
}
