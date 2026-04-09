//HintName: G.Models.TemplateBuild.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplateBuild
    {
        /// <summary>
        /// Identifier of the build
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("buildID", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid BuildID { get; set; } = default!;

        /// <summary>
        /// Status of the template build
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TemplateBuildStatusJsonConverter))]
        public global::G.TemplateBuildStatus Status { get; set; } = default!;

        /// <summary>
        /// Time when the build was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Time when the build was last updated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Time when the build was finished
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finishedAt")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// CPU cores for the sandbox
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cpuCount", Required = global::Newtonsoft.Json.Required.Always)]
        public int CpuCount { get; set; } = default!;

        /// <summary>
        /// Memory for the sandbox in MiB
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memoryMB", Required = global::Newtonsoft.Json.Required.Always)]
        public int MemoryMB { get; set; } = default!;

        /// <summary>
        /// Disk size for the sandbox in MiB
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("diskSizeMB")]
        public int? DiskSizeMB { get; set; }

        /// <summary>
        /// Version of the envd running in the sandbox
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("envdVersion")]
        public string? EnvdVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateBuild" /> class.
        /// </summary>
        /// <param name="buildID">
        /// Identifier of the build
        /// </param>
        /// <param name="status">
        /// Status of the template build
        /// </param>
        /// <param name="createdAt">
        /// Time when the build was created
        /// </param>
        /// <param name="updatedAt">
        /// Time when the build was last updated
        /// </param>
        /// <param name="cpuCount">
        /// CPU cores for the sandbox
        /// </param>
        /// <param name="memoryMB">
        /// Memory for the sandbox in MiB
        /// </param>
        /// <param name="finishedAt">
        /// Time when the build was finished
        /// </param>
        /// <param name="diskSizeMB">
        /// Disk size for the sandbox in MiB
        /// </param>
        /// <param name="envdVersion">
        /// Version of the envd running in the sandbox
        /// </param>
        public TemplateBuild(
            global::System.Guid buildID,
            global::G.TemplateBuildStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            int cpuCount,
            int memoryMB,
            global::System.DateTime? finishedAt,
            int? diskSizeMB,
            string? envdVersion)
        {
            this.BuildID = buildID;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.FinishedAt = finishedAt;
            this.CpuCount = cpuCount;
            this.MemoryMB = memoryMB;
            this.DiskSizeMB = diskSizeMB;
            this.EnvdVersion = envdVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateBuild" /> class.
        /// </summary>
        public TemplateBuild()
        {
        }
    }
}