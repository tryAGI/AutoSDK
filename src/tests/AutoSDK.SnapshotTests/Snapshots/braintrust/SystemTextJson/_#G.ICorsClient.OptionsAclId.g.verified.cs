//HintName: G.ICorsClient.OptionsAclId.g.cs
#nullable enable

namespace G
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/acl/{acl_id}`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="aclId">
        /// Acl id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsAclIdAsync(
            global::System.Guid aclId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}