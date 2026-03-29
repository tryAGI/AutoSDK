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
        /// The version ID of Gaze to be used for this request. Must be one of l2cs.<br/>
        /// Default Value: L2CS
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gaze_version_id")]
        public string? GazeVersionId { get; set; }

        /// <summary>
        /// If true, face detection will be applied; if false, face detection will be ignored and the whole input image will be used for gaze detection<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("do_run_face_detection")]
        public bool? DoRunFaceDetection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::G.InferenceRequestImage>, global::G.InferenceRequestImage> Image { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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