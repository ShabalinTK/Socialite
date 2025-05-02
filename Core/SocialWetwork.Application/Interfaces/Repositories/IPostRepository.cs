using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Application.Interfaces.Repositories
{
    public interface IPostRepository
    {
        Task<List<Post>> GetGetByUserPageIdAll(int userPageId);
    }
}