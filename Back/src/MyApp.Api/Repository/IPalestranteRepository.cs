using System.Collections.Generic;
using System.Threading.Tasks;
using MyApp.Api.Models;

namespace MyApp.Api.Repository
{
    public interface IPalestranteRepository
    {
        Task<List<Palestrante>> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos = false);
        Task<List<Palestrante>> GetAllPalestrantesAsync(bool includeEventos = false);
        Task<Palestrante> GetPalestranteByIdAsync(int palestranteId, bool includeEventos = false);
    }
}