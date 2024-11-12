//HintName: G.ITranscriptClient.GetTranscriptParagraphs.g.cs
#nullable enable

namespace G
{
    public partial interface ITranscriptClient
    {
        /// <summary>
        /// Get paragraphs in transcript<br/>
        /// Get the transcript split by paragraphs. The API will attempt to semantically segment your transcript into paragraphs to create more reader-friendly transcripts.
        /// </summary>
        /// <param name="transcriptId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ParagraphsResponse> GetTranscriptParagraphsAsync(
            string transcriptId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}