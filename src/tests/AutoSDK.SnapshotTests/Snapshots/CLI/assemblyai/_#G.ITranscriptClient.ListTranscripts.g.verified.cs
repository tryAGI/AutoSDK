//HintName: G.ITranscriptClient.ListTranscripts.g.cs
#nullable enable

namespace G
{
    public partial interface ITranscriptClient
    {
        /// <summary>
        /// List transcripts<br/>
        /// Retrieve a list of transcripts you created.<br/>
        /// Transcripts are sorted from newest to oldest. The previous URL always points to a page with older transcripts.
        /// </summary>
        /// <param name="limit">
        /// Example: {"after_id":"a7c5cafd-2c2e-4bdd-b0b2-69dade2f7a1b","before_id":"9ea68fd3-f953-42c1-9742-976c447fb463","created_on":"2023-11-03","limit":2,"status":"completed","throttled_only":false}
        /// </param>
        /// <param name="status">
        /// The status of your transcript. Possible values are queued, processing, completed, or error.
        /// </param>
        /// <param name="createdOn">
        /// Example: {"after_id":"a7c5cafd-2c2e-4bdd-b0b2-69dade2f7a1b","before_id":"9ea68fd3-f953-42c1-9742-976c447fb463","created_on":"2023-11-03","limit":2,"status":"completed","throttled_only":false}
        /// </param>
        /// <param name="beforeId">
        /// Example: {"after_id":"a7c5cafd-2c2e-4bdd-b0b2-69dade2f7a1b","before_id":"9ea68fd3-f953-42c1-9742-976c447fb463","created_on":"2023-11-03","limit":2,"status":"completed","throttled_only":false}
        /// </param>
        /// <param name="afterId">
        /// Example: {"after_id":"a7c5cafd-2c2e-4bdd-b0b2-69dade2f7a1b","before_id":"9ea68fd3-f953-42c1-9742-976c447fb463","created_on":"2023-11-03","limit":2,"status":"completed","throttled_only":false}
        /// </param>
        /// <param name="throttledOnly">
        /// Example: {"after_id":"a7c5cafd-2c2e-4bdd-b0b2-69dade2f7a1b","before_id":"9ea68fd3-f953-42c1-9742-976c447fb463","created_on":"2023-11-03","limit":2,"status":"completed","throttled_only":false}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TranscriptList> ListTranscriptsAsync(
            long? limit = default,
            global::G.TranscriptStatus? status = default,
            global::System.DateTime? createdOn = default,
            global::System.Guid? beforeId = default,
            global::System.Guid? afterId = default,
            bool? throttledOnly = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}