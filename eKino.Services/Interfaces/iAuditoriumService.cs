using eKino.Model;
using eKino.Model.Requests;
using eKino.Model.SearchObjects;

namespace eKino.Services.Interfaces
{
    public interface iAuditoriumService : iCRUDService<Auditorium, AuditoriumSearchObject, AuditoriumUpsertRequest, AuditoriumUpsertRequest>
    {
    }
}
