//HintName: G.IVideosClient.EditVideosByVideoId.g.cs
#nullable enable

namespace G
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Update a video<br/>
        /// Use the Update a video endpoint to make the video public and accessible via the share page or update its title and description.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VideoResponse> EditVideosByVideoIdAsync(
            string videoId,

            global::G.UpdateVideoMetadataRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a video<br/>
        /// Use the Update a video endpoint to make the video public and accessible via the share page or update its title and description.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="ctaSettings"></param>
        /// <param name="description"></param>
        /// <param name="title"></param>
        /// <param name="visibility"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.VideoResponse> EditVideosByVideoIdAsync(
            string videoId,
            global::G.CtaSettings? ctaSettings = default,
            string? description = default,
            string? title = default,
            global::G.UpdateVideoMetadataRequestVisibility? visibility = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}