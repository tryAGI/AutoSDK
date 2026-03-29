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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_billable")]
        public bool? UsageBillable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public double? Start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_info")]
        public string? SourceInfo { get; set; }

        /// <summary>
        /// If true, disables model monitoring for this request<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_model_monitoring")]
        public bool? DisableModelMonitoring { get; set; }

        /// <summary>
        /// The model ID of SAM3. Use 'sam3/sam3_final' to target the generic base model.<br/>
        /// Default Value: sam3/sam3_final
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// One of 'polygon', 'rle'<br/>
        /// Default Value: polygon
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public string? Format { get; set; }

        /// <summary>
        /// The image to be segmented.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.InferenceRequestImage Image { get; set; }

        /// <summary>
        /// Optional ID for caching embeddings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_id")]
        public string? ImageId { get; set; }

        /// <summary>
        /// Score threshold for outputs.<br/>
        /// Default Value: 0.5F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_prob_thresh")]
        public double? OutputProbThresh { get; set; }

        /// <summary>
        /// List of prompts (text and/or visual)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Sam3Prompt> Prompts { get; set; }

        /// <summary>
        /// IoU threshold for cross-prompt NMS. If None, NMS is disabled. Must be in [0.0, 1.0] when set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nms_iou_threshold")]
        public double? NmsIouThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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