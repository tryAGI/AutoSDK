//HintName: G.IAdminClient.GetFilteredProjectsAndUsersAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// GetFilteredProjectsAndUsers<br/>
        /// GetFilteredProjectsAndUsers
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetFilteredProjectsAndUsersAsAdminAsync(
            global::G.GetFilteredProjectsAndUsersRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetFilteredProjectsAndUsers<br/>
        /// GetFilteredProjectsAndUsers
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="maxResults"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetFilteredProjectsAndUsersAsAdminAsync(
            string filter,
            int maxResults,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}