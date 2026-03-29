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
        [global::System.Text.Json.Serialization.JsonPropertyName("buildID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid BuildID { get; set; }

        /// <summary>
        /// Status of the template build
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TemplateBuildStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TemplateBuildStatus Status { get; set; }

        /// <summary>
        /// Time when the build was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Time when the build was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Time when the build was finished
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finishedAt")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// CPU cores for the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpuCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CpuCount { get; set; }

        /// <summary>
        /// Memory for the sandbox in MiB
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoryMB")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MemoryMB { get; set; }

        /// <summary>
        /// Disk size for the sandbox in MiB
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diskSizeMB")]
        public int? DiskSizeMB { get; set; }

        /// <summary>
        /// Version of the envd running in the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("envdVersion")]
        public string? EnvdVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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