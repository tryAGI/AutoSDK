//HintName: G.IAdminClient.GetFilteredProjectsAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// GetFilteredProjects<br/>
        /// GetFilteredProjects
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetFilteredProjectsAsAdminAsync(
            global::G.GetFilteredProjectsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetFilteredProjects<br/>
        /// GetFilteredProjects
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="maxResults"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetFilteredProjectsAsAdminAsync(
            string filter,
            int maxResults,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}