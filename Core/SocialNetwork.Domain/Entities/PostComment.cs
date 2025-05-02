using SocialNetwork.Domain.Common;

namespace SocialNetwork.Domain.Entities;

public class PostComment : BaseAuditableEntity
{
    public required string Text { get; set; }
    public int PostId { get; set; }
    public UserProfile UserProfile { get; set; }
}