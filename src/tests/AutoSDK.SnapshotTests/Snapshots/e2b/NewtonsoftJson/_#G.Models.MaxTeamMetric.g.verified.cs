//HintName: G.Models.MaxTeamMetric.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Team metric with timestamp
    /// </summary>
    public sealed partial class MaxTeamMetric
    {
        /// <summary>
        /// Timestamp of the metric entry
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Timestamp { get; set; } = default!;

        /// <summary>
        /// Timestamp of the metric entry in Unix time (seconds since epoch)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestampUnix", Required = global::Newtonsoft.Json.Required.Always)]
        public long TimestampUnix { get; set; } = default!;

        /// <summary>
        /// The maximum value of the requested metric in the given interval
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MaxTeamMetric" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Timestamp of the metric entry
        /// </param>
        /// <param name="timestampUnix">
        /// Timestamp of the metric entry in Unix time (seconds since epoch)
        /// </param>
        /// <param name="value">
        /// The maximum value of the requested metric in the given interval
        /// </param>
        public MaxTeamMetric(
            global::System.DateTime timestamp,
            long timestampUnix,
            double value)
        {
            this.Timestamp = timestamp;
            this.TimestampUnix = timestampUnix;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MaxTeamMetric" /> class.
        /// </summary>
        public MaxTeamMetric()
        {
        }
    }
}