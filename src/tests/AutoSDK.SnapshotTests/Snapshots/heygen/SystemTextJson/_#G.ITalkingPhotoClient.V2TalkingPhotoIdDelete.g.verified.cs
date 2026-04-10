//HintName: G.ITalkingPhotoClient.V2TalkingPhotoIdDelete.g.cs
#nullable enable

namespace G
{
    public partial interface ITalkingPhotoClient
    {
        /// <summary>
        /// v2/talking_photo/&lt;id&gt; (delete)<br/>
        /// v2/talking_photo/&lt;id&gt; (delete)
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task V2TalkingPhotoIdDeleteAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}