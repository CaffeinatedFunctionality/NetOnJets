using System.Collections.Generic;
using GeekedOutReviews.Core.Objects;

namespace GeekedOutReviews.Core
{
    public interface IBlogRepository
    {
        IList<Post> Posts(int pageNo, int pageSize);
        int TotalPosts();
    }
}
