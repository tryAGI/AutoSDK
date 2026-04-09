//HintName: G.IApi.SamEmbedImageSamEmbedImagePost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// SAM Image Embeddings<br/>
        /// Run the Meta AI Segmant Anything Model to embed image data.
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
        global::System.Threading.Tasks.Task<global::G.SamEmbeddingResponse> SamEmbedImageSamEmbedImagePostAsync(

            global::G.SamEmbeddingRequest request,
            string? apiKey = default,
            bool? countinference = default,
            string? serviceSecret = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// SAM Image Embeddings<br/>
        /// Run the Meta AI Segmant Anything Model to embed image data.
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
        /// <param name="samVersionId">
        /// The version ID of SAM to be used for this request. Must be one of vit_h, vit_l, or vit_b.<br/>
        /// Default Value: vit_h
        /// </param>
        /// <param name="modelId"></param>
        /// <param name="image">
        /// The image to be embedded
        /// </param>
        /// <param name="imageId">
        /// The ID of the image to be embedded used to cache the embedding.
        /// </param>
        /// <param name="format">
        /// The format of the response. Must be one of json or binary. If binary, embedding is returned as a binary numpy array.<br/>
        /// Default Value: json
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SamEmbeddingResponse> SamEmbedImageSamEmbedImagePostAsync(
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
            string? samVersionId = default,
            string? modelId = default,
            global::G.InferenceRequestImage? image = default,
            string? imageId = default,
            string? format = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}