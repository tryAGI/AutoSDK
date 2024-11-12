//HintName: G.IVoiceGenerationClient.GetVoiceGenerationGenerateVoiceParameters.g.cs
#nullable enable

namespace G
{
    public partial interface IVoiceGenerationClient
    {
        /// <summary>
        /// Voice Generation Parameters<br/>
        /// Get possible parameters for the /v1/voice-generation/generate-voice endpoint.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VoiceGenerationParameterResponseModel> GetVoiceGenerationGenerateVoiceParametersAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}