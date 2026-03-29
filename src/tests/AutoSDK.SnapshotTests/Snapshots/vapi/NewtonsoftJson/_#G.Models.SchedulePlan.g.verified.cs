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
        [global::Newtonsoft.Json.JsonProperty("earliestAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime EarliestAt { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of the latest time the call can be scheduled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latestAt")]
        public global::System.DateTime? LatestAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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