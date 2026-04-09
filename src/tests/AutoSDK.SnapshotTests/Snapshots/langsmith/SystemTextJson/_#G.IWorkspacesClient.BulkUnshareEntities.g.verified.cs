//HintName: G.IWorkspacesClient.BulkUnshareEntities.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Bulk Unshare Entities<br/>
        /// Bulk unshare entities by share tokens for the workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> BulkUnshareEntitiesAsync(

            global::G.TenantBulkUnshareRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Unshare Entities<br/>
        /// Bulk unshare entities by share tokens for the workspace.
        /// </summary>
        /// <param name="shareTokens"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> BulkUnshareEntitiesAsync(
            global::System.Collections.Generic.IList<global::System.Guid>? shareTokens = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}