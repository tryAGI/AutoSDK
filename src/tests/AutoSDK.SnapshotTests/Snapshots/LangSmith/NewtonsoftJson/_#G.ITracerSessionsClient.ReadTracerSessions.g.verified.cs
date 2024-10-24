//HintName: G.ITracerSessionsClient.ReadTracerSessions.g.cs
#nullable enable

namespace G
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// Read Tracer Sessions<br/>
        /// Get all sessions.
        /// </summary>
        /// <param name="referenceFree"></param>
        /// <param name="referenceDataset"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="datasetVersion"></param>
        /// <param name="sortBy"></param>
        /// <param name="sortByDesc">
        /// Default Value: true
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="sortByFeedbackKey"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="tagValueId"></param>
        /// <param name="facets">
        /// Default Value: false
        /// </param>
        /// <param name="accept"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TracerSession>> ReadTracerSessionsAsync(
            bool? referenceFree = default,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceDataset = default,
            global::System.Collections.Generic.IList<global::System.Guid>? id = default,
            string? name = default,
            string? nameContains = default,
            string? datasetVersion = default,
            global::G.SessionSortableColumns? sortBy = default,
            bool? sortByDesc = default,
            string? metadata = default,
            string? sortByFeedbackKey = default,
            int? offset = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            bool? facets = default,
            string? accept = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}