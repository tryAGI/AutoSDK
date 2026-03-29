//HintName: G.Models.ToolRunFromSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolRunFromSource
    {
        /// <summary>
        /// The source code of the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceCode { get; set; }

        /// <summary>
        /// The arguments to pass to the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Args { get; set; }

        /// <summary>
        /// The environment variables to pass to the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env_vars")]
        public global::System.Collections.Generic.Dictionary<string, string>? EnvVars { get; set; }

        /// <summary>
        /// The name of the tool to run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The type of the source code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        public string? SourceType { get; set; }

        /// <summary>
        /// The args JSON schema of the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args_json_schema")]
        public object? ArgsJsonSchema { get; set; }

        /// <summary>
        /// The JSON schema of the function (auto-generated from source_code if not provided)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        public object? JsonSchema { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRunFromSource" /> class.
        /// </summary>
        /// <param name="sourceCode">
        /// The source code of the function.
        /// </param>
        /// <param name="args">
        /// The arguments to pass to the tool.
        /// </param>
        /// <param name="envVars">
        /// The environment variables to pass to the tool.
        /// </param>
        /// <param name="name">
        /// The name of the tool to run.
        /// </param>
        /// <param name="sourceType">
        /// The type of the source code.
        /// </param>
        /// <param name="argsJsonSchema">
        /// The args JSON schema of the function.
        /// </param>
        /// <param name="jsonSchema">
        /// The JSON schema of the function (auto-generated from source_code if not provided)
        /// </param>
        /// <param name="pipRequirements">
        /// Optional list of pip packages required by this tool.
        /// </param>
        /// <param name="npmRequirements">
        /// Optional list of npm packages required by this tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolRunFromSource(
            string sourceCode,
            object args,
            global::System.Collections.Generic.Dictionary<string, string>? envVars,
            string? name,
            string? sourceType,
            object? argsJsonSchema,
            object? jsonSchema,
            global::System.Collections.Generic.IList<global::G.PipRequirement>? pipRequirements,
            global::System.Collections.Generic.IList<global::G.NpmRequirement>? npmRequirements)
        {
            this.SourceCode = sourceCode ?? throw new global::System.ArgumentNullException(nameof(sourceCode));
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
            this.EnvVars = envVars;
            this.Name = name;
            this.SourceType = sourceType;
            this.ArgsJsonSchema = argsJsonSchema;
            this.JsonSchema = jsonSchema;
            this.PipRequirements = pipRequirements;
            this.NpmRequirements = npmRequirements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRunFromSource" /> class.
        /// </summary>
        public ToolRunFromSource()
        {
        }
    }
}