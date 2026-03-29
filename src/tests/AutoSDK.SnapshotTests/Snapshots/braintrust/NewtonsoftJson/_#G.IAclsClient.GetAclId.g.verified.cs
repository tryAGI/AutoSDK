//HintName: G.IAclsClient.GetAclId.g.cs
#nullable enable

namespace G
{
    public partial interface IAclsClient
    {
        /// <summary>
        /// Get acl<br/>
        /// Get an acl object by its id
        /// </summary>
        /// <param name="aclId">
        /// Acl id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Acl> GetAclIdAsync(
            global::System.Guid aclId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}