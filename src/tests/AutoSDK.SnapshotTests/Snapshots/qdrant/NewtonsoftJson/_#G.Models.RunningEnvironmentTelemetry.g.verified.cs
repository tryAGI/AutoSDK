//HintName: G.Models.RunningEnvironmentTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunningEnvironmentTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("distribution")]
        public string? Distribution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("distribution_version")]
        public string? DistributionVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_docker", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsDocker { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cores")]
        public int? Cores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ram_size")]
        public int? RamSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disk_size")]
        public int? DiskSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cpu_flags", Required = global::Newtonsoft.Json.Required.Always)]
        public string CpuFlags { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cpu_endian")]
        public global::G.CpuEndian? CpuEndian { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gpu_devices")]
        public global::System.Collections.Generic.IList<global::G.GpuDeviceTelemetry>? GpuDevices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunningEnvironmentTelemetry" /> class.
        /// </summary>
        /// <param name="isDocker"></param>
        /// <param name="cpuFlags"></param>
        /// <param name="distribution"></param>
        /// <param name="distributionVersion"></param>
        /// <param name="cores"></param>
        /// <param name="ramSize"></param>
        /// <param name="diskSize"></param>
        /// <param name="cpuEndian"></param>
        /// <param name="gpuDevices"></param>
        public RunningEnvironmentTelemetry(
            bool isDocker,
            string cpuFlags,
            string? distribution,
            string? distributionVersion,
            int? cores,
            int? ramSize,
            int? diskSize,
            global::G.CpuEndian? cpuEndian,
            global::System.Collections.Generic.IList<global::G.GpuDeviceTelemetry>? gpuDevices)
        {
            this.Distribution = distribution;
            this.DistributionVersion = distributionVersion;
            this.IsDocker = isDocker;
            this.Cores = cores;
            this.RamSize = ramSize;
            this.DiskSize = diskSize;
            this.CpuFlags = cpuFlags ?? throw new global::System.ArgumentNullException(nameof(cpuFlags));
            this.CpuEndian = cpuEndian;
            this.GpuDevices = gpuDevices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunningEnvironmentTelemetry" /> class.
        /// </summary>
        public RunningEnvironmentTelemetry()
        {
        }
    }
}