using CepApi.Dtos;
using CepApi.Models;

namespace CepApi.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);
        
    }
}
