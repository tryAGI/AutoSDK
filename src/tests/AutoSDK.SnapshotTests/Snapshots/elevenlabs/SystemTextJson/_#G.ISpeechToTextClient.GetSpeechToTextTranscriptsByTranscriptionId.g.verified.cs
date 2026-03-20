//HintName: G.ISpeechToTextClient.GetSpeechToTextTranscriptsByTranscriptionId.g.cs
#nullable enable

namespace G
{
    public partial interface ISpeechToTextClient
    {
        /// <summary>
        /// Get Transcript By Id<br/>
        /// Retrieve a previously generated transcript by its ID.
        /// </summary>
        /// <param name="transcriptionId">
        /// The unique ID of the transcript to retrieve
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.SpeechToTextChunkResponseModel, global::G.MultichannelSpeechToTextResponseModel>> GetSpeechToTextTranscriptsByTranscriptionIdAsync(
            string transcriptionId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}