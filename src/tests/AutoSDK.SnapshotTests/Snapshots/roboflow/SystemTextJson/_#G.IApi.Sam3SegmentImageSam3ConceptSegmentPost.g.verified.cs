//HintName: G.IApi.Sam3SegmentImageSam3ConceptSegmentPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// SAM3 PCS (promptable concept segmentation)<br/>
        /// Run the SAM3 PCS (promptable concept segmentation) to generate segmentations for image data.
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
        global::System.Threading.Tasks.Task<global::G.Sam3SegmentationResponse> Sam3SegmentImageSam3ConceptSegmentPostAsync(

            global::G.Sam3SegmentationRequest request,
            string? apiKey = default,
            bool? countinference = default,
            string? serviceSecret = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// SAM3 PCS (promptable concept segmentation)<br/>
        /// Run the SAM3 PCS (promptable concept segmentation) to generate segmentations for image data.
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
        /// <param name="modelId">
        /// The model ID of SAM3. Use 'sam3/sam3_final' to target the generic base model.<br/>
        /// Default Value: sam3/sam3_final
        /// </param>
        /// <param name="format">
        /// One of 'polygon', 'rle'<br/>
        /// Default Value: polygon
        /// </param>
        /// <param name="image">
        /// The image to be segmented.
        /// </param>
        /// <param name="imageId">
        /// Optional ID for caching embeddings.
        /// </param>
        /// <param name="outputProbThresh">
        /// Score threshold for outputs.<br/>
        /// Default Value: 0.5F
        /// </param>
        /// <param name="prompts">
        /// List of prompts (text and/or visual)
        /// </param>
        /// <param name="nmsIouThreshold">
        /// IoU threshold for cross-prompt NMS. If None, NMS is disabled. Must be in [0.0, 1.0] when set.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Sam3SegmentationResponse> Sam3SegmentImageSam3ConceptSegmentPostAsync(
            string id,
            global::G.InferenceRequestImage image,
            global::System.Collections.Generic.IList<global::G.Sam3Prompt> prompts,
            string? apiKey = default,
            bool? countinference = default,
            string? serviceSecret = default,
            string? requestApiKey = default,
            bool? usageBillable = default,
            double? start = default,
            string? source = default,
            string? sourceInfo = default,
            bool? disableModelMonitoring = default,
            string? modelId = default,
            string? format = default,
            string? imageId = default,
            double? outputProbThresh = default,
            double? nmsIouThreshold = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}