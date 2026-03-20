//HintName: G.ITextToVoiceClient.GetTextToVoiceByGeneratedVoiceIdStream.g.cs
#nullable enable

namespace G
{
    public partial interface ITextToVoiceClient
    {

        /// <summary>
        /// Text To Voice Preview Streaming<br/>
        /// Stream a voice preview that was created via the /v1/text-to-voice/design endpoint.
        /// </summary>
        /// <param name="generatedVoiceId">
        /// The generated_voice_id to stream.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GetTextToVoiceByGeneratedVoiceIdStreamAsync(
            string generatedVoiceId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}