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
        [global::System.Text.Json.Serialization.JsonPropertyName("visualization")]
        public string? Visualization { get; set; }

        /// <summary>
        /// Unique identifier of inference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference_id")]
        public string? InferenceId { get; set; }

        /// <summary>
        /// The frame id of the image used in inference if the input was a video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_id")]
        public int? FrameId { get; set; }

        /// <summary>
        /// The time in seconds it took to produce the predictions including image preprocessing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public double? Time { get; set; }

        /// <summary>
        /// Field to mark prediction type as stub
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_stub")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsStub { get; set; }

        /// <summary>
        /// Identifier of a model stub that was called
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// Task type of the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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