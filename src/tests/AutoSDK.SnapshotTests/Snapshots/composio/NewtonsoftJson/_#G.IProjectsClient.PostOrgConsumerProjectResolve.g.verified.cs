//HintName: G.IProjectsClient.PostOrgConsumerProjectResolve.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Resolve the organization consumer project<br/>
        /// Finds the authenticated organization's single CONSUMER project and provisions it if absent. This endpoint is idempotent and never returns consumer API keys.
        /// </summary>
        /// <param name="xUserApiKey">
        /// User API key used to authenticate the request.<br/>
        /// Example: uak_abc123xyz456...
        /// </param>
        /// <param name="xOrgId">
        /// Organization nano ID that scopes the user API key resolution.<br/>
        /// Example: org_abc123xyz456
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostOrgConsumerProjectResolveResponse> PostOrgConsumerProjectResolveAsync(
            string xUserApiKey,
            string xOrgId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}