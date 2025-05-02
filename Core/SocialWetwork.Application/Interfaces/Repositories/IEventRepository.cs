using SocialNetwork.Domain.Entities;
using SocialNetwork.Domain.Enums;

namespace SocialNetwork.Application.Interfaces.Repositories
{
    public interface IEventRepository
    {
        Task<IEnumerable<Event>> GetAllEventsWithFormatFilter(EventType format);
    }
}
