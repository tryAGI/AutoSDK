//HintName: G.Models.StubResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StubResponse
    {
        /// <summary>
        /// Base64 encoded string containing prediction visualization image data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visualization")]
        public string? Visualization { get; set; }

        /// <summary>
        /// Unique identifier of inference
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inference_id")]
        public string? InferenceId { get; set; }

        /// <summary>
        /// The frame id of the image used in inference if the input was a video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frame_id")]
        public int? FrameId { get; set; }

        /// <summary>
        /// The time in seconds it took to produce the predictions including image preprocessing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time")]
        public double? Time { get; set; }

        /// <summary>
        /// Field to mark prediction type as stub
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_stub", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsStub { get; set; } = default!;

        /// <summary>
        /// Identifier of a model stub that was called
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelId { get; set; } = default!;

        /// <summary>
        /// Task type of the project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string TaskType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StubResponse" /> class.
        /// </summary>
        /// <param name="isStub">
        /// Field to mark prediction type as stub
        /// </param>
        /// <param name="modelId">
        /// Identifier of a model stub that was called
        /// </param>
        /// <param name="taskType">
        /// Task type of the project
        /// </param>
        /// <param name="visualization">
        /// Base64 encoded string containing prediction visualization image data
        /// </param>
        /// <param name="inferenceId">
        /// Unique identifier of inference
        /// </param>
        /// <param name="frameId">
        /// The frame id of the image used in inference if the input was a video
        /// </param>
        /// <param name="time">
        /// The time in seconds it took to produce the predictions including image preprocessing
        /// </param>
        public StubResponse(
            bool isStub,
            string modelId,
            string taskType,
            string? visualization,
            string? inferenceId,
            int? frameId,
            double? time)
        {
            this.Visualization = visualization;
            this.InferenceId = inferenceId;
            this.FrameId = frameId;
            this.Time = time;
            this.IsStub = isStub;
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.TaskType = taskType ?? throw new global::System.ArgumentNullException(nameof(taskType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StubResponse" /> class.
        /// </summary>
        public StubResponse()
        {
        }
    }
}