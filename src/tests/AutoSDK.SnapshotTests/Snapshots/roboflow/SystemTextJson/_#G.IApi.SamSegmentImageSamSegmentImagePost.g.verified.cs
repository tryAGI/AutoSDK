//HintName: G.IApi.SamSegmentImageSamSegmentImagePost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// SAM Image Segmentation<br/>
        /// Run the Meta AI Segmant Anything Model to generate segmenations for image data.
        /// </summary>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SamSegmentationResponse> SamSegmentImageSamSegmentImagePostAsync(

            global::G.SamSegmentationRequest request,
            string? apiKey = default,
            bool? countinference = default,
            string? serviceSecret = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// SAM Image Segmentation<br/>
        /// Run the Meta AI Segmant Anything Model to generate segmenations for image data.
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
        /// <param name="embeddings">
        /// The embeddings to be decoded. The dimensions of the embeddings are 1 x 256 x 64 x 64. If embeddings is not provided, image must be provided.
        /// </param>
        /// <param name="embeddingsFormat">
        /// The format of the embeddings. Must be one of json or binary. If binary, embeddings are expected to be a binary numpy array.<br/>
        /// Default Value: json
        /// </param>
        /// <param name="format">
        /// The format of the response. Must be one of json or binary. If binary, masks are returned as binary numpy arrays. If json, masks are converted to polygons, then returned as json.<br/>
        /// Default Value: json
        /// </param>
        /// <param name="image">
        /// The image to be segmented. Only required if embeddings are not provided.
        /// </param>
        /// <param name="imageId">
        /// The ID of the image to be segmented used to retrieve cached embeddings. If an embedding is cached, it will be used instead of generating a new embedding. If no embedding is cached, a new embedding will be generated and cached.
        /// </param>
        /// <param name="hasMaskInput">
        /// Whether or not the request includes a mask input. If true, the mask input must be provided.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="maskInput">
        /// The set of output masks. If request format is json, masks is a list of polygons, where each polygon is a list of points, where each point is a tuple containing the x,y pixel coordinates of the point. If request format is binary, masks is a list of binary numpy arrays. The dimensions of each mask are 256 x 256. This is the same as the output, low resolution mask from the previous inference.
        /// </param>
        /// <param name="maskInputFormat">
        /// The format of the mask input. Must be one of json or binary. If binary, mask input is expected to be a binary numpy array.<br/>
        /// Default Value: json
        /// </param>
        /// <param name="origImSize">
        /// The original size of the image used to generate the embeddings. This is only required if the image is not provided.
        /// </param>
        /// <param name="pointCoords">
        /// The coordinates of the interactive points used during decoding. Each point (x,y pair) corresponds to a label in point_labels.<br/>
        /// Default Value: [[0F, 0F]]
        /// </param>
        /// <param name="pointLabels">
        /// The labels of the interactive points used during decoding. A 1 represents a positive point (part of the object to be segmented). A -1 represents a negative point (not part of the object to be segmented). Each label corresponds to a point in point_coords.<br/>
        /// Default Value: [-1]
        /// </param>
        /// <param name="useMaskInputCache">
        /// Whether or not to use the mask input cache. If true, the mask input cache will be used if it exists. If false, the mask input cache will not be used.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SamSegmentationResponse> SamSegmentImageSamSegmentImagePostAsync(
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
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object, object>? embeddings = default,
            string? embeddingsFormat = default,
            string? format = default,
            global::G.InferenceRequestImage? image = default,
            string? imageId = default,
            bool? hasMaskInput = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>, object, object>? maskInput = default,
            string? maskInputFormat = default,
            global::System.Collections.Generic.IList<int>? origImSize = default,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? pointCoords = default,
            global::System.Collections.Generic.IList<double>? pointLabels = default,
            bool? useMaskInputCache = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}