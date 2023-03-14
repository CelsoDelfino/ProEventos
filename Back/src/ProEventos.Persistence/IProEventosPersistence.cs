using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain.Model;

namespace ProEventos.Persistence
{
    public interface IProEventosPersistence
    {
        //GERAL
        void Add<T>(T entity) where T: class;
        void Update<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        void DeleteRange<T>(T entity) where T: class;
        Task<bool> SaveChangesAsync();

        //EVENTOS   
        Task<Evento[]> GetAllEventosByTemaAsync(string tema,bool includePalestrantes);
        Task<Evento[]> GetAllEventosAsync(bool includePalestrantes);
        Task<Evento[]> GetEventosByIdTemaAsync(int eventoId,bool includePalestrantes);

        //PALESTRANTES
        Task<Palestrante[]> GetAllPalestranteByNomeAsync(string nome,bool includeEventos);
        Task<Palestrante[]> GetAllPalestranteAsync(bool includeEventos);
        Task<Palestrante[]> GetPalestranteByIdAsync(int palestranteId,bool includeEventos);

    }
}