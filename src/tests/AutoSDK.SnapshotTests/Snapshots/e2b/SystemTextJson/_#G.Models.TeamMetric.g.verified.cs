//HintName: G.Models.TeamMetric.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Team metric with timestamp
    /// </summary>
    public sealed partial class TeamMetric
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
        /// The number of concurrent sandboxes for the team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrentSandboxes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConcurrentSandboxes { get; set; }

        /// <summary>
        /// Number of sandboxes started per second
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxStartRate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float SandboxStartRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMetric" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Timestamp of the metric entry
        /// </param>
        /// <param name="timestampUnix">
        /// Timestamp of the metric entry in Unix time (seconds since epoch)
        /// </param>
        /// <param name="concurrentSandboxes">
        /// The number of concurrent sandboxes for the team
        /// </param>
        /// <param name="sandboxStartRate">
        /// Number of sandboxes started per second
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamMetric(
            global::System.DateTime timestamp,
            long timestampUnix,
            int concurrentSandboxes,
            float sandboxStartRate)
        {
            this.Timestamp = timestamp;
            this.TimestampUnix = timestampUnix;
            this.ConcurrentSandboxes = concurrentSandboxes;
            this.SandboxStartRate = sandboxStartRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMetric" /> class.
        /// </summary>
        public TeamMetric()
        {
        }
    }
}