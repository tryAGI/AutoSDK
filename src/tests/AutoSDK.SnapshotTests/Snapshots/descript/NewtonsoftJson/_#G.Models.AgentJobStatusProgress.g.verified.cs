//HintName: G.Models.AgentJobStatusProgress.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Progress information for the workflow (only present when job_state is running)
    /// </summary>
    public sealed partial class AgentJobStatusProgress
    {
        /// <summary>
        /// Human-readable label describing the current action<br/>
        /// Example: Applying Studio Sound to clip 2...
        /// </summary>
        /// <example>Applying Studio Sound to clip 2...</example>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public string Label { get; set; } = default!;

        /// <summary>
        /// Percentage of the workflow that has been completed<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::Newtonsoft.Json.JsonProperty("percent")]
        public int? Percent { get; set; }

        /// <summary>
        /// When the progress was last updated<br/>
        /// Example: 2025-11-18T10:32:00Z
        /// </summary>
        /// <example>2025-11-18T10:32:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("last_update_at")]
        public global::System.DateTime? LastUpdateAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentJobStatusProgress" /> class.
        /// </summary>
        /// <param name="label">
        /// Human-readable label describing the current action<br/>
        /// Example: Applying Studio Sound to clip 2...
        /// </param>
        /// <param name="percent">
        /// Percentage of the workflow that has been completed<br/>
        /// Example: 50
        /// </param>
        /// <param name="lastUpdateAt">
        /// When the progress was last updated<br/>
        /// Example: 2025-11-18T10:32:00Z
        /// </param>
        public AgentJobStatusProgress(
            string label,
            int? percent,
            global::System.DateTime? lastUpdateAt)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Percent = percent;
            this.LastUpdateAt = lastUpdateAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentJobStatusProgress" /> class.
        /// </summary>
        public AgentJobStatusProgress()
        {
        }
    }
}