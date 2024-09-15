//HintName: G.IUserClient.UserGetFilteredUsers.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// GetFilteredUsers.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="filter"></param>
        /// <param name="maxResults"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UserGetFilteredUsersResponse> UserGetFilteredUsersAsync(
            string? token = default,
            global::System.Guid projectId = default,
            string? filter = default,
            int maxResults = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}