//HintName: G.IVideoTranslateAPIClient.V2VideoTranslateTargetLanguages.g.cs
#nullable enable

namespace G
{
    public partial interface IVideoTranslateAPIClient
    {
        /// <summary>
        /// v2/video_translate/target_languages<br/>
        /// v2/video_translate/target_languages
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task V2VideoTranslateTargetLanguagesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}