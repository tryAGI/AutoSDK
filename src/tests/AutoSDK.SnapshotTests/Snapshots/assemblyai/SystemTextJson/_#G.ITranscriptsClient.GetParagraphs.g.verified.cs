//HintName: G.ITranscriptsClient.GetParagraphs.g.cs
#nullable enable

namespace G
{
    public partial interface ITranscriptsClient
    {
        /// <summary>
        /// Get paragraphs in transcript<br/>
        /// Get the transcript split by paragraphs. The API will attempt to semantically segment your transcript into paragraphs to create more reader-friendly transcripts.
        /// </summary>
        /// <param name="transcriptId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ParagraphsResponse> GetParagraphsAsync(
            string transcriptId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}