//HintName: G.Models.LettaSchemasAgentFileToolSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tool with human-readable ID for agent file
    /// </summary>
    public sealed partial class LettaSchemasAgentFileToolSchema
    {
        /// <summary>
        /// Human-readable identifier for this tool in the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The type of the tool.<br/>
        /// Default Value: custom
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_type")]
        public global::G.ToolType? ToolType { get; set; }

        /// <summary>
        /// The description of the tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The type of the source code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_type")]
        public string? SourceType { get; set; }

        /// <summary>
        /// The name of the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Metadata tags.<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// The source code of the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_code")]
        public string? SourceCode { get; set; }

        /// <summary>
        /// The JSON schema of the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("json_schema")]
        public object? JsonSchema { get; set; }

        /// <summary>
        /// The args JSON schema of the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("args_json_schema")]
        public object? ArgsJsonSchema { get; set; }

        /// <summary>
        /// The maximum number of characters in the response.<br/>
        /// Default Value: 50000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("return_char_limit")]
        public int? ReturnCharLimit { get; set; }

        /// <summary>
        /// Optional list of pip packages required by this tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pip_requirements")]
        public global::System.Collections.Generic.IList<global::G.PipRequirement>? PipRequirements { get; set; }

        /// <summary>
        /// Optional list of npm packages required by this tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("npm_requirements")]
        public global::System.Collections.Generic.IList<global::G.NpmRequirement>? NpmRequirements { get; set; }

        /// <summary>
        /// Default value for whether or not executing this tool requires approval.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_requires_approval")]
        public bool? DefaultRequiresApproval { get; set; }

        /// <summary>
        /// If set to True, then this tool will potentially be executed concurrently with other tools. Default False.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_parallel_execution")]
        public bool? EnableParallelExecution { get; set; }

        /// <summary>
        /// The id of the user that made this Tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by_id")]
        public string? CreatedById { get; set; }

        /// <summary>
        /// The id of the user that made this Tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_by_id")]
        public string? LastUpdatedById { get; set; }

        /// <summary>
        /// A dictionary of additional metadata for the tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata_")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The project id of the tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasAgentFileToolSchema" /> class.
        /// </summary>
        /// <param name="id">
        /// Human-readable identifier for this tool in the file
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
        public LettaSchemasAgentFileToolSchema(
            string id,
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
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
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
        /// Initializes a new instance of the <see cref="LettaSchemasAgentFileToolSchema" /> class.
        /// </summary>
        public LettaSchemasAgentFileToolSchema()
        {
        }
    }
}