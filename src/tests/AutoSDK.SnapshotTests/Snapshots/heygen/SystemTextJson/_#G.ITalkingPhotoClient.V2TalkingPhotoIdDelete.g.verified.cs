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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task V2TalkingPhotoIdDeleteAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}