//HintName: G.Models.Sam3SegmentationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Sam3SegmentationRequest
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
        /// The model ID of SAM3. Use 'sam3/sam3_final' to target the generic base model.<br/>
        /// Default Value: sam3/sam3_final
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// One of 'polygon', 'rle'<br/>
        /// Default Value: polygon
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        public string? Format { get; set; }

        /// <summary>
        /// The image to be segmented.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InferenceRequestImage Image { get; set; } = default!;

        /// <summary>
        /// Optional ID for caching embeddings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_id")]
        public string? ImageId { get; set; }

        /// <summary>
        /// Score threshold for outputs.<br/>
        /// Default Value: 0.5F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_prob_thresh")]
        public double? OutputProbThresh { get; set; }

        /// <summary>
        /// List of prompts (text and/or visual)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Sam3Prompt> Prompts { get; set; } = default!;

        /// <summary>
        /// IoU threshold for cross-prompt NMS. If None, NMS is disabled. Must be in [0.0, 1.0] when set.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nms_iou_threshold")]
        public double? NmsIouThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam3SegmentationRequest" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="image">
        /// The image to be segmented.
        /// </param>
        /// <param name="prompts">
        /// List of prompts (text and/or visual)
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
        /// <param name="modelId">
        /// The model ID of SAM3. Use 'sam3/sam3_final' to target the generic base model.<br/>
        /// Default Value: sam3/sam3_final
        /// </param>
        /// <param name="format">
        /// One of 'polygon', 'rle'<br/>
        /// Default Value: polygon
        /// </param>
        /// <param name="imageId">
        /// Optional ID for caching embeddings.
        /// </param>
        /// <param name="outputProbThresh">
        /// Score threshold for outputs.<br/>
        /// Default Value: 0.5F
        /// </param>
        /// <param name="nmsIouThreshold">
        /// IoU threshold for cross-prompt NMS. If None, NMS is disabled. Must be in [0.0, 1.0] when set.
        /// </param>
        public Sam3SegmentationRequest(
            string id,
            global::G.InferenceRequestImage image,
            global::System.Collections.Generic.IList<global::G.Sam3Prompt> prompts,
            string? apiKey,
            bool? usageBillable,
            double? start,
            string? source,
            string? sourceInfo,
            bool? disableModelMonitoring,
            string? modelId,
            string? format,
            string? imageId,
            double? outputProbThresh,
            double? nmsIouThreshold)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ApiKey = apiKey;
            this.UsageBillable = usageBillable;
            this.Start = start;
            this.Source = source;
            this.SourceInfo = sourceInfo;
            this.DisableModelMonitoring = disableModelMonitoring;
            this.ModelId = modelId;
            this.Format = format;
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.ImageId = imageId;
            this.OutputProbThresh = outputProbThresh;
            this.Prompts = prompts ?? throw new global::System.ArgumentNullException(nameof(prompts));
            this.NmsIouThreshold = nmsIouThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam3SegmentationRequest" /> class.
        /// </summary>
        public Sam3SegmentationRequest()
        {
        }
    }
}