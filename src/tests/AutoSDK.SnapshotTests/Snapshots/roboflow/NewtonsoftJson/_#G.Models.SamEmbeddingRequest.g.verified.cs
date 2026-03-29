//HintName: G.Models.SamEmbeddingRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// SAM embedding request.<br/>
    /// Attributes:<br/>
    ///     image (Optional[inference.core.entities.requests.inference.InferenceRequestImage]): The image to be embedded.<br/>
    ///     image_id (Optional[str]): The ID of the image to be embedded used to cache the embedding.<br/>
    ///     format (Optional[str]): The format of the response. Must be one of json or binary.
    /// </summary>
    public sealed partial class SamEmbeddingRequest
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
        /// The image to be embedded
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image")]
        public global::G.InferenceRequestImage? Image { get; set; }

        /// <summary>
        /// The ID of the image to be embedded used to cache the embedding.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_id")]
        public string? ImageId { get; set; }

        /// <summary>
        /// The format of the response. Must be one of json or binary. If binary, embedding is returned as a binary numpy array.<br/>
        /// Default Value: json
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        public string? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SamEmbeddingRequest" /> class.
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
        public SamEmbeddingRequest(
            string id,
            string? apiKey,
            bool? usageBillable,
            double? start,
            string? source,
            string? sourceInfo,
            bool? disableModelMonitoring,
            string? samVersionId,
            string? modelId,
            global::G.InferenceRequestImage? image,
            string? imageId,
            string? format)
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
            this.Image = image;
            this.ImageId = imageId;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SamEmbeddingRequest" /> class.
        /// </summary>
        public SamEmbeddingRequest()
        {
        }
    }
}