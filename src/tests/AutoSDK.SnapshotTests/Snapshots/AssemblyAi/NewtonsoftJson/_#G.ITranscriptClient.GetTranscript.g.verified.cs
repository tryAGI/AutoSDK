//HintName: G.ITranscriptClient.GetTranscript.g.cs
#nullable enable

namespace G
{
    public partial interface ITranscriptClient
    {
        /// <summary>
        /// Get transcript<br/>
        /// Get the transcript resource. The transcript is ready when the "status" is "completed".
        /// </summary>
        /// <param name="transcriptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Transcript> GetTranscriptAsync(
            string transcriptId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}