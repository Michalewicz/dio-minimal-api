using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using minimal_api.Domain.Entities;
using minimal_api.Infrastructure.DB;
using dio_minimal_api.Domain.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Reflection;

namespace Test.Domain.Services
{
    
    public class AdministradorServicoTest
    {
        private DBContexto CriarContextoDeTeste()
        {
            var assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var path = Path.GetFullPath(Path.Combine(assemblyPath ?? "", "..", "..", ".."));
            var builder = new ConfigurationBuilder()
                .SetBasePath(path ?? Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            var configuration = builder.Build();
            
            return new DBContexto(configuration);
        }

        [TestMethod]
        public void TestandoSalvarAdministrador()
        {
            // Arrange
            var context = CriarContextoDeTeste();
            context.Database.ExecuteSqlRaw("TRUNCATE TABLE Administradores;");

            var adm = new Administrador();
            adm.Email = "teste@teste.com";
            adm.Senha = "teste";
            adm.Perfil = "Adm";

            var administradorServico = new AdministradorServico(context);


            // Act
            administradorServico.Incluir(adm);


            // Assert
            Assert.AreEqual(1, administradorServico.Todos(1).Count());
        }
        [TestMethod]
        public void TestandoBuscaPorIdAdministrador()
        {
            // Arrange
            var context = CriarContextoDeTeste();
            context.Database.ExecuteSqlRaw("TRUNCATE TABLE Administradores;");

            var adm = new Administrador();
            adm.Email = "teste@teste.com";
            adm.Senha = "teste";
            adm.Perfil = "Adm";

            var administradorServico = new AdministradorServico(context);


            // Act
            administradorServico.Incluir(adm);
            var admId = administradorServico.BuscaPorId(adm.Id);
            

            // Assert
            Assert.AreEqual(1, admId.Id);  
        }
    }
}