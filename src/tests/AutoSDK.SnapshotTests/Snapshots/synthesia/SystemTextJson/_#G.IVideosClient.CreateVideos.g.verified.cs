//HintName: G.IVideosClient.CreateVideos.g.cs
#nullable enable

namespace G
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Create a video<br/>
        /// Create a video within your Synthesia account. To get started on this endpoint check the [API Quickstart guide](https://docs.synthesia.io/reference/synthesia-api-quickstart).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VideoResponse> CreateVideosAsync(

            global::G.CreateVideoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a video<br/>
        /// Create a video within your Synthesia account. To get started on this endpoint check the [API Quickstart guide](https://docs.synthesia.io/reference/synthesia-api-quickstart).
        /// </summary>
        /// <param name="folderId">
        /// Optional folder ID. If provided, the new video will be created under this folder and inherit its permissions.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio of the video. Default is `landscape (16:9)`.<br/>
        /// Default Value: 16:9
        /// </param>
        /// <param name="ctaSettings">
        /// Settings for a call-to-action button.
        /// </param>
        /// <param name="callbackId">
        /// Use callback ID to link videos back to the initial request. For example, if you are making a personalized video for a customer, you could enter the customer's email as a callback ID. This way, you can tell who the video is for, once its generated..
        /// </param>
        /// <param name="description">
        /// Description of the video to be shown on the share page.
        /// </param>
        /// <param name="input">
        /// An array of objects that each describe a clip of a multi-clip video. You can think of the clips as different scenes in the video.
        /// </param>
        /// <param name="soundtrack">
        /// soundtrack option is supported for backward compatibility. You should use the templates functionality for rich videos.
        /// </param>
        /// <param name="soundSettings"></param>
        /// <param name="test">
        /// Test videos are free and not counted towards your quota. If you create a video in the “test” mode, we will overlay a watermark over your video.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="title">
        /// Title of the video to be shown on the share page.
        /// </param>
        /// <param name="visibility">
        /// Public videos will be visible to anyone with a share URL.<br/>
        /// Private videos can only be downloaded via a time-limited download link. See Retrieve a video for details.<br/>
        /// Visibility can be changed also once the video is created via Update a video.<br/>
        /// Default Value: private
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.VideoResponse> CreateVideosAsync(
            global::System.Collections.Generic.IList<global::G.Input> input,
            global::System.Guid? folderId = default,
            global::G.CreateVideoRequestAspectRatio? aspectRatio = default,
            global::G.CtaSettings? ctaSettings = default,
            string? callbackId = default,
            string? description = default,
            global::G.CreateVideoRequestSoundtrack? soundtrack = default,
            global::G.ParentSoundSettings? soundSettings = default,
            bool? test = default,
            string? title = default,
            global::G.CreateVideoRequestVisibility? visibility = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}