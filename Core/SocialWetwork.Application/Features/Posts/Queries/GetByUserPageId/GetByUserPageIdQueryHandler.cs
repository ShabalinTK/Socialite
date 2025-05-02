using MediatR;
using SocialNetwork.Application.Interfaces.Repositories;

namespace SocialNetwork.Application.Features.Posts.Queries.GetByUserPageId
{
    internal class GetByUserPageIdQueryHandler : IRequestHandler<GetByUserPageIdQuery, IEnumerable<GetByUserPageIdDto>>
    {
        private readonly IPostRepository _postRepository;

        public GetByUserPageIdQueryHandler(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<IEnumerable<GetByUserPageIdDto>> Handle(GetByUserPageIdQuery request, CancellationToken cancellationToken)
        {
            var data = await _postRepository.GetGetByUserPageIdAll(request.UserPageId);

            var result = data.Select(p => new GetByUserPageIdDto
            {
                Id = p.Id,
                UserPageId = p.UserPageId,
                Content = p.Content,
                LikeCount = p.LikeCount,
                DisLikeCount = p.DisLikeCount,
                Comments = p.Comments.Select(c => new PostCommentDto
                {
                    Id = c.Id,
                    Text = c.Text,
                    UserName = c.UserProfile.Description.UserName
                }).ToList()
            });

            return result ?? new List<GetByUserPageIdDto>();
        }
    }
}
