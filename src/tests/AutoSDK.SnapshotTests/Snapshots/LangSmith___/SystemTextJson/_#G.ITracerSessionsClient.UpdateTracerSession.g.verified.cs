//HintName: G.ITracerSessionsClient.UpdateTracerSession.g.cs
#nullable enable

namespace G
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// Update Tracer Session<br/>
        /// Create a new session.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TracerSessionWithoutVirtualFields> UpdateTracerSessionAsync(
            global::System.Guid sessionId,
            global::G.TracerSessionUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Tracer Session<br/>
        /// Create a new session.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="defaultDatasetId"></param>
        /// <param name="endTime"></param>
        /// <param name="extra"></param>
        /// <param name="traceTier"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TracerSessionWithoutVirtualFields> UpdateTracerSessionAsync(
            global::System.Guid sessionId,
            string? name = default,
            string? description = default,
            global::System.Guid? defaultDatasetId = default,
            global::System.DateTime? endTime = default,
            object? extra = default,
            global::G.TraceTier? traceTier = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}