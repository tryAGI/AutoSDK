//HintName: G.Models.LambdaToolVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LambdaToolVariant2
    {
        /// <summary>
        /// This should always be `lambda`.<br/>
        /// Default Value: lambda<br/>
        /// Example: lambda
        /// </summary>
        /// <default>"lambda"</default>
        /// <example>lambda</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "lambda";

        /// <summary>
        /// The programming language of the lambda function. Currently only Python 3.12 is supported.<br/>
        /// Default Value: python<br/>
        /// Example: python
        /// </summary>
        /// <default>global::G.LambdaToolVariant2Language.Python</default>
        /// <example>python</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LambdaToolVariant2LanguageJsonConverter))]
        public global::G.LambdaToolVariant2Language Language { get; set; } = global::G.LambdaToolVariant2Language.Python;

        /// <summary>
        /// The schema that defines the expected output structure from the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_schema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// Definition of a function to be executed as a tool in a sandboxed environment.<br/>
        /// **Python Environment:**<br/>
        /// - Python version: 3.12<br/>
        /// - Execution: Sandboxed using gVisor for security isolation<br/>
        /// - **Allowed modules**: `json`, `math`, `datetime`, `collections`, `itertools`, `functools`, `re`, `time`, `typing`<br/>
        /// - Memory limit: 100MB (configurable up to 1GB)<br/>
        /// - Execution timeout: 30 seconds (configurable up to 300 seconds)<br/>
        /// - Network access: Disabled for security<br/>
        /// - File system access: Read-only temporary workspace<br/>
        /// - No custom package installation supported (security constraint)<br/>
        /// **Type Annotations:**<br/>
        /// - Use type annotations for automatic input/output schema discovery<br/>
        /// - Supported typing constructs: `List`, `Dict`, `Optional`, `Union`<br/>
        /// - Import from `typing` module when using complex types<br/>
        /// **Docstring Parameter Descriptions:**<br/>
        /// - Use docstrings to provide descriptions for parameters (Google, NumPy, ReST, and Epydoc styles are supported)<br/>
        /// - Parameter descriptions are extracted and included in the input schema<br/>
        /// - This gives agents better context about how to use each parameter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FunctionDefinition FunctionDefinition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LambdaToolVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `lambda`.<br/>
        /// Default Value: lambda<br/>
        /// Example: lambda
        /// </param>
        /// <param name="language">
        /// The programming language of the lambda function. Currently only Python 3.12 is supported.<br/>
        /// Default Value: python<br/>
        /// Example: python
        /// </param>
        /// <param name="outputSchema">
        /// The schema that defines the expected output structure from the function.
        /// </param>
        /// <param name="functionDefinition">
        /// Definition of a function to be executed as a tool in a sandboxed environment.<br/>
        /// **Python Environment:**<br/>
        /// - Python version: 3.12<br/>
        /// - Execution: Sandboxed using gVisor for security isolation<br/>
        /// - **Allowed modules**: `json`, `math`, `datetime`, `collections`, `itertools`, `functools`, `re`, `time`, `typing`<br/>
        /// - Memory limit: 100MB (configurable up to 1GB)<br/>
        /// - Execution timeout: 30 seconds (configurable up to 300 seconds)<br/>
        /// - Network access: Disabled for security<br/>
        /// - File system access: Read-only temporary workspace<br/>
        /// - No custom package installation supported (security constraint)<br/>
        /// **Type Annotations:**<br/>
        /// - Use type annotations for automatic input/output schema discovery<br/>
        /// - Supported typing constructs: `List`, `Dict`, `Optional`, `Union`<br/>
        /// - Import from `typing` module when using complex types<br/>
        /// **Docstring Parameter Descriptions:**<br/>
        /// - Use docstrings to provide descriptions for parameters (Google, NumPy, ReST, and Epydoc styles are supported)<br/>
        /// - Parameter descriptions are extracted and included in the input schema<br/>
        /// - This gives agents better context about how to use each parameter
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LambdaToolVariant2(
            string type,
            global::G.FunctionDefinition functionDefinition,
            object? outputSchema,
            global::G.LambdaToolVariant2Language language = global::G.LambdaToolVariant2Language.Python)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.FunctionDefinition = functionDefinition ?? throw new global::System.ArgumentNullException(nameof(functionDefinition));
            this.Language = language;
            this.OutputSchema = outputSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LambdaToolVariant2" /> class.
        /// </summary>
        public LambdaToolVariant2()
        {
        }
    }
}