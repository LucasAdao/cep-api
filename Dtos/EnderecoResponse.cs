using System.Text.Json.Serialization;

namespace CepApi.Dtos
{
    public record EnderecoResponse(
        string Cep,
        string Estado,
        string Cidade,
        string Bairro,
        string Rua,
        [property: JsonIgnore]
        string Servico
        )
    {
    }
}
