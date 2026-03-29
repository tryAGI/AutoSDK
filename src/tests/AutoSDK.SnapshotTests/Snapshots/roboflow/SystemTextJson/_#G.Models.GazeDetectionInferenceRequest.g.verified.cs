//HintName: G.Models.GazeDetectionInferenceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request for gaze detection inference.<br/>
    /// Attributes:<br/>
    ///     api_key (Optional[str]): Roboflow API Key.<br/>
    ///     gaze_version_id (Optional[str]): The version ID of Gaze to be used for this request.<br/>
    ///     do_run_face_detection (Optional[bool]): If true, face detection will be applied; if false, face detection will be ignored and the whole input image will be used for gaze detection.<br/>
    ///     image (Union[List[InferenceRequestImage], InferenceRequestImage]): Image(s) for inference.
    /// </summary>
    public sealed partial class GazeDetectionInferenceRequest
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
        /// The version ID of Gaze to be used for this request. Must be one of l2cs.<br/>
        /// Default Value: L2CS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gaze_version_id")]
        public string? GazeVersionId { get; set; }

        /// <summary>
        /// If true, face detection will be applied; if false, face detection will be ignored and the whole input image will be used for gaze detection<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do_run_face_detection")]
        public bool? DoRunFaceDetection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage> Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GazeDetectionInferenceRequest" /> class.
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
        /// <param name="gazeVersionId">
        /// The version ID of Gaze to be used for this request. Must be one of l2cs.<br/>
        /// Default Value: L2CS
        /// </param>
        /// <param name="doRunFaceDetection">
        /// If true, face detection will be applied; if false, face detection will be ignored and the whole input image will be used for gaze detection<br/>
        /// Default Value: true
        /// </param>
        /// <param name="modelId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GazeDetectionInferenceRequest(
            string id,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage> image,
            string? apiKey,
            bool? usageBillable,
            double? start,
            string? source,
            string? sourceInfo,
            bool? disableModelMonitoring,
            string? gazeVersionId,
            bool? doRunFaceDetection,
            string? modelId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ApiKey = apiKey;
            this.UsageBillable = usageBillable;
            this.Start = start;
            this.Source = source;
            this.SourceInfo = sourceInfo;
            this.DisableModelMonitoring = disableModelMonitoring;
            this.GazeVersionId = gazeVersionId;
            this.DoRunFaceDetection = doRunFaceDetection;
            this.Image = image;
            this.ModelId = modelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GazeDetectionInferenceRequest" /> class.
        /// </summary>
        public GazeDetectionInferenceRequest()
        {
        }
    }
}