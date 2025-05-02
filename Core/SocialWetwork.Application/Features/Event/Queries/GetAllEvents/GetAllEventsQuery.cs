using MediatR;

namespace SocialNetwork.Application.Features.Event.Queries.GetAllEvents
{
    public record GetAllEventsQuery(string formatType) : IRequest<IEnumerable<GetAllEventsDto>>;
}
