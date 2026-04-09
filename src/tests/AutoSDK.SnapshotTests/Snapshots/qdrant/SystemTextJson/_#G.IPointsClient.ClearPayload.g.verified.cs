//HintName: G.IPointsClient.ClearPayload.g.cs
#nullable enable

namespace G
{
    public partial interface IPointsClient
    {
        /// <summary>
        /// Clear payload<br/>
        /// Remove all payload for specified points
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="wait"></param>
        /// <param name="ordering">
        /// Defines write ordering guarantees for collection operations<br/>
        /// * `weak` - write operations may be reordered, works faster, default<br/>
        /// * `medium` - write operations go through dynamically selected leader, may be inconsistent for a short period of time in case of leader change<br/>
        /// * `strong` - Write operations go through the permanent leader, consistent, but may be unavailable if leader is down
        /// </param>
        /// <param name="timeout"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClearPayloadResponse> ClearPayloadAsync(
            string collectionName,

            global::G.PointsSelector request,
            bool? wait = default,
            global::G.WriteOrdering? ordering = default,
            int? timeout = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clear payload<br/>
        /// Remove all payload for specified points
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="wait"></param>
        /// <param name="ordering">
        /// Defines write ordering guarantees for collection operations<br/>
        /// * `weak` - write operations may be reordered, works faster, default<br/>
        /// * `medium` - write operations go through dynamically selected leader, may be inconsistent for a short period of time in case of leader change<br/>
        /// * `strong` - Write operations go through the permanent leader, consistent, but may be unavailable if leader is down
        /// </param>
        /// <param name="timeout"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ClearPayloadResponse> ClearPayloadAsync(
            string collectionName,
            bool? wait = default,
            global::G.WriteOrdering? ordering = default,
            int? timeout = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}