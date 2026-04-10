//HintName: G.IVideosClient.CreateVideosFromTemplate.g.cs
#nullable enable

namespace G
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Create a video from a template<br/>
        /// Create a video based on a template created in Synthesia.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VideoResponse> CreateVideosFromTemplateAsync(

            global::G.VideoFromTemplateApi request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a video from a template<br/>
        /// Create a video based on a template created in Synthesia.
        /// </summary>
        /// <param name="folderId">
        /// Optional folder ID. If provided, the new video will be created under this folder and inherit its permissions.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="callbackId">
        /// A callback ID that you may attach to the Video object. This is useful in the scenario where you need to store additional metadata on the video.
        /// </param>
        /// <param name="ctaSettings"></param>
        /// <param name="description">
        /// Description of the video (used on the video's share page). Defaults to the template description.
        /// </param>
        /// <param name="templateId">
        /// Unique identifier of the template from which to create this video. This may be retrieved from the templates page in STUDIO.
        /// </param>
        /// <param name="templateData"></param>
        /// <param name="test">
        /// Describes if the video is a test video. Test videos do not count towards your quota but are rendered with a watermark.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="title">
        /// Title of the video (used on the video's share page). Defaults to the template title.
        /// </param>
        /// <param name="visibility">
        /// Describes the private settings of the video. - If public, the video's share page is active. - If private, the video's share page is not active; visitors will receive a 404 Not Found response.<br/>
        /// Default Value: private
        /// </param>
        /// <param name="brandKitId">
        /// Brand kit ID for the video. Defaults to 'workspace_default' if not set. Use 'no_brand_kit' for no branding, or a UUID for a custom brand kit.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.VideoResponse> CreateVideosFromTemplateAsync(
            global::System.Guid templateId,
            object templateData,
            global::System.Guid? folderId = default,
            string? callbackId = default,
            global::G.CtaSettings? ctaSettings = default,
            string? description = default,
            bool? test = default,
            string? title = default,
            global::G.VideoFromTemplateApiVisibility? visibility = default,
            string? brandKitId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}