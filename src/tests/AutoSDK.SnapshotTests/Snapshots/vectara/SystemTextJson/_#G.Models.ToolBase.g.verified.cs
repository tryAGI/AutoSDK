//HintName: G.Models.ToolBase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base properties shared by all tool types.
    /// </summary>
    public sealed partial class ToolBase
    {
        /// <summary>
        /// Unique identifier for a tool.<br/>
        /// Example: tol_123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>tol_123e4567-e89b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Unique identifier for the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Human-readable title of the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// A detailed description of what the tool does and how it can be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Velocity template for generating dynamic tool descriptions. When set, this template is rendered at runtime to produce the tool description.<br/>
        /// Available Velocity variables:<br/>
        /// - `$agent.name` - Agent name<br/>
        /// - `$agent.metadata` - Agent metadata map<br/>
        /// - `$session.key` - Session key<br/>
        /// - `$session.metadata` - Session metadata map<br/>
        /// - `$currentDate` - Current date/time in ISO 8601 format (e.g., "2025-10-24T15:30:45Z")<br/>
        /// Example: "Search tool configured for agent $agent.name on $currentDate"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description_template")]
        public string? DescriptionTemplate { get; set; }

        /// <summary>
        /// Whether the tool is currently enabled and available for use.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Timestamp when the tool was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the tool was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The schema that defines the expected input structure for the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object InputSchema { get; set; }

        /// <summary>
        /// Functional category of the tool (e.g., retrieval, artifacts, indexing, utilities, orchestration).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public string? Category { get; set; }

        /// <summary>
        /// The base tool name without version suffix. Groups versioned variants of the same tool together.<br/>
        /// Example: corpora_search
        /// </summary>
        /// <example>corpora_search</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lineage")]
        public string? Lineage { get; set; }

        /// <summary>
        /// Date-based version identifier in YYYY-MM-DD format. Null for unversioned tools.<br/>
        /// Example: 2026-02-23
        /// </summary>
        /// <example>2026-02-23</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Groups this tool belongs to. Tools in the same group form a functional set and should be added or removed together by default.<br/>
        /// Example: [document_ingestion]
        /// </summary>
        /// <example>[document_ingestion]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_groups")]
        public global::System.Collections.Generic.IList<string>? ToolGroups { get; set; }

        /// <summary>
        /// The permissions that will be granted to the agent's dedicated service account when this tool is added to an agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::G.ToolPermissions? Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolBase" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for a tool.<br/>
        /// Example: tol_123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="name">
        /// Unique identifier for the tool.
        /// </param>
        /// <param name="title">
        /// Human-readable title of the tool.
        /// </param>
        /// <param name="description">
        /// A detailed description of what the tool does and how it can be used.
        /// </param>
        /// <param name="descriptionTemplate">
        /// Velocity template for generating dynamic tool descriptions. When set, this template is rendered at runtime to produce the tool description.<br/>
        /// Available Velocity variables:<br/>
        /// - `$agent.name` - Agent name<br/>
        /// - `$agent.metadata` - Agent metadata map<br/>
        /// - `$session.key` - Session key<br/>
        /// - `$session.metadata` - Session metadata map<br/>
        /// - `$currentDate` - Current date/time in ISO 8601 format (e.g., "2025-10-24T15:30:45Z")<br/>
        /// Example: "Search tool configured for agent $agent.name on $currentDate"
        /// </param>
        /// <param name="enabled">
        /// Whether the tool is currently enabled and available for use.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the tool was created.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the tool was last updated.
        /// </param>
        /// <param name="inputSchema">
        /// The schema that defines the expected input structure for the tool.
        /// </param>
        /// <param name="category">
        /// Functional category of the tool (e.g., retrieval, artifacts, indexing, utilities, orchestration).
        /// </param>
        /// <param name="lineage">
        /// The base tool name without version suffix. Groups versioned variants of the same tool together.<br/>
        /// Example: corpora_search
        /// </param>
        /// <param name="version">
        /// Date-based version identifier in YYYY-MM-DD format. Null for unversioned tools.<br/>
        /// Example: 2026-02-23
        /// </param>
        /// <param name="toolGroups">
        /// Groups this tool belongs to. Tools in the same group form a functional set and should be added or removed together by default.<br/>
        /// Example: [document_ingestion]
        /// </param>
        /// <param name="permissions">
        /// The permissions that will be granted to the agent's dedicated service account when this tool is added to an agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolBase(
            string id,
            string name,
            string description,
            bool enabled,
            object inputSchema,
            string? title,
            string? descriptionTemplate,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? category,
            string? lineage,
            string? version,
            global::System.Collections.Generic.IList<string>? toolGroups,
            global::G.ToolPermissions? permissions)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Enabled = enabled;
            this.InputSchema = inputSchema ?? throw new global::System.ArgumentNullException(nameof(inputSchema));
            this.Title = title;
            this.DescriptionTemplate = descriptionTemplate;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Category = category;
            this.Lineage = lineage;
            this.Version = version;
            this.ToolGroups = toolGroups;
            this.Permissions = permissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolBase" /> class.
        /// </summary>
        public ToolBase()
        {
        }
    }
}