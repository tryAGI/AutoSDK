//HintName: G.Models.ToolUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolUpdate
    {
        /// <summary>
        /// The description of the tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Metadata tags.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// The source code of the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_code")]
        public string? SourceCode { get; set; }

        /// <summary>
        /// The type of the source code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_type")]
        public string? SourceType { get; set; }

        /// <summary>
        /// The JSON schema of the function (auto-generated from source_code if not provided)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("json_schema")]
        public object? JsonSchema { get; set; }

        /// <summary>
        /// The args JSON schema of the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("args_json_schema")]
        public object? ArgsJsonSchema { get; set; }

        /// <summary>
        /// The maximum number of characters in the response.
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
        /// A dictionary of additional metadata for the tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata_")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Whether or not to require approval before executing this tool.
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolUpdate" /> class.
        /// </summary>
        /// <param name="description">
        /// The description of the tool.
        /// </param>
        /// <param name="tags">
        /// Metadata tags.
        /// </param>
        /// <param name="sourceCode">
        /// The source code of the function.
        /// </param>
        /// <param name="sourceType">
        /// The type of the source code.
        /// </param>
        /// <param name="jsonSchema">
        /// The JSON schema of the function (auto-generated from source_code if not provided)
        /// </param>
        /// <param name="argsJsonSchema">
        /// The args JSON schema of the function.
        /// </param>
        /// <param name="returnCharLimit">
        /// The maximum number of characters in the response.
        /// </param>
        /// <param name="pipRequirements">
        /// Optional list of pip packages required by this tool.
        /// </param>
        /// <param name="npmRequirements">
        /// Optional list of npm packages required by this tool.
        /// </param>
        /// <param name="metadata">
        /// A dictionary of additional metadata for the tool.
        /// </param>
        /// <param name="defaultRequiresApproval">
        /// Whether or not to require approval before executing this tool.
        /// </param>
        /// <param name="enableParallelExecution">
        /// If set to True, then this tool will potentially be executed concurrently with other tools. Default False.<br/>
        /// Default Value: false
        /// </param>
        public ToolUpdate(
            string? description,
            global::System.Collections.Generic.IList<string>? tags,
            string? sourceCode,
            string? sourceType,
            object? jsonSchema,
            object? argsJsonSchema,
            int? returnCharLimit,
            global::System.Collections.Generic.IList<global::G.PipRequirement>? pipRequirements,
            global::System.Collections.Generic.IList<global::G.NpmRequirement>? npmRequirements,
            object? metadata,
            bool? defaultRequiresApproval,
            bool? enableParallelExecution)
        {
            this.Description = description;
            this.Tags = tags;
            this.SourceCode = sourceCode;
            this.SourceType = sourceType;
            this.JsonSchema = jsonSchema;
            this.ArgsJsonSchema = argsJsonSchema;
            this.ReturnCharLimit = returnCharLimit;
            this.PipRequirements = pipRequirements;
            this.NpmRequirements = npmRequirements;
            this.Metadata = metadata;
            this.DefaultRequiresApproval = defaultRequiresApproval;
            this.EnableParallelExecution = enableParallelExecution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolUpdate" /> class.
        /// </summary>
        public ToolUpdate()
        {
        }
    }
}