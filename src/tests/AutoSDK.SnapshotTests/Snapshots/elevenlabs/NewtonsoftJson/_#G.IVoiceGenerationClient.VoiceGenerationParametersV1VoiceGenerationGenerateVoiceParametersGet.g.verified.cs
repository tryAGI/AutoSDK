//HintName: G.IVoiceGenerationClient.VoiceGenerationParametersV1VoiceGenerationGenerateVoiceParametersGet.g.cs
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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.VoiceGenerationParameterResponseModel> VoiceGenerationParametersV1VoiceGenerationGenerateVoiceParametersGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}