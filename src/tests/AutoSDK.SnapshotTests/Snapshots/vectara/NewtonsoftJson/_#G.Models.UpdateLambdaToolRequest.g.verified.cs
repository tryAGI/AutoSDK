//HintName: G.Models.UpdateLambdaToolRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to update a lambda tool, allowing modifications to code, configuration, and metadata.<br/>
    /// When code is updated, input and output schemas are automatically re-discovered from function parameter type annotations.
    /// </summary>
    public sealed partial class UpdateLambdaToolRequest
    {
        /// <summary>
        /// This should always be `lambda`.<br/>
        /// Default Value: lambda<br/>
        /// Example: lambda
        /// </summary>
        /// <default>"lambda"</default>
        /// <example>lambda</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Whether the tool should be enabled or disabled.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Updated user-friendly display name for the tool.<br/>
        /// Example: Updated Calculator Tool
        /// </summary>
        /// <example>Updated Calculator Tool</example>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Updated description of what the tool does.<br/>
        /// Example: An updated tool that performs advanced calculations
        /// </summary>
        /// <example>An updated tool that performs advanced calculations</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Updated code for the lambda function. Use function parameter type annotations for automatic schema discovery.<br/>
        /// Object parameters must use `TypedDict`; bare `dict` and `Dict[K, V]` parameters are rejected.<br/>
        /// See the `code` field on `CreateLambdaToolRequest` for full details and examples.<br/>
        /// Example: def process(value: float) -&gt; dict:<br/>
        ///     return {"result": value * 2}
        /// </summary>
        /// <example>
        /// def process(value: float) -&gt; dict:<br/>
        ///     return {"result": value * 2}
        /// </example>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Execution configuration for the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_configuration")]
        public global::G.ExecutionConfiguration? ExecutionConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLambdaToolRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `lambda`.<br/>
        /// Default Value: lambda<br/>
        /// Example: lambda
        /// </param>
        /// <param name="enabled">
        /// Whether the tool should be enabled or disabled.<br/>
        /// Example: true
        /// </param>
        /// <param name="title">
        /// Updated user-friendly display name for the tool.<br/>
        /// Example: Updated Calculator Tool
        /// </param>
        /// <param name="description">
        /// Updated description of what the tool does.<br/>
        /// Example: An updated tool that performs advanced calculations
        /// </param>
        /// <param name="code">
        /// Updated code for the lambda function. Use function parameter type annotations for automatic schema discovery.<br/>
        /// Object parameters must use `TypedDict`; bare `dict` and `Dict[K, V]` parameters are rejected.<br/>
        /// See the `code` field on `CreateLambdaToolRequest` for full details and examples.<br/>
        /// Example: def process(value: float) -&gt; dict:<br/>
        ///     return {"result": value * 2}
        /// </param>
        /// <param name="executionConfiguration">
        /// Execution configuration for the function.
        /// </param>
        public UpdateLambdaToolRequest(
            string type,
            bool? enabled,
            string? title,
            string? description,
            string? code,
            global::G.ExecutionConfiguration? executionConfiguration)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Enabled = enabled;
            this.Title = title;
            this.Description = description;
            this.Code = code;
            this.ExecutionConfiguration = executionConfiguration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLambdaToolRequest" /> class.
        /// </summary>
        public UpdateLambdaToolRequest()
        {
        }
    }
}