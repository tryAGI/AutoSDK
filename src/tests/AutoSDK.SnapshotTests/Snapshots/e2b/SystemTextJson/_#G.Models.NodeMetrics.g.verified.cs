//HintName: G.Models.NodeMetrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Node metrics
    /// </summary>
    public sealed partial class NodeMetrics
    {
        /// <summary>
        /// Number of allocated CPU cores
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allocatedCPU")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AllocatedCPU { get; set; }

        /// <summary>
        /// Node CPU usage percentage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpuPercent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CpuPercent { get; set; }

        /// <summary>
        /// Total number of CPU cores on the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpuCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CpuCount { get; set; }

        /// <summary>
        /// Amount of allocated memory in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allocatedMemoryBytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AllocatedMemoryBytes { get; set; }

        /// <summary>
        /// Node memory used in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoryUsedBytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MemoryUsedBytes { get; set; }

        /// <summary>
        /// Total node memory in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoryTotalBytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MemoryTotalBytes { get; set; }

        /// <summary>
        /// Detailed metrics for each disk/mount point
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.DiskMetrics> Disks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeMetrics" /> class.
        /// </summary>
        /// <param name="allocatedCPU">
        /// Number of allocated CPU cores
        /// </param>
        /// <param name="cpuPercent">
        /// Node CPU usage percentage
        /// </param>
        /// <param name="cpuCount">
        /// Total number of CPU cores on the node
        /// </param>
        /// <param name="allocatedMemoryBytes">
        /// Amount of allocated memory in bytes
        /// </param>
        /// <param name="memoryUsedBytes">
        /// Node memory used in bytes
        /// </param>
        /// <param name="memoryTotalBytes">
        /// Total node memory in bytes
        /// </param>
        /// <param name="disks">
        /// Detailed metrics for each disk/mount point
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeMetrics(
            int allocatedCPU,
            int cpuPercent,
            int cpuCount,
            int allocatedMemoryBytes,
            int memoryUsedBytes,
            int memoryTotalBytes,
            global::System.Collections.Generic.IList<global::G.DiskMetrics> disks)
        {
            this.AllocatedCPU = allocatedCPU;
            this.CpuPercent = cpuPercent;
            this.CpuCount = cpuCount;
            this.AllocatedMemoryBytes = allocatedMemoryBytes;
            this.MemoryUsedBytes = memoryUsedBytes;
            this.MemoryTotalBytes = memoryTotalBytes;
            this.Disks = disks ?? throw new global::System.ArgumentNullException(nameof(disks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeMetrics" /> class.
        /// </summary>
        public NodeMetrics()
        {
        }
    }
}