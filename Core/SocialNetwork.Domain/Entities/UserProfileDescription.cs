using System.Security.AccessControl;
using SocialNetwork.Domain.Common;
using SocialNetwork.Domain.Enums;

namespace SocialNetwork.Domain.Entities;

public class UserProfileDescription : BaseAuditableEntity
{
    public int UserProfileId { get; set; }
    public required string UserName { get; set; }
    public required string Email { get; set; }
    public required string Bio { get; set; }
    public GenderType Gender { get; set; }
    public RelationshipType Relationship { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
}