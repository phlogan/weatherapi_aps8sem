using Data.Entity;

namespace Data.Interface
{
    public interface IApiAccessRepository
    {
        ApiAccess GetByApiSlug(string apiHost);
    }
}
