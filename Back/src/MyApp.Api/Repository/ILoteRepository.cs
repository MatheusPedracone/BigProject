using System.Collections.Generic;
using System.Threading.Tasks;
using MyApp.Api.Models;

namespace MyApp.Api.Repository
{
    public interface ILoteRepository
    {

        /// <summary>
        /// Método get que ira retornar uma lista de lotes de um evento
        /// </summary>
        /// <param name="eventoId"></param>
        /// <returns>uma array de lotes</returns>
        Task<Lote[]> GetLotesByEventoIdAsync(int eventoId);

        /// <summary>
        /// Método get que retornará 1 lote 
        /// </summary>
        /// <param name="eventoId"></param>
        /// <param name="id"></param>
        /// <returns>1 lote</returns>
        Task<Lote> GetLoteByIdAsync(int eventoId, int loteId);
    }
}