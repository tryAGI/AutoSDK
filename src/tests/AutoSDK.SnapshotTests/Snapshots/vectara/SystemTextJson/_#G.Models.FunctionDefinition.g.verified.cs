//HintName: G.Models.FunctionDefinition.g.cs

#nullable enable

namespace G
{
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
    public sealed partial class FunctionDefinition
    {
        /// <summary>
        /// The programming language of the function. Currently only Python 3.12 is supported.<br/>
        /// Example: python
        /// </summary>
        /// <example>python</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FunctionDefinitionLanguageJsonConverter))]
        public global::G.FunctionDefinitionLanguage Language { get; set; }

        /// <summary>
        /// The function code.<br/>
        /// **Required**: Must define a `process()` entry point function. Use type annotations on parameters for automatic schema discovery.<br/>
        /// Parameters are passed as keyword arguments matched to the function signature.<br/>
        /// Example: def process(data: list, threshold: float = 0):<br/>
        ///     filtered = [x for x in data if x &gt; threshold]<br/>
        ///     return {<br/>
        ///         'count': len(filtered),<br/>
        ///         'average': sum(filtered) / len(filtered) if filtered else 0,<br/>
        ///         'filtered_data': filtered<br/>
        ///     }
        /// </summary>
        /// <example>
        /// def process(data: list, threshold: float = 0):<br/>
        ///     filtered = [x for x in data if x &gt; threshold]<br/>
        ///     return {<br/>
        ///         'count': len(filtered),<br/>
        ///         'average': sum(filtered) / len(filtered) if filtered else 0,<br/>
        ///         'filtered_data': filtered<br/>
        ///     }
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// The validation status of the code.<br/>
        /// Example: valid
        /// </summary>
        /// <example>valid</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FunctionDefinitionValidationStatusJsonConverter))]
        public global::G.FunctionDefinitionValidationStatus? ValidationStatus { get; set; }

        /// <summary>
        /// List of validation errors if the code is invalid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_errors")]
        public global::System.Collections.Generic.IList<string>? ValidationErrors { get; set; }

        /// <summary>
        /// Execution configuration for the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_configuration")]
        public global::G.ExecutionConfiguration? ExecutionConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDefinition" /> class.
        /// </summary>
        /// <param name="code">
        /// The function code.<br/>
        /// **Required**: Must define a `process()` entry point function. Use type annotations on parameters for automatic schema discovery.<br/>
        /// Parameters are passed as keyword arguments matched to the function signature.<br/>
        /// Example: def process(data: list, threshold: float = 0):<br/>
        ///     filtered = [x for x in data if x &gt; threshold]<br/>
        ///     return {<br/>
        ///         'count': len(filtered),<br/>
        ///         'average': sum(filtered) / len(filtered) if filtered else 0,<br/>
        ///         'filtered_data': filtered<br/>
        ///     }
        /// </param>
        /// <param name="language">
        /// The programming language of the function. Currently only Python 3.12 is supported.<br/>
        /// Example: python
        /// </param>
        /// <param name="validationStatus">
        /// The validation status of the code.<br/>
        /// Example: valid
        /// </param>
        /// <param name="validationErrors">
        /// List of validation errors if the code is invalid.
        /// </param>
        /// <param name="executionConfiguration">
        /// Execution configuration for the function.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionDefinition(
            string code,
            global::G.FunctionDefinitionLanguage language,
            global::G.FunctionDefinitionValidationStatus? validationStatus,
            global::System.Collections.Generic.IList<string>? validationErrors,
            global::G.ExecutionConfiguration? executionConfiguration)
        {
            this.Language = language;
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.ValidationStatus = validationStatus;
            this.ValidationErrors = validationErrors;
            this.ExecutionConfiguration = executionConfiguration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDefinition" /> class.
        /// </summary>
        public FunctionDefinition()
        {
        }
    }
}