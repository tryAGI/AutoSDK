//HintName: G.ITracerSessionsClient.ReadTracerSession.g.cs
#nullable enable

namespace G
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// Read Tracer Session<br/>
        /// Get a specific session.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="accept"></param>
        /// <param name="includeStats">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TracerSession> ReadTracerSessionAsync(
            global::System.Guid sessionId,
            global::G.AnyOf<string, object>? accept = default,
            bool? includeStats = false,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}