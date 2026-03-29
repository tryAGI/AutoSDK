//HintName: G.Models.YOLOWorldInferenceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request for Grounding DINO zero-shot predictions.<br/>
    /// Attributes:<br/>
    ///     text (List[str]): A list of strings.
    /// </summary>
    public sealed partial class YOLOWorldInferenceRequest
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// The type of the model, usually referring to what task the model performs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_type")]
        public string? ModelType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage> Image { get; set; }

        /// <summary>
        /// If true, the auto orient preprocessing step is disabled for this call.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_preproc_auto_orient")]
        public bool? DisablePreprocAutoOrient { get; set; }

        /// <summary>
        /// If true, the auto contrast preprocessing step is disabled for this call.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_preproc_contrast")]
        public bool? DisablePreprocContrast { get; set; }

        /// <summary>
        /// If true, the grayscale preprocessing step is disabled for this call.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_preproc_grayscale")]
        public bool? DisablePreprocGrayscale { get; set; }

        /// <summary>
        /// If true, the static crop preprocessing step is disabled for this call.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_preproc_static_crop")]
        public bool? DisablePreprocStaticCrop { get; set; }

        /// <summary>
        /// A list of strings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Text { get; set; }

        /// <summary>
        /// Default Value: l
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("yolo_world_version_id")]
        public string? YoloWorldVersionId { get; set; }

        /// <summary>
        /// Default Value: 0.4F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="YOLOWorldInferenceRequest" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="image"></param>
        /// <param name="text">
        /// A list of strings
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
        /// <param name="modelId"></param>
        /// <param name="modelType">
        /// The type of the model, usually referring to what task the model performs
        /// </param>
        /// <param name="disablePreprocAutoOrient">
        /// If true, the auto orient preprocessing step is disabled for this call.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="disablePreprocContrast">
        /// If true, the auto contrast preprocessing step is disabled for this call.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="disablePreprocGrayscale">
        /// If true, the grayscale preprocessing step is disabled for this call.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="disablePreprocStaticCrop">
        /// If true, the static crop preprocessing step is disabled for this call.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="yoloWorldVersionId">
        /// Default Value: l
        /// </param>
        /// <param name="confidence">
        /// Default Value: 0.4F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public YOLOWorldInferenceRequest(
            string id,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage> image,
            global::System.Collections.Generic.IList<string> text,
            string? apiKey,
            bool? usageBillable,
            double? start,
            string? source,
            string? sourceInfo,
            bool? disableModelMonitoring,
            string? modelId,
            string? modelType,
            bool? disablePreprocAutoOrient,
            bool? disablePreprocContrast,
            bool? disablePreprocGrayscale,
            bool? disablePreprocStaticCrop,
            string? yoloWorldVersionId,
            double? confidence)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ApiKey = apiKey;
            this.UsageBillable = usageBillable;
            this.Start = start;
            this.Source = source;
            this.SourceInfo = sourceInfo;
            this.DisableModelMonitoring = disableModelMonitoring;
            this.ModelId = modelId;
            this.ModelType = modelType;
            this.Image = image;
            this.DisablePreprocAutoOrient = disablePreprocAutoOrient;
            this.DisablePreprocContrast = disablePreprocContrast;
            this.DisablePreprocGrayscale = disablePreprocGrayscale;
            this.DisablePreprocStaticCrop = disablePreprocStaticCrop;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.YoloWorldVersionId = yoloWorldVersionId;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="YOLOWorldInferenceRequest" /> class.
        /// </summary>
        public YOLOWorldInferenceRequest()
        {
        }
    }
}