using System.Collections.Generic;
using System.Threading.Tasks;
using MyApp.Api.Models;

namespace MyApp.Api.Repository
{
    public interface IPalestranteRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="includeEventos"></param>
        /// <returns></returns>
        Task<List<Palestrante>> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos = false);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="includeEventos"></param>
        /// <returns></returns>
        Task<List<Palestrante>> GetAllPalestrantesAsync(bool includeEventos = false);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="palestranteId"></param>
        /// <param name="includeEventos"></param>
        /// <returns></returns>
        Task<Palestrante> GetPalestranteByIdAsync(int palestranteId, bool includeEventos = false);
    }
}