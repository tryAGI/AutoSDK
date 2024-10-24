//HintName: G.ITracerSessionsClient.ReadTracerSessionsRunsMetadata.g.cs
#nullable enable

namespace G
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// Read Tracer Sessions Runs Metadata<br/>
        /// Given a session, a number K, and (optionally) a list of metadata keys, return the top K values for each key.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="metadataKeys"></param>
        /// <param name="startTime"></param>
        /// <param name="k">
        /// Default Value: 10
        /// </param>
        /// <param name="rootRunsOnly">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>> ReadTracerSessionsRunsMetadataAsync(
            global::System.Guid sessionId,
            global::System.Collections.Generic.IList<string>? metadataKeys = default,
            global::System.DateTime? startTime = default,
            int? k = default,
            bool? rootRunsOnly = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}