using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dio_minimal_api.Domain.Enuns;

namespace dio_minimal_api.Domain.ModelViews
{
    public record AdministradorLogado
    {
        public string Email { get; set; } = default!;
        public string Perfil { get; set; } = default!;
        public string Token { get; set; } = default!;
    }
}