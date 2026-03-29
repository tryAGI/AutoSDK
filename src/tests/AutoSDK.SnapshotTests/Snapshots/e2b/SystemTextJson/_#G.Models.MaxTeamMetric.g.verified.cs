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
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// Timestamp of the metric entry in Unix time (seconds since epoch)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestampUnix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long TimestampUnix { get; set; }

        /// <summary>
        /// The maximum value of the requested metric in the given interval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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