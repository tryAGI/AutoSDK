//HintName: G.Models.Sam2SegmentationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// SAM segmentation request.<br/>
    /// Attributes:<br/>
    ///     format (Optional[str]): The format of the response.<br/>
    ///     image (InferenceRequestImage): The image to be segmented.<br/>
    ///     image_id (Optional[str]): The ID of the image to be segmented used to retrieve cached embeddings.<br/>
    ///     point_coords (Optional[List[List[float]]]): The coordinates of the interactive points used during decoding.<br/>
    ///     point_labels (Optional[List[float]]): The labels of the interactive points used during decoding.
    /// </summary>
    public sealed partial class Sam2SegmentationRequest
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
        /// The version ID of SAM to be used for this request. Must be one of hiera_tiny, hiera_small, hiera_large, hiera_b_plus<br/>
        /// Default Value: hiera_large
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sam2_version_id")]
        public string? Sam2VersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// The format of the response. Must be one of 'json', 'rle', or 'binary'. If binary, masks are returned as binary numpy arrays. If json, masks are converted to polygons. If rle, masks are converted to RLE format.<br/>
        /// Default Value: json
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        public string? Format { get; set; }

        /// <summary>
        /// The image to be segmented.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InferenceRequestImage Image { get; set; } = default!;

        /// <summary>
        /// The ID of the image to be segmented used to retrieve cached embeddings. If an embedding is cached, it will be used instead of generating a new embedding. If no embedding is cached, a new embedding will be generated and cached.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_id")]
        public string? ImageId { get; set; }

        /// <summary>
        /// A list of prompts for masks to predict. Each prompt can include a bounding box and / or a set of postive or negative points. Also accepts a flat array of prompts (e.g. 'prompts': [{...}, {...}]) for convenience.<br/>
        /// Default Value: {}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompts")]
        public global::G.Sam2PromptSet? Prompts { get; set; }

        /// <summary>
        /// If true, the model will return three masks. For ambiguous input prompts (such as a single click), this will often produce better masks than a single prediction. If only a single mask is needed, the model's predicted quality score can be used to select the best mask. For non-ambiguous prompts, such as multiple input prompts, multimask_output=False can give better results.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("multimask_output")]
        public bool? MultimaskOutput { get; set; }

        /// <summary>
        /// If True, saves the low-resolution logits to the cache for potential future use. This can speed up subsequent requests with similar prompts on the same image. This feature is ignored if DISABLE_SAM2_LOGITS_CACHE env variable is set True<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("save_logits_to_cache")]
        public bool? SaveLogitsToCache { get; set; }

        /// <summary>
        /// If True, attempts to load previously cached low-resolution logits for the given image and prompt set. This can significantly speed up inference when making multiple similar requests on the same image. This feature is ignored if DISABLE_SAM2_LOGITS_CACHE env variable is set True<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("load_logits_from_cache")]
        public bool? LoadLogitsFromCache { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam2SegmentationRequest" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="image">
        /// The image to be segmented.
        /// </param>
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
        /// <param name="sam2VersionId">
        /// The version ID of SAM to be used for this request. Must be one of hiera_tiny, hiera_small, hiera_large, hiera_b_plus<br/>
        /// Default Value: hiera_large
        /// </param>
        /// <param name="modelId"></param>
        /// <param name="format">
        /// The format of the response. Must be one of 'json', 'rle', or 'binary'. If binary, masks are returned as binary numpy arrays. If json, masks are converted to polygons. If rle, masks are converted to RLE format.<br/>
        /// Default Value: json
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
        public Sam2SegmentationRequest(
            string id,
            global::G.InferenceRequestImage image,
            string? apiKey,
            bool? usageBillable,
            double? start,
            string? source,
            string? sourceInfo,
            bool? disableModelMonitoring,
            string? sam2VersionId,
            string? modelId,
            string? format,
            string? imageId,
            global::G.Sam2PromptSet? prompts,
            bool? multimaskOutput,
            bool? saveLogitsToCache,
            bool? loadLogitsFromCache)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ApiKey = apiKey;
            this.UsageBillable = usageBillable;
            this.Start = start;
            this.Source = source;
            this.SourceInfo = sourceInfo;
            this.DisableModelMonitoring = disableModelMonitoring;
            this.Sam2VersionId = sam2VersionId;
            this.ModelId = modelId;
            this.Format = format;
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.ImageId = imageId;
            this.Prompts = prompts;
            this.MultimaskOutput = multimaskOutput;
            this.SaveLogitsToCache = saveLogitsToCache;
            this.LoadLogitsFromCache = loadLogitsFromCache;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam2SegmentationRequest" /> class.
        /// </summary>
        public Sam2SegmentationRequest()
        {
        }
    }
}