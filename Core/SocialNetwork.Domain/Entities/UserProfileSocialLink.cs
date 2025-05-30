using SocialNetwork.Domain.Common;
using SocialNetwork.Domain.Enums;

namespace SocialNetwork.Domain.Entities;

public class UserProfileSocialLink : BaseAuditableEntity
{
    public int UserProfileId { get; set; }
    public required string SocialLinkUrl { get; set; }
    public SocialNetworkType SocialNetworkType { get; set; }
}