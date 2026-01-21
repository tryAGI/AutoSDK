//HintName: G.IApi.OpenaiAudioTranslationsV1OpenaiAudioTranslationsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Openai Audio Translations
        /// </summary>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OpenaiAudioTranslationsV1OpenaiAudioTranslationsPostAsync(
            global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPost request,
            string? xDeepinfraSource = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Openai Audio Translations
        /// </summary>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="model"></param>
        /// <param name="prompt"></param>
        /// <param name="responseFormat">
        /// Default Value: json
        /// </param>
        /// <param name="temperature">
        /// Default Value: 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> OpenaiAudioTranslationsV1OpenaiAudioTranslationsPostAsync(
            byte[] file,
            string filename,
            string model,
            string? xDeepinfraSource = default,
            string? xiApiKey = default,
            string? prompt = default,
            global::G.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2? responseFormat = default,
            double? temperature = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}