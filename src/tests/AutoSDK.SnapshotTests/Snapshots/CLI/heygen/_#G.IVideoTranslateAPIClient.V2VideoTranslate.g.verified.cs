//HintName: G.IVideoTranslateAPIClient.V2VideoTranslate.g.cs
#nullable enable

namespace G
{
    public partial interface IVideoTranslateAPIClient
    {
        /// <summary>
        /// v2/video_translate<br/>
        /// Generated Video: [https://app.heygen.com/video-translation/share/dab5a987e6154b0cb7e606c858043fa9](https://app.heygen.com/video-translation/share/dab5a987e6154b0cb7e606c858043fa9)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task V2VideoTranslateAsync(
            global::G.V2VideoTranslateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// v2/video_translate<br/>
        /// Generated Video: [https://app.heygen.com/video-translation/share/dab5a987e6154b0cb7e606c858043fa9](https://app.heygen.com/video-translation/share/dab5a987e6154b0cb7e606c858043fa9)
        /// </summary>
        /// <param name="outputLanguage">
        /// Example: English - American Accent
        /// </param>
        /// <param name="speakerNum">
        /// Example: 1
        /// </param>
        /// <param name="title">
        /// Example: My Title
        /// </param>
        /// <param name="translateAudioOnly">
        /// Example: false
        /// </param>
        /// <param name="videoUrl">
        /// Example: https://static.heygen.ai/heygen/asset/originalnew.mp4
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task V2VideoTranslateAsync(
            string? outputLanguage = default,
            double? speakerNum = default,
            string? title = default,
            bool? translateAudioOnly = default,
            string? videoUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}