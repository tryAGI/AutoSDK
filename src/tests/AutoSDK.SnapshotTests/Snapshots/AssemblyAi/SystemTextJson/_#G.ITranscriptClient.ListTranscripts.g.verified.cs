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
        /// <param name="limit"></param>
        /// <param name="status">
        /// The status of your transcript. Possible values are queued, processing, completed, or error.
        /// </param>
        /// <param name="createdOn"></param>
        /// <param name="beforeId"></param>
        /// <param name="afterId"></param>
        /// <param name="throttledOnly"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TranscriptList> ListTranscriptsAsync(
            global::G.ListTranscriptParams? limit = default,
            global::G.TranscriptStatus? status = default,
            global::G.ListTranscriptParams? createdOn = default,
            global::G.ListTranscriptParams? beforeId = default,
            global::G.ListTranscriptParams? afterId = default,
            global::G.ListTranscriptParams? throttledOnly = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}