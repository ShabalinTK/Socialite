using System.Security.Principal;
using SocialNetwork.Domain.Common;
using SocialNetwork.Domain.Enums;

namespace SocialNetwork.Domain.Entities;

public class User : BaseAuditableEntity
{
    public string CurrentPassword { get; set; } = null!;
    public TwoFactorAuthenticationType TwoFactorAuthenticationType { get; set; } = TwoFactorAuthenticationType.DISABLE;
    public UserProfileDescription Description { get; set; }
    public ICollection<UserProfileSocialLink> SocialNetworkLinks { get; set; }
    public PrivacySettings PrivacySettings { get; set; }
    public NotificationSettings NotificationSettings { get; set; }
    public NotificationPreferences NotificationPreferences { get; set; }
}