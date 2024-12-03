//HintName: G.ITranscriptClient.WordSearch.g.cs
#nullable enable

namespace G
{
    public partial interface ITranscriptClient
    {
        /// <summary>
        /// Search words in transcript<br/>
        /// Search through the transcript for keywords. You can search for individual words, numbers, or phrases containing up to five words or numbers.
        /// </summary>
        /// <param name="transcriptId"></param>
        /// <param name="words"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WordSearchResponse> WordSearchAsync(
            string transcriptId,
            global::System.Collections.Generic.IList<string> words,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}