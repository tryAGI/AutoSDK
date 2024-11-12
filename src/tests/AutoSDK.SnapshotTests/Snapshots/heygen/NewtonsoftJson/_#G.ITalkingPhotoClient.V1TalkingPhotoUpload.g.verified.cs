//HintName: G.ITalkingPhotoClient.V1TalkingPhotoUpload.g.cs
#nullable enable

namespace G
{
    public partial interface ITalkingPhotoClient
    {
        /// <summary>
        /// v1/talking_photo (upload)<br/>
        /// v1/talking_photo (upload)
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task V1TalkingPhotoUploadAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}