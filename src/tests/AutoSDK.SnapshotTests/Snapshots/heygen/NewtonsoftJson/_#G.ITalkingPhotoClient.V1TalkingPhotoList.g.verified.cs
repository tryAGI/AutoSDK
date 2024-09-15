//HintName: G.ITalkingPhotoClient.V1TalkingPhotoList.g.cs
#nullable enable

namespace G
{
    public partial interface ITalkingPhotoClient
    {
        /// <summary>
        /// v1/talking_photo.list<br/>
        /// v1/talking_photo.list
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task V1TalkingPhotoListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}