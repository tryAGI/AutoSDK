//HintName: G.Models.TuningTask.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tuning tasks that create tuned models.
    /// </summary>
    public sealed partial class TuningTask
    {
        /// <summary>
        /// Output only. The timestamp when tuning this model started.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        public string? StartTime { get; set; }

        /// <summary>
        /// Output only. The timestamp when tuning this model completed.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completeTime")]
        public string? CompleteTime { get; set; }

        /// <summary>
        /// Output only. Metrics collected during tuning.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshots")]
        public global::System.Collections.Generic.IList<global::G.TuningSnapshot>? Snapshots { get; set; }

        /// <summary>
        /// Dataset for training or validation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainingData")]
        public global::G.Dataset? TrainingData { get; set; }

        /// <summary>
        /// Hyperparameters controlling the tuning process. Read more at https://ai.google.dev/docs/model_tuning_guidance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hyperparameters")]
        public global::G.Hyperparameters? Hyperparameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TuningTask" /> class.
        /// </summary>
        /// <param name="startTime">
        /// Output only. The timestamp when tuning this model started.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="completeTime">
        /// Output only. The timestamp when tuning this model completed.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="snapshots">
        /// Output only. Metrics collected during tuning.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="trainingData">
        /// Dataset for training or validation.
        /// </param>
        /// <param name="hyperparameters">
        /// Hyperparameters controlling the tuning process. Read more at https://ai.google.dev/docs/model_tuning_guidance
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TuningTask(
            string? startTime,
            string? completeTime,
            global::System.Collections.Generic.IList<global::G.TuningSnapshot>? snapshots,
            global::G.Dataset? trainingData,
            global::G.Hyperparameters? hyperparameters)
        {
            this.StartTime = startTime;
            this.CompleteTime = completeTime;
            this.Snapshots = snapshots;
            this.TrainingData = trainingData;
            this.Hyperparameters = hyperparameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TuningTask" /> class.
        /// </summary>
        public TuningTask()
        {
        }
    }
}