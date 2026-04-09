//HintName: G.IOptimizationsClient.DeleteOptimizationsById.g.cs
#nullable enable

namespace G
{
    public partial interface IOptimizationsClient
    {
        /// <summary>
        /// Delete optimizations by id<br/>
        /// Delete optimizations by id
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteOptimizationsByIdAsync(

            global::G.DeleteIdsHolder request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete optimizations by id<br/>
        /// Delete optimizations by id
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteOptimizationsByIdAsync(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}