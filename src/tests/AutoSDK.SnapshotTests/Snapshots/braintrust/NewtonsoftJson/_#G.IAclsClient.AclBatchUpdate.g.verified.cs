//HintName: G.IAclsClient.AclBatchUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IAclsClient
    {
        /// <summary>
        /// Batch update acls<br/>
        /// Batch update acls. This operation is idempotent, so adding acls which already exist will have no effect, and removing acls which do not exist will have no effect.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AclBatchUpdateResponse> AclBatchUpdateAsync(

            global::G.AclBatchUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch update acls<br/>
        /// Batch update acls. This operation is idempotent, so adding acls which already exist will have no effect, and removing acls which do not exist will have no effect.
        /// </summary>
        /// <param name="addAcls"></param>
        /// <param name="removeAcls"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AclBatchUpdateResponse> AclBatchUpdateAsync(
            global::System.Collections.Generic.IList<global::G.AclItem>? addAcls = default,
            global::System.Collections.Generic.IList<global::G.AclItem>? removeAcls = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}