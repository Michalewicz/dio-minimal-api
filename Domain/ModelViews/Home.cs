using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_minimal_api.Domain.ModelViews
{
    public struct Home
    {
        public string Mensagem { get => "API de Veículos - DIO BootCamp C# Minimal API"; }
        public string Doc { get => "/swagger"; }
    }
}