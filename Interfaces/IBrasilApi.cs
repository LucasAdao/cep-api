using CepApi.Dtos;
using CepApi.Models;

namespace CepApi.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<Endereco>> BuscarEnderecoPorCep(string cep);
    }
}
