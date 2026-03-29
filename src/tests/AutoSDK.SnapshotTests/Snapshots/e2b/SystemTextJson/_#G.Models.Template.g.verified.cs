//HintName: G.Models.Template.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Template
    {
        /// <summary>
        /// Identifier of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateID { get; set; }

        /// <summary>
        /// Identifier of the last successful build for given template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BuildID { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DiskSizeMB { get; set; }

        /// <summary>
        /// Whether the template is public or only accessible by the team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Public { get; set; }

        /// <summary>
        /// Aliases of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Aliases { get; set; }

        /// <summary>
        /// Names of the template (namespace/alias format when namespaced)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Names { get; set; }

        /// <summary>
        /// Time when the template was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Time when the template was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public global::G.TeamUser? CreatedBy { get; set; }

        /// <summary>
        /// Time when the template was last used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastSpawnedAt")]
        public global::System.DateTime? LastSpawnedAt { get; set; }

        /// <summary>
        /// Number of times the template was used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spawnCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SpawnCount { get; set; }

        /// <summary>
        /// Number of times the template was built
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BuildCount { get; set; }

        /// <summary>
        /// Version of the envd running in the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("envdVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvdVersion { get; set; }

        /// <summary>
        /// Status of the template build
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TemplateBuildStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TemplateBuildStatus BuildStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Template" /> class.
        /// </summary>
        /// <param name="templateID">
        /// Identifier of the template
        /// </param>
        /// <param name="buildID">
        /// Identifier of the last successful build for given template
        /// </param>
        /// <param name="cpuCount">
        /// CPU cores for the sandbox
        /// </param>
        /// <param name="memoryMB">
        /// Memory for the sandbox in MiB
        /// </param>
        /// <param name="diskSizeMB">
        /// Disk size for the sandbox in MiB
        /// </param>
        /// <param name="public">
        /// Whether the template is public or only accessible by the team
        /// </param>
        /// <param name="aliases">
        /// Aliases of the template
        /// </param>
        /// <param name="names">
        /// Names of the template (namespace/alias format when namespaced)
        /// </param>
        /// <param name="createdAt">
        /// Time when the template was created
        /// </param>
        /// <param name="updatedAt">
        /// Time when the template was last updated
        /// </param>
        /// <param name="spawnCount">
        /// Number of times the template was used
        /// </param>
        /// <param name="buildCount">
        /// Number of times the template was built
        /// </param>
        /// <param name="envdVersion">
        /// Version of the envd running in the sandbox
        /// </param>
        /// <param name="buildStatus">
        /// Status of the template build
        /// </param>
        /// <param name="createdBy"></param>
        /// <param name="lastSpawnedAt">
        /// Time when the template was last used
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Template(
            string templateID,
            string buildID,
            int cpuCount,
            int memoryMB,
            int diskSizeMB,
            bool @public,
            global::System.Collections.Generic.IList<string> aliases,
            global::System.Collections.Generic.IList<string> names,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            long spawnCount,
            int buildCount,
            string envdVersion,
            global::G.TemplateBuildStatus buildStatus,
            global::G.TeamUser? createdBy,
            global::System.DateTime? lastSpawnedAt)
        {
            this.TemplateID = templateID ?? throw new global::System.ArgumentNullException(nameof(templateID));
            this.BuildID = buildID ?? throw new global::System.ArgumentNullException(nameof(buildID));
            this.CpuCount = cpuCount;
            this.MemoryMB = memoryMB;
            this.DiskSizeMB = diskSizeMB;
            this.Public = @public;
            this.Aliases = aliases ?? throw new global::System.ArgumentNullException(nameof(aliases));
            this.Names = names ?? throw new global::System.ArgumentNullException(nameof(names));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CreatedBy = createdBy;
            this.LastSpawnedAt = lastSpawnedAt;
            this.SpawnCount = spawnCount;
            this.BuildCount = buildCount;
            this.EnvdVersion = envdVersion ?? throw new global::System.ArgumentNullException(nameof(envdVersion));
            this.BuildStatus = buildStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Template" /> class.
        /// </summary>
        public Template()
        {
        }
    }
}