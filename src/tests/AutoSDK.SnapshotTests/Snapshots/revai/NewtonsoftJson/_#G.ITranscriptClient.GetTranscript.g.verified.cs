//HintName: G.ITranscriptClient.GetTranscript.g.cs
#nullable enable

namespace G
{
    public partial interface ITranscriptClient
    {
        /// <summary>
        /// Get Transcript<br/>
        /// Returns the transcript for a completed transcription job in JSON or plain text format.
        /// </summary>
        /// <param name="accept">
        /// Default Value: application/vnd.rev.transcript.v1.0+json
        /// </param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Transcript> GetTranscriptAsync(
            string id,
            global::G.GetTranscriptAccept? accept = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}