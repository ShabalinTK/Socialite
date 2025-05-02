using MediatR;
using SocialNetwork.Application.Interfaces.Repositories;
using SocialNetwork.Domain.Enums;

namespace SocialNetwork.Application.Features.Event.Queries.GetAllEvents
{
    public class GetAllEventsQueryHandler : IRequestHandler<GetAllEventsQuery, IEnumerable<GetAllEventsDto>>
    {
        private readonly IEventRepository _eventRepository;

        public GetAllEventsQueryHandler(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public async Task<IEnumerable<GetAllEventsDto>> Handle(GetAllEventsQuery query, CancellationToken cancellationToken)
        {
            var format = (EventType)Enum.Parse(typeof(EventType), query.formatType.ToUpper(), ignoreCase: true);
            var data = await _eventRepository.GetAllEventsWithFormatFilter(format);

            var result = data.Select(p => new GetAllEventsDto
            {
                Id = p.Id,
                Title = p.Title,
                InterestedCount = p.InterestedCount,
                GoingCount = p.GoingCount,
                Author = p.Author,
                EventDate = p.EventDate,
            });

            return result ?? new List<GetAllEventsDto>(){ };
        }
    }
}
