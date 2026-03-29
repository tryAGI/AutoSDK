//HintName: G.Models.Tool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Representation of a tool, which is a function that can be called by the agent.
    /// </summary>
    public sealed partial class Tool
    {
        /// <summary>
        /// The human-friendly ID of the Tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The type of the tool.<br/>
        /// Default Value: custom
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolTypeJsonConverter))]
        public global::G.ToolType? ToolType { get; set; }

        /// <summary>
        /// The description of the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The type of the source code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        public string? SourceType { get; set; }

        /// <summary>
        /// The name of the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Metadata tags.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// The source code of the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_code")]
        public string? SourceCode { get; set; }

        /// <summary>
        /// The JSON schema of the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        public object? JsonSchema { get; set; }

        /// <summary>
        /// The args JSON schema of the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args_json_schema")]
        public object? ArgsJsonSchema { get; set; }

        /// <summary>
        /// The maximum number of characters in the response.<br/>
        /// Default Value: 50000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_char_limit")]
        public int? ReturnCharLimit { get; set; }

        /// <summary>
        /// Optional list of pip packages required by this tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pip_requirements")]
        public global::System.Collections.Generic.IList<global::G.PipRequirement>? PipRequirements { get; set; }

        /// <summary>
        /// Optional list of npm packages required by this tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("npm_requirements")]
        public global::System.Collections.Generic.IList<global::G.NpmRequirement>? NpmRequirements { get; set; }

        /// <summary>
        /// Default value for whether or not executing this tool requires approval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_requires_approval")]
        public bool? DefaultRequiresApproval { get; set; }

        /// <summary>
        /// If set to True, then this tool will potentially be executed concurrently with other tools. Default False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_parallel_execution")]
        public bool? EnableParallelExecution { get; set; }

        /// <summary>
        /// The id of the user that made this Tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_id")]
        public string? CreatedById { get; set; }

        /// <summary>
        /// The id of the user that made this Tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_by_id")]
        public string? LastUpdatedById { get; set; }

        /// <summary>
        /// A dictionary of additional metadata for the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The project id of the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Tool" /> class.
        /// </summary>
        /// <param name="id">
        /// The human-friendly ID of the Tool
        /// </param>
        /// <param name="toolType">
        /// The type of the tool.<br/>
        /// Default Value: custom
        /// </param>
        /// <param name="description">
        /// The description of the tool.
        /// </param>
        /// <param name="sourceType">
        /// The type of the source code.
        /// </param>
        /// <param name="name">
        /// The name of the function.
        /// </param>
        /// <param name="tags">
        /// Metadata tags.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="sourceCode">
        /// The source code of the function.
        /// </param>
        /// <param name="jsonSchema">
        /// The JSON schema of the function.
        /// </param>
        /// <param name="argsJsonSchema">
        /// The args JSON schema of the function.
        /// </param>
        /// <param name="returnCharLimit">
        /// The maximum number of characters in the response.<br/>
        /// Default Value: 50000
        /// </param>
        /// <param name="pipRequirements">
        /// Optional list of pip packages required by this tool.
        /// </param>
        /// <param name="npmRequirements">
        /// Optional list of npm packages required by this tool.
        /// </param>
        /// <param name="defaultRequiresApproval">
        /// Default value for whether or not executing this tool requires approval.
        /// </param>
        /// <param name="enableParallelExecution">
        /// If set to True, then this tool will potentially be executed concurrently with other tools. Default False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="createdById">
        /// The id of the user that made this Tool.
        /// </param>
        /// <param name="lastUpdatedById">
        /// The id of the user that made this Tool.
        /// </param>
        /// <param name="metadata">
        /// A dictionary of additional metadata for the tool.
        /// </param>
        /// <param name="projectId">
        /// The project id of the tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Tool(
            string? id,
            global::G.ToolType? toolType,
            string? description,
            string? sourceType,
            string? name,
            global::System.Collections.Generic.IList<string>? tags,
            string? sourceCode,
            object? jsonSchema,
            object? argsJsonSchema,
            int? returnCharLimit,
            global::System.Collections.Generic.IList<global::G.PipRequirement>? pipRequirements,
            global::System.Collections.Generic.IList<global::G.NpmRequirement>? npmRequirements,
            bool? defaultRequiresApproval,
            bool? enableParallelExecution,
            string? createdById,
            string? lastUpdatedById,
            object? metadata,
            string? projectId)
        {
            this.Id = id;
            this.ToolType = toolType;
            this.Description = description;
            this.SourceType = sourceType;
            this.Name = name;
            this.Tags = tags;
            this.SourceCode = sourceCode;
            this.JsonSchema = jsonSchema;
            this.ArgsJsonSchema = argsJsonSchema;
            this.ReturnCharLimit = returnCharLimit;
            this.PipRequirements = pipRequirements;
            this.NpmRequirements = npmRequirements;
            this.DefaultRequiresApproval = defaultRequiresApproval;
            this.EnableParallelExecution = enableParallelExecution;
            this.CreatedById = createdById;
            this.LastUpdatedById = lastUpdatedById;
            this.Metadata = metadata;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tool" /> class.
        /// </summary>
        public Tool()
        {
        }
    }
}