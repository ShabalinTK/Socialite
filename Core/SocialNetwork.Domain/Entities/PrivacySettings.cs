using SocialNetwork.Domain.Common;
using SocialNetwork.Domain.Enums;

namespace SocialNetwork.Domain.Entities;

public class PrivacySettings : BaseAuditableEntity
{
    public int UserProfileId { get; set; }
    public FollowerPolicy FollowerPolicy { get; set; } = FollowerPolicy.EVERYONE;
    public MessagePolicy MessagePolicy { get; set; } = MessagePolicy.EVERYONE;
    public StatusPolicy StatusPolicy { get; set; } = StatusPolicy.YES;
    public ActivityVisibility ActivityVisibility { get; set; } = ActivityVisibility.PUBLIC;
}