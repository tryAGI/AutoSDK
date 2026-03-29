//HintName: G.Models.TemplateLegacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplateLegacy
    {
        /// <summary>
        /// Identifier of the template
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("templateID", Required = global::Newtonsoft.Json.Required.Always)]
        public string TemplateID { get; set; } = default!;

        /// <summary>
        /// Identifier of the last successful build for given template
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("buildID", Required = global::Newtonsoft.Json.Required.Always)]
        public string BuildID { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("diskSizeMB", Required = global::Newtonsoft.Json.Required.Always)]
        public int DiskSizeMB { get; set; } = default!;

        /// <summary>
        /// Whether the template is public or only accessible by the team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Public { get; set; } = default!;

        /// <summary>
        /// Aliases of the template
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aliases", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Aliases { get; set; } = default!;

        /// <summary>
        /// Time when the template was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Time when the template was last updated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdBy")]
        public global::G.TeamUser? CreatedBy { get; set; }

        /// <summary>
        /// Time when the template was last used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastSpawnedAt")]
        public global::System.DateTime? LastSpawnedAt { get; set; }

        /// <summary>
        /// Number of times the template was used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spawnCount", Required = global::Newtonsoft.Json.Required.Always)]
        public long SpawnCount { get; set; } = default!;

        /// <summary>
        /// Number of times the template was built
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("buildCount", Required = global::Newtonsoft.Json.Required.Always)]
        public int BuildCount { get; set; } = default!;

        /// <summary>
        /// Version of the envd running in the sandbox
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("envdVersion", Required = global::Newtonsoft.Json.Required.Always)]
        public string EnvdVersion { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateLegacy" /> class.
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
        /// <param name="createdBy"></param>
        /// <param name="lastSpawnedAt">
        /// Time when the template was last used
        /// </param>
        public TemplateLegacy(
            string templateID,
            string buildID,
            int cpuCount,
            int memoryMB,
            int diskSizeMB,
            bool @public,
            global::System.Collections.Generic.IList<string> aliases,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            long spawnCount,
            int buildCount,
            string envdVersion,
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
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CreatedBy = createdBy;
            this.LastSpawnedAt = lastSpawnedAt;
            this.SpawnCount = spawnCount;
            this.BuildCount = buildCount;
            this.EnvdVersion = envdVersion ?? throw new global::System.ArgumentNullException(nameof(envdVersion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateLegacy" /> class.
        /// </summary>
        public TemplateLegacy()
        {
        }
    }
}