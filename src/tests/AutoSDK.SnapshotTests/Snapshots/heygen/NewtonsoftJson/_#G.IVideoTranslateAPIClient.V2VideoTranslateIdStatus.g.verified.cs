//HintName: G.IVideoTranslateAPIClient.V2VideoTranslateIdStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IVideoTranslateAPIClient
    {
        /// <summary>
        /// v2/video_translate/&lt;id&gt; (status)<br/>
        /// v2/video_translate/&lt;id&gt; (status)
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task V2VideoTranslateIdStatusAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}