//HintName: G.Models.JobStep.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobStep
    {
        /// <summary>
        /// The phase of the lifecycle that the job is currently in.<br/>
        /// Example: queued
        /// </summary>
        /// <example>queued</example>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.JobStepStatus Status { get; set; } = default!;

        /// <summary>
        /// The outcome of the job.<br/>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::Newtonsoft.Json.JsonProperty("conclusion", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Conclusion { get; set; } = default!;

        /// <summary>
        /// The name of the job.<br/>
        /// Example: test-coverage
        /// </summary>
        /// <example>test-coverage</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// The time that the step started, in ISO 8601 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// The time that the job finished, in ISO 8601 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobStep" /> class.
        /// </summary>
        /// <param name="status">
        /// The phase of the lifecycle that the job is currently in.<br/>
        /// Example: queued
        /// </param>
        /// <param name="conclusion">
        /// The outcome of the job.<br/>
        /// Example: success
        /// </param>
        /// <param name="name">
        /// The name of the job.<br/>
        /// Example: test-coverage
        /// </param>
        /// <param name="number">
        /// Example: 1
        /// </param>
        /// <param name="startedAt">
        /// The time that the step started, in ISO 8601 format.
        /// </param>
        /// <param name="completedAt">
        /// The time that the job finished, in ISO 8601 format.
        /// </param>
        public JobStep(
            global::G.JobStepStatus status,
            string? conclusion,
            string name,
            int number,
            global::System.DateTime? startedAt,
            global::System.DateTime? completedAt)
        {
            this.Status = status;
            this.Conclusion = conclusion ?? throw new global::System.ArgumentNullException(nameof(conclusion));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Number = number;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobStep" /> class.
        /// </summary>
        public JobStep()
        {
        }
    }
}