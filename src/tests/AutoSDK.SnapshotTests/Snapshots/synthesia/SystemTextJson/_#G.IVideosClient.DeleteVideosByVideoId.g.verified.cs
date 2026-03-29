//HintName: G.IVideosClient.DeleteVideosByVideoId.g.cs
#nullable enable

namespace G
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Delete a video<br/>
        /// Use this endpoint to delete videos.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteVideosByVideoIdAsync(
            string videoId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}