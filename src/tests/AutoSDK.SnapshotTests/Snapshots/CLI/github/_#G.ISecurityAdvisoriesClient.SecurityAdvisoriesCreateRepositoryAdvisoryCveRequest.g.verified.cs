//HintName: G.ISecurityAdvisoriesClient.SecurityAdvisoriesCreateRepositoryAdvisoryCveRequest.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityAdvisoriesClient
    {
        /// <summary>
        /// Request a CVE for a repository security advisory<br/>
        /// If you want a CVE identification number for the security vulnerability in your project, and don't already have one, you can request a CVE identification number from GitHub. For more information see "[Requesting a CVE identification number](https://docs.github.com/code-security/security-advisories/repository-security-advisories/publishing-a-repository-security-advisory#requesting-a-cve-identification-number-optional)."<br/>
        /// You may request a CVE for public repositories, but cannot do so for private repositories.<br/>
        /// In order to request a CVE for a repository security advisory, the authenticated user must be a security manager or administrator of that repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `repository_advisories:write` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ghsaId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SecurityAdvisoriesCreateRepositoryAdvisoryCveRequestAsync(
            string owner,
            string repo,
            string ghsaId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}