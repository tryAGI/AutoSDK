//HintName: G.ITranscriptClient.GetTranscriptSentences.g.cs
#nullable enable

namespace G
{
    public partial interface ITranscriptClient
    {
        /// <summary>
        /// Get sentences in transcript<br/>
        /// Get the transcript split by sentences. The API will attempt to semantically segment the transcript into sentences to create more reader-friendly transcripts.
        /// </summary>
        /// <param name="transcriptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SentencesResponse> GetTranscriptSentencesAsync(
            string transcriptId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}