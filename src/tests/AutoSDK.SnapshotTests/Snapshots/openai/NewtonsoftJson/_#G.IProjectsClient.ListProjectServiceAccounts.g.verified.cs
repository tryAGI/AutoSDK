//HintName: G.IProjectsClient.ListProjectServiceAccounts.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Returns a list of service accounts in the project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectServiceAccountListResponse> ListProjectServiceAccountsAsync(
            string projectId,
            int? limit = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}