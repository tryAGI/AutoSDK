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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetFilteredProjectsAndUsersAsAdminAsync(

            global::G.GetFilteredProjectsAndUsersRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// GetFilteredProjectsAndUsers<br/>
        /// GetFilteredProjectsAndUsers
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="maxResults"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetFilteredProjectsAndUsersAsAdminAsync(
            string filter,
            int maxResults,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}