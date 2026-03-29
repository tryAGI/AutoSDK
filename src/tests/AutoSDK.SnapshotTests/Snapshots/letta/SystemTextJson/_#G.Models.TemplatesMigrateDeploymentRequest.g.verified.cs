//HintName: G.Models.TemplatesMigrateDeploymentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesMigrateDeploymentRequest
    {
        /// <summary>
        /// The target template version to migrate to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Whether to preserve existing tool variables during migration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_tool_variables")]
        public bool? PreserveToolVariables { get; set; }

        /// <summary>
        /// Whether to preserve existing core memories during migration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_core_memories")]
        public bool? PreserveCoreMemories { get; set; }

        /// <summary>
        /// If true, existing agent sources will be preserved and merged with template sources during migration. If false, agent sources will be replaced with template sources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_sources")]
        public bool? PreserveSources { get; set; }

        /// <summary>
        /// Additional memory variables to apply during migration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? MemoryVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesMigrateDeploymentRequest" /> class.
        /// </summary>
        /// <param name="version">
        /// The target template version to migrate to
        /// </param>
        /// <param name="preserveToolVariables">
        /// Whether to preserve existing tool variables during migration
        /// </param>
        /// <param name="preserveCoreMemories">
        /// Whether to preserve existing core memories during migration
        /// </param>
        /// <param name="preserveSources">
        /// If true, existing agent sources will be preserved and merged with template sources during migration. If false, agent sources will be replaced with template sources.
        /// </param>
        /// <param name="memoryVariables">
        /// Additional memory variables to apply during migration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplatesMigrateDeploymentRequest(
            string version,
            bool? preserveToolVariables,
            bool? preserveCoreMemories,
            bool? preserveSources,
            global::System.Collections.Generic.Dictionary<string, string>? memoryVariables)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.PreserveToolVariables = preserveToolVariables;
            this.PreserveCoreMemories = preserveCoreMemories;
            this.PreserveSources = preserveSources;
            this.MemoryVariables = memoryVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesMigrateDeploymentRequest" /> class.
        /// </summary>
        public TemplatesMigrateDeploymentRequest()
        {
        }
    }
}