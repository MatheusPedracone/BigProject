using System.Threading.Tasks;
using MyApp.Api.Dtos;

namespace MyApp.Api.Contrato
{
    public interface IEventoService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<EventoDto> AddEventos(EventoDto model);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventoId"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<EventoDto> UpdateEvento(int eventoId, EventoDto model);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventoId"></param>
        /// <returns></returns>
        Task<bool> DeleteEvento(int eventoId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tema"></param>
        /// <param name="includePalestrantes"></param>
        /// <returns></returns>
        Task<EventoDto[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="includePalestrantes"></param>
        /// <returns></returns>
        Task<EventoDto[]> GetAllEventosAsync(bool includePalestrantes = false);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventoId"></param>
        /// <param name="includePalestrantes"></param>
        /// <returns></returns>
        Task<EventoDto> GetEventoByIdAsync(int eventoId, bool includePalestrantes = false);
    }
}