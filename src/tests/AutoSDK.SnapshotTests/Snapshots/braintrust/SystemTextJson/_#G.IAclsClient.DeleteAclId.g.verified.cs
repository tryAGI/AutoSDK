//HintName: G.IAclsClient.DeleteAclId.g.cs
#nullable enable

namespace G
{
    public partial interface IAclsClient
    {
        /// <summary>
        /// Delete acl<br/>
        /// Delete an acl object by its id
        /// </summary>
        /// <param name="aclId">
        /// Acl id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Acl> DeleteAclIdAsync(
            global::System.Guid aclId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}