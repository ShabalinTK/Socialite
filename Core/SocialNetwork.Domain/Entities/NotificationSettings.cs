using SocialNetwork.Domain.Common;

namespace SocialNetwork.Domain.Entities;

public class NotificationSettings : BaseAuditableEntity
{
    public int UserProfileId { get; set; }
    public bool EnableEmailNotifications { get; set; } = true;
    public bool EnableWebNotifications { get; set; } = true;
    public bool EnablePhoneNotifications { get; set; } = true;
}