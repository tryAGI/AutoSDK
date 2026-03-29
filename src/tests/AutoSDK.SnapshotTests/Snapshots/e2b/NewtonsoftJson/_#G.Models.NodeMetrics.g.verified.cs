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
        [global::Newtonsoft.Json.JsonProperty("allocatedCPU", Required = global::Newtonsoft.Json.Required.Always)]
        public int AllocatedCPU { get; set; } = default!;

        /// <summary>
        /// Node CPU usage percentage
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cpuPercent", Required = global::Newtonsoft.Json.Required.Always)]
        public int CpuPercent { get; set; } = default!;

        /// <summary>
        /// Total number of CPU cores on the node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cpuCount", Required = global::Newtonsoft.Json.Required.Always)]
        public int CpuCount { get; set; } = default!;

        /// <summary>
        /// Amount of allocated memory in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allocatedMemoryBytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int AllocatedMemoryBytes { get; set; } = default!;

        /// <summary>
        /// Node memory used in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memoryUsedBytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int MemoryUsedBytes { get; set; } = default!;

        /// <summary>
        /// Total node memory in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memoryTotalBytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int MemoryTotalBytes { get; set; } = default!;

        /// <summary>
        /// Detailed metrics for each disk/mount point
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DiskMetrics> Disks { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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