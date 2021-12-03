using System.Collections.Generic;
using System.Threading.Tasks;
using MyApp.Api.Models;

namespace MyApp.Api.Repository
{
    public interface IEventoRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tema"></param>
        /// <param name="includePalestrantes"></param>
        /// <returns></returns>
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="includePalestrantes"></param>
        /// <returns></returns>
        Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventoId"></param>
        /// <param name="includePalestrantes"></param>
        /// <returns></returns>
        Task<Evento> GetEventoByIdAsync(int eventoId, bool includePalestrantes = false);
    }
}