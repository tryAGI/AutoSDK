//HintName: G.IApi.OpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Openai Audio Transcriptions
        /// </summary>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostAsync(
            global::G.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPost request,
            string? xDeepinfraSource = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Openai Audio Transcriptions
        /// </summary>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="model"></param>
        /// <param name="language"></param>
        /// <param name="prompt"></param>
        /// <param name="responseFormat">
        /// Default Value: json
        /// </param>
        /// <param name="temperature">
        /// Default Value: 0
        /// </param>
        /// <param name="timestampGranularities"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> OpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostAsync(
            byte[] file,
            string filename,
            string model,
            string? xDeepinfraSource = default,
            string? xiApiKey = default,
            string? language = default,
            string? prompt = default,
            global::G.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat2? responseFormat = default,
            double? temperature = default,
            global::System.Collections.Generic.IList<global::G.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostTimestampGranularitiesVariant1Item>? timestampGranularities = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}