//HintName: G.ITranscriptionV2Client.TranscriptionControllerGetTranscriptV2.g.cs
#nullable enable

namespace G
{
    public partial interface ITranscriptionV2Client
    {
        /// <summary>
        /// Get the transcription job's metadata
        /// </summary>
        /// <param name="id">
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TranscriptionControllerGetTranscriptV2Response> TranscriptionControllerGetTranscriptV2Async(
            string id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}