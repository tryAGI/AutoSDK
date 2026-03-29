//HintName: G.IPointsClient.OverwritePayload.g.cs
#nullable enable

namespace G
{
    public partial interface IPointsClient
    {
        /// <summary>
        /// Overwrite payload<br/>
        /// Replace full payload of points with new one
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
        global::System.Threading.Tasks.Task<global::G.OverwritePayloadResponse> OverwritePayloadAsync(
            string collectionName,

            global::G.SetPayload request,
            bool? wait = default,
            global::G.WriteOrdering? ordering = default,
            int? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Overwrite payload<br/>
        /// Replace full payload of points with new one
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
        /// <param name="payload">
        /// Example: {"city":"London","color":"green"}
        /// </param>
        /// <param name="points">
        /// Assigns payload to each point in this list
        /// </param>
        /// <param name="filter">
        /// Assigns payload to each point that satisfy this filter condition
        /// </param>
        /// <param name="shardKey"></param>
        /// <param name="key">
        /// Assigns payload to each point that satisfy this path of property
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OverwritePayloadResponse> OverwritePayloadAsync(
            string collectionName,
            global::G.Payload payload,
            bool? wait = default,
            global::G.WriteOrdering? ordering = default,
            int? timeout = default,
            global::System.Collections.Generic.IList<global::G.ExtendedPointId>? points = default,
            global::G.Filter? filter = default,
            global::G.ShardKeySelector? shardKey = default,
            string? key = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}