//HintName: G.IPointsClient.DeletePayload.g.cs
#nullable enable

namespace G
{
    public partial interface IPointsClient
    {
        /// <summary>
        /// Delete payload<br/>
        /// Delete specified key payload for points
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeletePayloadResponse> DeletePayloadAsync(
            string collectionName,

            global::G.DeletePayload request,
            bool? wait = default,
            global::G.WriteOrdering? ordering = default,
            int? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete payload<br/>
        /// Delete specified key payload for points
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
        /// <param name="keys">
        /// List of payload keys to remove from payload
        /// </param>
        /// <param name="points">
        /// Deletes values from each point in this list
        /// </param>
        /// <param name="filter">
        /// Deletes values from points that satisfy this filter condition
        /// </param>
        /// <param name="shardKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeletePayloadResponse> DeletePayloadAsync(
            string collectionName,
            global::System.Collections.Generic.IList<string> keys,
            bool? wait = default,
            global::G.WriteOrdering? ordering = default,
            int? timeout = default,
            global::System.Collections.Generic.IList<global::G.ExtendedPointId>? points = default,
            global::G.Filter? filter = default,
            global::G.ShardKeySelector? shardKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}