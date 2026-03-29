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
        /// Number of CPU cores
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpuCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CpuCount { get; set; }

        /// <summary>
        /// CPU usage percentage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpuUsedPct")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float CpuUsedPct { get; set; }

        /// <summary>
        /// Memory used in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memUsed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long MemUsed { get; set; }

        /// <summary>
        /// Total memory in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memTotal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long MemTotal { get; set; }

        /// <summary>
        /// Disk used in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diskUsed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long DiskUsed { get; set; }

        /// <summary>
        /// Total disk space in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diskTotal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long DiskTotal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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