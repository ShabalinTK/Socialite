using SocialNetwork.Domain.Common;

namespace SocialNetwork.Domain.Entities;

public class EventAboutInformation : BaseAuditableEntity
{
    public int EventId { get; set; }
    public string EventAboutText { get; set; }
}