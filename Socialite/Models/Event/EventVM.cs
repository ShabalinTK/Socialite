using SocialNetwork.Application.Features.Event.Queries.GetAllEvents;

namespace SocialNetwork.MVC.Models.Event
{
    public class EventVM
    {
        public IEnumerable<GetAllEventsDto> Events { get; set; }
        public string CurrentFormatType { get; set; }
    }
}
