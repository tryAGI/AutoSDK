//HintName: G.ISecurityAdvisoriesClient.SecurityAdvisoriesGetRepositoryAdvisory.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityAdvisoriesClient
    {
        /// <summary>
        /// Get a repository security advisory<br/>
        /// Get a repository security advisory using its GitHub Security Advisory (GHSA) identifier.<br/>
        /// Anyone can access any published security advisory on a public repository.<br/>
        /// The authenticated user can access an unpublished security advisory from a repository if they are a security manager or administrator of that repository, or if they are a<br/>
        /// collaborator on the security advisory.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `repository_advisories:read` scope to to get a published security advisory in a private repository, or any unpublished security advisory that the authenticated user has access to.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ghsaId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RepositoryAdvisory> SecurityAdvisoriesGetRepositoryAdvisoryAsync(
            string owner,
            string repo,
            string ghsaId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}