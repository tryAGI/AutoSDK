//HintName: G.IRealtimeClient.ConnectRealtime.g.cs
#nullable enable

namespace G
{
    public partial interface IRealtimeClient
    {
        /// <summary>
        /// Realtime<br/>
        /// Connect to the Realtime API endpoint.
        /// </summary>
        /// <param name="xPortkeyTraceId"></param>
        /// <param name="xPortkeySpanId"></param>
        /// <param name="xPortkeyParentSpanId"></param>
        /// <param name="xPortkeySpanName"></param>
        /// <param name="xPortkeyMetadata"></param>
        /// <param name="xPortkeyCacheNamespace"></param>
        /// <param name="xPortkeyCacheForceRefresh"></param>
        /// <param name="model"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ConnectRealtimeAsync(
            string? xPortkeyTraceId = default,
            string? xPortkeySpanId = default,
            string? xPortkeyParentSpanId = default,
            string? xPortkeySpanName = default,
            object? xPortkeyMetadata = default,
            string? xPortkeyCacheNamespace = default,
            bool? xPortkeyCacheForceRefresh = default,
            string? model = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}