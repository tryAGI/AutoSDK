//HintName: G.ISecurityAdvisoriesClient.SecurityAdvisoriesListRepositoryAdvisories.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityAdvisoriesClient
    {
        /// <summary>
        /// List repository security advisories<br/>
        /// Lists security advisories in a repository.<br/>
        /// The authenticated user can access unpublished security advisories from a repository if they are a security manager or administrator of that repository, or if they are a collaborator on any security advisory.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `repository_advisories:read` scope to to get a published security advisory in a private repository, or any unpublished security advisory that the authenticated user has access to.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="state"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.RepositoryAdvisory>> SecurityAdvisoriesListRepositoryAdvisoriesAsync(
            string owner,
            string repo,
            global::G.SecurityAdvisoriesListRepositoryAdvisoriesDirection? direction = default,
            global::G.SecurityAdvisoriesListRepositoryAdvisoriesSort? sort = default,
            string? before = default,
            string? after = default,
            int? perPage = default,
            global::G.SecurityAdvisoriesListRepositoryAdvisoriesState? state = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}