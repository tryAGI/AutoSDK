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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AclBatchUpdateResponse> AclBatchUpdateAsync(

            global::G.AclBatchUpdateRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch update acls<br/>
        /// Batch update acls. This operation is idempotent, so adding acls which already exist will have no effect, and removing acls which do not exist will have no effect.
        /// </summary>
        /// <param name="addAcls"></param>
        /// <param name="removeAcls"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AclBatchUpdateResponse> AclBatchUpdateAsync(
            global::System.Collections.Generic.IList<global::G.AclItem>? addAcls = default,
            global::System.Collections.Generic.IList<global::G.AclItem>? removeAcls = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}