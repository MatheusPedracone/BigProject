using System.Threading.Tasks;
using MyApp.Api.Dtos;

namespace MyApp.Api.Contrato
{
    public interface ILoteService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventoId"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<LoteDto[]> SaveLotes(int eventoId, LoteDto[] models);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventoId"></param>
        /// <param name="loteId"></param>
        /// <returns></returns>
        Task<bool> DeleteLote(int eventoId, int loteId);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventoId"></param>
        /// <returns></returns>
        Task<LoteDto[]> GetLotesByEventoIdAsync(int eventoId);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventoId"></param>
        /// <param name="loteId"></param>
        /// <returns></returns>
        Task<LoteDto> GetLoteByIdsAsync(int eventoId, int loteId);
    }
}