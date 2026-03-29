//HintName: G.Models.SamSegmentationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// SAM segmentation request.<br/>
    /// Attributes:<br/>
    ///     embeddings (Optional[Union[List[List[List[List[float]]]], Any]]): The embeddings to be decoded.<br/>
    ///     embeddings_format (Optional[str]): The format of the embeddings.<br/>
    ///     format (Optional[str]): The format of the response.<br/>
    ///     image (Optional[InferenceRequestImage]): The image to be segmented.<br/>
    ///     image_id (Optional[str]): The ID of the image to be segmented used to retrieve cached embeddings.<br/>
    ///     has_mask_input (Optional[bool]): Whether or not the request includes a mask input.<br/>
    ///     mask_input (Optional[Union[List[List[List[float]]], Any]]): The set of output masks.<br/>
    ///     mask_input_format (Optional[str]): The format of the mask input.<br/>
    ///     orig_im_size (Optional[List[int]]): The original size of the image used to generate the embeddings.<br/>
    ///     point_coords (Optional[List[List[float]]]): The coordinates of the interactive points used during decoding.<br/>
    ///     point_labels (Optional[List[float]]): The labels of the interactive points used during decoding.<br/>
    ///     use_mask_input_cache (Optional[bool]): Whether or not to use the mask input cache.
    /// </summary>
    public sealed partial class SamSegmentationRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_billable")]
        public bool? UsageBillable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start")]
        public double? Start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public string? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_info")]
        public string? SourceInfo { get; set; }

        /// <summary>
        /// If true, disables model monitoring for this request<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disable_model_monitoring")]
        public bool? DisableModelMonitoring { get; set; }

        /// <summary>
        /// The version ID of SAM to be used for this request. Must be one of vit_h, vit_l, or vit_b.<br/>
        /// Default Value: vit_h
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sam_version_id")]
        public string? SamVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// The embeddings to be decoded. The dimensions of the embeddings are 1 x 256 x 64 x 64. If embeddings is not provided, image must be provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embeddings")]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object, object>? Embeddings { get; set; }

        /// <summary>
        /// The format of the embeddings. Must be one of json or binary. If binary, embeddings are expected to be a binary numpy array.<br/>
        /// Default Value: json
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embeddings_format")]
        public string? EmbeddingsFormat { get; set; }

        /// <summary>
        /// The format of the response. Must be one of json or binary. If binary, masks are returned as binary numpy arrays. If json, masks are converted to polygons, then returned as json.<br/>
        /// Default Value: json
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        public string? Format { get; set; }

        /// <summary>
        /// The image to be segmented. Only required if embeddings are not provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image")]
        public global::G.InferenceRequestImage? Image { get; set; }

        /// <summary>
        /// The ID of the image to be segmented used to retrieve cached embeddings. If an embedding is cached, it will be used instead of generating a new embedding. If no embedding is cached, a new embedding will be generated and cached.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_id")]
        public string? ImageId { get; set; }

        /// <summary>
        /// Whether or not the request includes a mask input. If true, the mask input must be provided.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_mask_input")]
        public bool? HasMaskInput { get; set; }

        /// <summary>
        /// The set of output masks. If request format is json, masks is a list of polygons, where each polygon is a list of points, where each point is a tuple containing the x,y pixel coordinates of the point. If request format is binary, masks is a list of binary numpy arrays. The dimensions of each mask are 256 x 256. This is the same as the output, low resolution mask from the previous inference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mask_input")]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>, object, object>? MaskInput { get; set; }

        /// <summary>
        /// The format of the mask input. Must be one of json or binary. If binary, mask input is expected to be a binary numpy array.<br/>
        /// Default Value: json
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mask_input_format")]
        public string? MaskInputFormat { get; set; }

        /// <summary>
        /// The original size of the image used to generate the embeddings. This is only required if the image is not provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("orig_im_size")]
        public global::System.Collections.Generic.IList<int>? OrigImSize { get; set; }

        /// <summary>
        /// The coordinates of the interactive points used during decoding. Each point (x,y pair) corresponds to a label in point_labels.<br/>
        /// Default Value: [[0F, 0F]]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("point_coords")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? PointCoords { get; set; }

        /// <summary>
        /// The labels of the interactive points used during decoding. A 1 represents a positive point (part of the object to be segmented). A -1 represents a negative point (not part of the object to be segmented). Each label corresponds to a point in point_coords.<br/>
        /// Default Value: [-1]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("point_labels")]
        public global::System.Collections.Generic.IList<double>? PointLabels { get; set; }

        /// <summary>
        /// Whether or not to use the mask input cache. If true, the mask input cache will be used if it exists. If false, the mask input cache will not be used.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_mask_input_cache")]
        public bool? UseMaskInputCache { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SamSegmentationRequest" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="apiKey">
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
        public SamSegmentationRequest(
            string id,
            string? apiKey,
            bool? usageBillable,
            double? start,
            string? source,
            string? sourceInfo,
            bool? disableModelMonitoring,
            string? samVersionId,
            string? modelId,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object, object>? embeddings,
            string? embeddingsFormat,
            string? format,
            global::G.InferenceRequestImage? image,
            string? imageId,
            bool? hasMaskInput,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>, object, object>? maskInput,
            string? maskInputFormat,
            global::System.Collections.Generic.IList<int>? origImSize,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? pointCoords,
            global::System.Collections.Generic.IList<double>? pointLabels,
            bool? useMaskInputCache)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ApiKey = apiKey;
            this.UsageBillable = usageBillable;
            this.Start = start;
            this.Source = source;
            this.SourceInfo = sourceInfo;
            this.DisableModelMonitoring = disableModelMonitoring;
            this.SamVersionId = samVersionId;
            this.ModelId = modelId;
            this.Embeddings = embeddings;
            this.EmbeddingsFormat = embeddingsFormat;
            this.Format = format;
            this.Image = image;
            this.ImageId = imageId;
            this.HasMaskInput = hasMaskInput;
            this.MaskInput = maskInput;
            this.MaskInputFormat = maskInputFormat;
            this.OrigImSize = origImSize;
            this.PointCoords = pointCoords;
            this.PointLabels = pointLabels;
            this.UseMaskInputCache = useMaskInputCache;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SamSegmentationRequest" /> class.
        /// </summary>
        public SamSegmentationRequest()
        {
        }
    }
}