//HintName: G.Models.ClipCompareRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request for CLIP comparison.<br/>
    /// Attributes:<br/>
    ///     subject (Union[InferenceRequestImage, str]): The type of image data provided, one of 'url' or 'base64'.<br/>
    ///     subject_type (str): The type of subject, one of 'image' or 'text'.<br/>
    ///     prompt (Union[List[InferenceRequestImage], InferenceRequestImage, str, List[str], Dict[str, Union[InferenceRequestImage, str]]]): The prompt for comparison.<br/>
    ///     prompt_type (str): The type of prompt, one of 'image' or 'text'.
    /// </summary>
    public sealed partial class ClipCompareRequest
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
        /// The version ID of CLIP to be used for this request. Must be one of RN101, RN50, RN50x16, RN50x4, RN50x64, ViT-B-16, ViT-B-32, ViT-L-14-336px, and ViT-L-14.<br/>
        /// Default Value: ViT-B-16
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clip_version_id")]
        public string? ClipVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// The type of image data provided, one of 'url' or 'base64'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.InferenceRequestImage, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.InferenceRequestImage, string> Subject { get; set; }

        /// <summary>
        /// The type of subject, one of 'image' or 'text'<br/>
        /// Default Value: image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_type")]
        public string? SubjectType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage, string, global::System.Collections.Generic.IList<string>, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage, string, global::System.Collections.Generic.IList<string>, object> Prompt { get; set; }

        /// <summary>
        /// The type of prompt, one of 'image' or 'text'<br/>
        /// Default Value: text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_type")]
        public string? PromptType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipCompareRequest" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="subject">
        /// The type of image data provided, one of 'url' or 'base64'
        /// </param>
        /// <param name="prompt"></param>
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
        /// <param name="clipVersionId">
        /// The version ID of CLIP to be used for this request. Must be one of RN101, RN50, RN50x16, RN50x4, RN50x64, ViT-B-16, ViT-B-32, ViT-L-14-336px, and ViT-L-14.<br/>
        /// Default Value: ViT-B-16
        /// </param>
        /// <param name="modelId"></param>
        /// <param name="subjectType">
        /// The type of subject, one of 'image' or 'text'<br/>
        /// Default Value: image
        /// </param>
        /// <param name="promptType">
        /// The type of prompt, one of 'image' or 'text'<br/>
        /// Default Value: text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClipCompareRequest(
            string id,
            global::G.AnyOf<global::G.InferenceRequestImage, string> subject,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage, string, global::System.Collections.Generic.IList<string>, object> prompt,
            string? apiKey,
            bool? usageBillable,
            double? start,
            string? source,
            string? sourceInfo,
            bool? disableModelMonitoring,
            string? clipVersionId,
            string? modelId,
            string? subjectType,
            string? promptType)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ApiKey = apiKey;
            this.UsageBillable = usageBillable;
            this.Start = start;
            this.Source = source;
            this.SourceInfo = sourceInfo;
            this.DisableModelMonitoring = disableModelMonitoring;
            this.ClipVersionId = clipVersionId;
            this.ModelId = modelId;
            this.Subject = subject;
            this.SubjectType = subjectType;
            this.Prompt = prompt;
            this.PromptType = promptType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipCompareRequest" /> class.
        /// </summary>
        public ClipCompareRequest()
        {
        }
    }
}