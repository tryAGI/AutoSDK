//HintName: G.Models.EasyOCRInferenceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// EasyOCR inference request.<br/>
    /// Attributes:<br/>
    ///     api_key (Optional[str]): Roboflow API Key.
    /// </summary>
    public sealed partial class EasyOCRInferenceRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage> Image { get; set; }

        /// <summary>
        /// Default Value: english_g2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("easy_ocr_version_id")]
        public string? EasyOcrVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Default Value: [en]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_codes")]
        public global::System.Collections.Generic.IList<string>? LanguageCodes { get; set; }

        /// <summary>
        /// Quantized models are smaller and faster, but may be less accurate and won't work correctly on all hardware.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantize")]
        public bool? Quantize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EasyOCRInferenceRequest" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="image"></param>
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
        /// <param name="easyOcrVersionId">
        /// Default Value: english_g2
        /// </param>
        /// <param name="modelId"></param>
        /// <param name="languageCodes">
        /// Default Value: [en]
        /// </param>
        /// <param name="quantize">
        /// Quantized models are smaller and faster, but may be less accurate and won't work correctly on all hardware.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EasyOCRInferenceRequest(
            string id,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage> image,
            string? apiKey,
            bool? usageBillable,
            double? start,
            string? source,
            string? sourceInfo,
            bool? disableModelMonitoring,
            string? easyOcrVersionId,
            string? modelId,
            global::System.Collections.Generic.IList<string>? languageCodes,
            bool? quantize)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ApiKey = apiKey;
            this.UsageBillable = usageBillable;
            this.Start = start;
            this.Source = source;
            this.SourceInfo = sourceInfo;
            this.DisableModelMonitoring = disableModelMonitoring;
            this.Image = image;
            this.EasyOcrVersionId = easyOcrVersionId;
            this.ModelId = modelId;
            this.LanguageCodes = languageCodes;
            this.Quantize = quantize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EasyOCRInferenceRequest" /> class.
        /// </summary>
        public EasyOCRInferenceRequest()
        {
        }
    }
}