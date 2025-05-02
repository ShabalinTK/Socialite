using SocialNetwork.Domain.Common;

namespace SocialNetwork.Domain.Entities;

public class NotificationPreferences : BaseAuditableEntity
{
    public int UserProfileId { get; set; }
    public bool NotifyOnNewMessage { get; set; } = true;
    public bool NotifyOnPhotoLike { get; set; } = true;
    public bool NotifyOnPhotoShare { get; set; } = true;
    public bool NotifyOnNewFollower { get; set; } = true;
    public bool NotifyOnPostLike { get; set; } = true;
    public bool NotifyOnMention { get; set; } = true;
    public bool NotifyOnFollowRequest { get; set; } = true;
}