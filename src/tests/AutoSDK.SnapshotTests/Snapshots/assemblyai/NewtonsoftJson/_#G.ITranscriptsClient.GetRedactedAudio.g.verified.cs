//HintName: G.ITranscriptsClient.GetRedactedAudio.g.cs
#nullable enable

namespace G
{
    public partial interface ITranscriptsClient
    {
        /// <summary>
        /// Get redacted audio<br/>
        /// Retrieve the redacted audio object containing the status and URL to the redacted audio.
        /// </summary>
        /// <param name="transcriptId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RedactedAudioResponse> GetRedactedAudioAsync(
            string transcriptId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}