using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using minimal_api.Domain.Entities;
using minimal_api.DTOs;

namespace dio_minimal_api.Domain.Interfaces
{
    public interface iVeiculoServico
    {
        List<Veiculo> Todos(int? pagina, string? nome = null, string? marca = null);
        Veiculo? BuscaPorId(int id);
        void Incluir(Veiculo veiculo);
        void Atualizar(Veiculo veiculo);
        void Apagar(Veiculo veiculo);
    }
}