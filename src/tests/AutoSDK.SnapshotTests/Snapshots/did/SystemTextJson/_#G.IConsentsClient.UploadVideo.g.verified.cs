//HintName: G.IConsentsClient.UploadVideo.g.cs
#nullable enable

namespace G
{
    public partial interface IConsentsClient
    {
        /// <summary>
        /// Upload video for consent
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UploadVideoResponse> UploadVideoAsync(
            string id,

            global::G.UploadVideoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload video for consent
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sourceUrl"></param>
        /// <param name="name"></param>
        /// <param name="webhook"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UploadVideoResponse> UploadVideoAsync(
            string id,
            string sourceUrl,
            string name,
            string? webhook = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}