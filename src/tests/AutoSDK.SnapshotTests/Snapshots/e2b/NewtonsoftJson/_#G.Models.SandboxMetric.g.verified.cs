//HintName: G.Models.SandboxMetric.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Metric entry with timestamp and line
    /// </summary>
    public sealed partial class SandboxMetric
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
        /// Number of CPU cores
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cpuCount", Required = global::Newtonsoft.Json.Required.Always)]
        public int CpuCount { get; set; } = default!;

        /// <summary>
        /// CPU usage percentage
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cpuUsedPct", Required = global::Newtonsoft.Json.Required.Always)]
        public float CpuUsedPct { get; set; } = default!;

        /// <summary>
        /// Memory used in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memUsed", Required = global::Newtonsoft.Json.Required.Always)]
        public long MemUsed { get; set; } = default!;

        /// <summary>
        /// Total memory in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memTotal", Required = global::Newtonsoft.Json.Required.Always)]
        public long MemTotal { get; set; } = default!;

        /// <summary>
        /// Disk used in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("diskUsed", Required = global::Newtonsoft.Json.Required.Always)]
        public long DiskUsed { get; set; } = default!;

        /// <summary>
        /// Total disk space in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("diskTotal", Required = global::Newtonsoft.Json.Required.Always)]
        public long DiskTotal { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxMetric" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Timestamp of the metric entry
        /// </param>
        /// <param name="timestampUnix">
        /// Timestamp of the metric entry in Unix time (seconds since epoch)
        /// </param>
        /// <param name="cpuCount">
        /// Number of CPU cores
        /// </param>
        /// <param name="cpuUsedPct">
        /// CPU usage percentage
        /// </param>
        /// <param name="memUsed">
        /// Memory used in bytes
        /// </param>
        /// <param name="memTotal">
        /// Total memory in bytes
        /// </param>
        /// <param name="diskUsed">
        /// Disk used in bytes
        /// </param>
        /// <param name="diskTotal">
        /// Total disk space in bytes
        /// </param>
        public SandboxMetric(
            global::System.DateTime timestamp,
            long timestampUnix,
            int cpuCount,
            float cpuUsedPct,
            long memUsed,
            long memTotal,
            long diskUsed,
            long diskTotal)
        {
            this.Timestamp = timestamp;
            this.TimestampUnix = timestampUnix;
            this.CpuCount = cpuCount;
            this.CpuUsedPct = cpuUsedPct;
            this.MemUsed = memUsed;
            this.MemTotal = memTotal;
            this.DiskUsed = diskUsed;
            this.DiskTotal = diskTotal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxMetric" /> class.
        /// </summary>
        public SandboxMetric()
        {
        }
    }
}