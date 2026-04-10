//HintName: G.IApi.Sam2EmbedImageSam2EmbedImagePost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// SAM2 Image Embeddings<br/>
        /// Run the Meta AI Segment Anything 2 Model to embed image data.
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
        global::System.Threading.Tasks.Task<global::G.Sam2EmbeddingResponse> Sam2EmbedImageSam2EmbedImagePostAsync(

            global::G.Sam2EmbeddingRequest request,
            string? apiKey = default,
            bool? countinference = default,
            string? serviceSecret = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// SAM2 Image Embeddings<br/>
        /// Run the Meta AI Segment Anything 2 Model to embed image data.
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
        /// <param name="image">
        /// The image to be embedded
        /// </param>
        /// <param name="imageId">
        /// The ID of the image to be embedded used to cache the embedding.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Sam2EmbeddingResponse> Sam2EmbedImageSam2EmbedImagePostAsync(
            string id,
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
            global::G.InferenceRequestImage? image = default,
            string? imageId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}