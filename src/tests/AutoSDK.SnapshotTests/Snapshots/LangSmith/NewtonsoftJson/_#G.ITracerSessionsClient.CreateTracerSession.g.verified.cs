//HintName: G.ITracerSessionsClient.CreateTracerSession.g.cs
#nullable enable

namespace G
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// Create Tracer Session<br/>
        /// Create a new session.
        /// </summary>
        /// <param name="upsert">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TracerSessionWithoutVirtualFields> CreateTracerSessionAsync(
            global::G.TracerSessionCreate request,
            bool upsert = false,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Tracer Session<br/>
        /// Create a new session.
        /// </summary>
        /// <param name="upsert">
        /// Default Value: false
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="extra"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="defaultDatasetId"></param>
        /// <param name="referenceDatasetId"></param>
        /// <param name="traceTier"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TracerSessionWithoutVirtualFields> CreateTracerSessionAsync(
            bool upsert = false,
            global::System.DateTime startTime = default,
            global::G.AnyOf<global::System.DateTime?, object>? endTime = default,
            global::G.AnyOf<global::G.TracerSessionCreateExtra, object>? extra = default,
            string? name = default,
            global::G.AnyOf<string, object>? description = default,
            global::G.AnyOf<global::System.Guid?, object>? defaultDatasetId = default,
            global::G.AnyOf<global::System.Guid?, object>? referenceDatasetId = default,
            global::G.AnyOf<global::G.TraceTier3?, object>? traceTier = default,
            global::G.AnyOf<global::System.Guid?, object>? id = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}