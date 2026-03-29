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
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Timestamp { get; set; } = default!;

        /// <summary>
        /// Timestamp of the metric entry in Unix time (seconds since epoch)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestampUnix", Required = global::Newtonsoft.Json.Required.Always)]
        public long TimestampUnix { get; set; } = default!;

        /// <summary>
        /// The number of concurrent sandboxes for the team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("concurrentSandboxes", Required = global::Newtonsoft.Json.Required.Always)]
        public int ConcurrentSandboxes { get; set; } = default!;

        /// <summary>
        /// Number of sandboxes started per second
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sandboxStartRate", Required = global::Newtonsoft.Json.Required.Always)]
        public float SandboxStartRate { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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