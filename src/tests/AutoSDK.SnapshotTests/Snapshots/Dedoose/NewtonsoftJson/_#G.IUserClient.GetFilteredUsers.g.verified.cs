//HintName: G.IUserClient.GetFilteredUsers.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// GetFilteredUsers<br/>
        /// GetFilteredUsers
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetFilteredUsersAsync(
            global::G.GetFilteredUsersRequest2 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetFilteredUsers<br/>
        /// GetFilteredUsers
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="filter"></param>
        /// <param name="maxResults"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetFilteredUsersAsync(
            global::System.Guid projectId,
            string filter,
            int maxResults,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}