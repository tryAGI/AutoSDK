//HintName: G.IApi.Sam2SegmentImageSam2SegmentImagePost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// SAM2 Image Segmentation<br/>
        /// Run the Meta AI Segment Anything 2 Model to generate segmenations for image data.
        /// </summary>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Sam2SegmentationResponse> Sam2SegmentImageSam2SegmentImagePostAsync(

            global::G.Sam2SegmentationRequest request,
            string? apiKey = default,
            bool? countinference = default,
            string? serviceSecret = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// SAM2 Image Segmentation<br/>
        /// Run the Meta AI Segment Anything 2 Model to generate segmenations for image data.
        /// </summary>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="id"></param>
        /// <param name="requestApiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="usageBillable">
        /// Default Value: true
        /// </param>
        /// <param name="start"></param>
        /// <param name="source"></param>
        /// <param name="sourceInfo"></param>
        /// <param name="disableModelMonitoring">
        /// If true, disables model monitoring for this request<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sam2VersionId">
        /// The version ID of SAM to be used for this request. Must be one of hiera_tiny, hiera_small, hiera_large, hiera_b_plus<br/>
        /// Default Value: hiera_large
        /// </param>
        /// <param name="modelId"></param>
        /// <param name="format">
        /// The format of the response. Must be one of 'json', 'rle', or 'binary'. If binary, masks are returned as binary numpy arrays. If json, masks are converted to polygons. If rle, masks are converted to RLE format.<br/>
        /// Default Value: json
        /// </param>
        /// <param name="image">
        /// The image to be segmented.
        /// </param>
        /// <param name="imageId">
        /// The ID of the image to be segmented used to retrieve cached embeddings. If an embedding is cached, it will be used instead of generating a new embedding. If no embedding is cached, a new embedding will be generated and cached.
        /// </param>
        /// <param name="prompts">
        /// A list of prompts for masks to predict. Each prompt can include a bounding box and / or a set of postive or negative points. Also accepts a flat array of prompts (e.g. 'prompts': [{...}, {...}]) for convenience.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="multimaskOutput">
        /// If true, the model will return three masks. For ambiguous input prompts (such as a single click), this will often produce better masks than a single prediction. If only a single mask is needed, the model's predicted quality score can be used to select the best mask. For non-ambiguous prompts, such as multiple input prompts, multimask_output=False can give better results.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="saveLogitsToCache">
        /// If True, saves the low-resolution logits to the cache for potential future use. This can speed up subsequent requests with similar prompts on the same image. This feature is ignored if DISABLE_SAM2_LOGITS_CACHE env variable is set True<br/>
        /// Default Value: false
        /// </param>
        /// <param name="loadLogitsFromCache">
        /// If True, attempts to load previously cached low-resolution logits for the given image and prompt set. This can significantly speed up inference when making multiple similar requests on the same image. This feature is ignored if DISABLE_SAM2_LOGITS_CACHE env variable is set True<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Sam2SegmentationResponse> Sam2SegmentImageSam2SegmentImagePostAsync(
            string id,
            global::G.InferenceRequestImage image,
            string? apiKey = default,
            bool? countinference = default,
            string? serviceSecret = default,
            string? requestApiKey = default,
            bool? usageBillable = default,
            double? start = default,
            string? source = default,
            string? sourceInfo = default,
            bool? disableModelMonitoring = default,
            string? sam2VersionId = default,
            string? modelId = default,
            string? format = default,
            string? imageId = default,
            global::G.Sam2PromptSet? prompts = default,
            bool? multimaskOutput = default,
            bool? saveLogitsToCache = default,
            bool? loadLogitsFromCache = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}