using SocialNetwork.Domain.Common;

namespace SocialNetwork.Domain.Entities;

public class Event : BaseAuditableEntity
{
    /// <summary>
    /// 
    /// </summary>
    public required string Title { get; set; }

    public int InterestedCount { get; set; }

    public int GoingCount { get; set; }

    public required string Author { get; set; }

    public DateTime EventDate { get; set; }

    public EventAboutInformation EventAboutInformation { get; set; }
}