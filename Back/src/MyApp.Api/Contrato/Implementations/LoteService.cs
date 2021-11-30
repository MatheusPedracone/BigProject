using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MyApp.Api.Dtos;
using MyApp.Api.Models;
using MyApp.Api.Repository;

namespace MyApp.Api.Contrato.Implementations
{
    public class LoteService : ILoteService
    {
        private readonly IGeralRepository _geralRepository;
        private readonly ILoteRepository _loteRepository;
        private readonly IMapper _mapper;

        public LoteService(IGeralRepository geralRepository, ILoteRepository loteRepository, IMapper mapper)
        {
            _geralRepository = geralRepository;
            _loteRepository = loteRepository;
            _mapper = mapper;
        }
        public async Task<LoteDto> GetLoteByIdsAsync(int eventoId, int loteId)
        {
            try
            {
                var lote = await _loteRepository.GetLoteByIdAsync(eventoId, loteId);
                if (lote == null) return null;

                var resultado = _mapper.Map<LoteDto>(lote);

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<LoteDto[]> GetLotesByEventoIdAsync(int eventoId)
        {
            try
            {
                var lotes = await _loteRepository.GetLotesByEventoIdAsync(eventoId);
                if (lotes == null) return null;

                var resultado = _mapper.Map<LoteDto[]>(lotes);

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task AddLote(int eventoId, LoteDto model)
        {
            try
            {
                var lote = _mapper.Map<Lote>(model);
                //
                lote.EventoId = eventoId;

                _geralRepository.Add<Lote>(lote);

                await _geralRepository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<LoteDto[]> SaveLotes(int eventoId, LoteDto[] models)
        {
            try
            {
                //busco todos os lotes pelo eventoId
                var lotes = await _loteRepository.GetLotesByEventoIdAsync(eventoId);
                if (lotes == null) return null;

                //valido se lote vai ser adicionado ou atualizado
                foreach (var model in models)
                { //se Id de Lote for igual a 0 é por que ele não existe, e deve ser adicionado 
                    if (model.Id == 0)
                    {
                        //metodo de adicionar lote 
                        await AddLote(eventoId, model);
                    }
                    //se model tiver EventoId ele vai ser atualizado
                    else
                    {   //mapeio o model que eu recebo com o lote
                        var lote = lotes.FirstOrDefault(lote => lote.Id == model.Id);

                        model.EventoId = eventoId;
                        _mapper.Map(model, lote);
                        //metodo que vai atualizar o lote
                        _geralRepository.Update<Lote>(lote);

                        await _geralRepository.SaveChangesAsync();
                    }
                }
                var loteRetorno = await _loteRepository.GetLotesByEventoIdAsync(eventoId);
                return _mapper.Map<LoteDto[]>(loteRetorno);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<bool> DeleteLote(int eventoId, int loteId)
        {
            try
            {
                var lote = await _loteRepository.GetLoteByIdAsync(eventoId, loteId);
                if (lote == null) throw new Exception("Lote para Delete não encontrado");

                _geralRepository.Delete<Lote>(lote);
                return await _geralRepository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
