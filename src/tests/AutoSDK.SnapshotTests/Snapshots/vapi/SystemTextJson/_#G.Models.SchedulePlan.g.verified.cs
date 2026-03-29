//HintName: G.Models.SchedulePlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SchedulePlan
    {
        /// <summary>
        /// This is the ISO 8601 date-time string of the earliest time the call can be scheduled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("earliestAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EarliestAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of the latest time the call can be scheduled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestAt")]
        public global::System.DateTime? LatestAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulePlan" /> class.
        /// </summary>
        /// <param name="earliestAt">
        /// This is the ISO 8601 date-time string of the earliest time the call can be scheduled.
        /// </param>
        /// <param name="latestAt">
        /// This is the ISO 8601 date-time string of the latest time the call can be scheduled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchedulePlan(
            global::System.DateTime earliestAt,
            global::System.DateTime? latestAt)
        {
            this.EarliestAt = earliestAt;
            this.LatestAt = latestAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulePlan" /> class.
        /// </summary>
        public SchedulePlan()
        {
        }
    }
}