using SocialNetwork.Domain.Common.Interfaces;

namespace SocialNetwork.Domain.Common;

public abstract class BaseEntity : IEntity
{
    public int Id { get; set; }
}