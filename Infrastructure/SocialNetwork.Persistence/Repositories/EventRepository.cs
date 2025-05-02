using SocialNetwork.Application.Interfaces.Repositories;
using SocialNetwork.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Domain.Enums;

namespace SocialNetwork.Persistence.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly IGenericRepository<Event> _repository;

        public EventRepository(IGenericRepository<Event> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Event>> GetAllEventsWithFormatFilter(EventType format)
        {
            return await _repository.Entities.Where(e => e.EventType == format).ToListAsync();
        }
    }
}
