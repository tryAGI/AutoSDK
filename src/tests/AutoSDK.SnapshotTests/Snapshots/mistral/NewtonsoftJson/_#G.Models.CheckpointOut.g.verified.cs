//HintName: G.Models.CheckpointOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckpointOut
    {
        /// <summary>
        /// The UNIX timestamp (in seconds) for when the checkpoint was created.<br/>
        /// Example: 1716963433
        /// </summary>
        /// <example>1716963433</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// Metrics at the step number during the fine-tuning job. Use these metrics to assess if the training is going smoothly (loss should decrease, token accuracy should increase).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metrics", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MetricOut Metrics { get; set; } = default!;

        /// <summary>
        /// The step number that the checkpoint was created at.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("step_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int StepNumber { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckpointOut" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The UNIX timestamp (in seconds) for when the checkpoint was created.<br/>
        /// Example: 1716963433
        /// </param>
        /// <param name="metrics">
        /// Metrics at the step number during the fine-tuning job. Use these metrics to assess if the training is going smoothly (loss should decrease, token accuracy should increase).
        /// </param>
        /// <param name="stepNumber">
        /// The step number that the checkpoint was created at.
        /// </param>
        public CheckpointOut(
            global::System.DateTimeOffset createdAt,
            global::G.MetricOut metrics,
            int stepNumber)
        {
            this.CreatedAt = createdAt;
            this.Metrics = metrics ?? throw new global::System.ArgumentNullException(nameof(metrics));
            this.StepNumber = stepNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckpointOut" /> class.
        /// </summary>
        public CheckpointOut()
        {
        }
    }
}