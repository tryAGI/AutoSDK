//HintName: G.IVideosClient.DeleteVideo.g.cs
#nullable enable

namespace G
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Delete video
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteVideoAsync(
            global::System.Guid assetID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}