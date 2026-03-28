//HintName: G.Models.TestLambdaToolRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to test a Lambda tool before creating it. This allows users to validate their code, schemas, and execution before committing to tool creation.<br/>
    /// Use this endpoint to:<br/>
    /// - Validate Python code syntax and security constraints<br/>
    /// - Discover input/output schemas from type annotations<br/>
    /// - Test execution with sample input<br/>
    /// - Verify schema compatibility
    /// </summary>
    public sealed partial class TestLambdaToolRequest
    {
        /// <summary>
        /// The programming language. Currently only 'python' (Python 3.12) is supported.<br/>
        /// Default Value: python<br/>
        /// Example: python
        /// </summary>
        /// <example>python</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TestLambdaToolRequestLanguageJsonConverter))]
        public global::G.TestLambdaToolRequestLanguage? Language { get; set; }

        /// <summary>
        /// The Python 3.12 code for the function. Must define a `process()` entry point.<br/>
        /// Object parameters must use `TypedDict`; bare `dict` and `Dict[K, V]` parameters are rejected.<br/>
        /// See the `code` field on `CreateLambdaToolRequest` for full details and examples.<br/>
        /// Example: def process(order_count: int, total_revenue: float) -&gt; dict:<br/>
        ///     score = order_count * 10 + total_revenue * 0.1<br/>
        ///     return {'score': round(score, 2)}
        /// </summary>
        /// <example>
        /// def process(order_count: int, total_revenue: float) -&gt; dict:<br/>
        ///     score = order_count * 10 + total_revenue * 0.1<br/>
        ///     return {'score': round(score, 2)}
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Execution configuration for the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_configuration")]
        public global::G.ExecutionConfiguration? ExecutionConfiguration { get; set; }

        /// <summary>
        /// The input parameters to test the function with. Will be validated against the discovered input schema.<br/>
        /// Example: {"order_count":10,"total_revenue":500}
        /// </summary>
        /// <example>{"order_count":10,"total_revenue":500}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object TestInput { get; set; }

        /// <summary>
        /// Maximum execution time in seconds for this test. Overrides execution_configuration if specified.<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_seconds")]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestLambdaToolRequest" /> class.
        /// </summary>
        /// <param name="code">
        /// The Python 3.12 code for the function. Must define a `process()` entry point.<br/>
        /// Object parameters must use `TypedDict`; bare `dict` and `Dict[K, V]` parameters are rejected.<br/>
        /// See the `code` field on `CreateLambdaToolRequest` for full details and examples.<br/>
        /// Example: def process(order_count: int, total_revenue: float) -&gt; dict:<br/>
        ///     score = order_count * 10 + total_revenue * 0.1<br/>
        ///     return {'score': round(score, 2)}
        /// </param>
        /// <param name="testInput">
        /// The input parameters to test the function with. Will be validated against the discovered input schema.<br/>
        /// Example: {"order_count":10,"total_revenue":500}
        /// </param>
        /// <param name="language">
        /// The programming language. Currently only 'python' (Python 3.12) is supported.<br/>
        /// Default Value: python<br/>
        /// Example: python
        /// </param>
        /// <param name="executionConfiguration">
        /// Execution configuration for the function.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Maximum execution time in seconds for this test. Overrides execution_configuration if specified.<br/>
        /// Example: 10
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestLambdaToolRequest(
            string code,
            object testInput,
            global::G.TestLambdaToolRequestLanguage? language,
            global::G.ExecutionConfiguration? executionConfiguration,
            int? timeoutSeconds)
        {
            this.Language = language;
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.ExecutionConfiguration = executionConfiguration;
            this.TestInput = testInput ?? throw new global::System.ArgumentNullException(nameof(testInput));
            this.TimeoutSeconds = timeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestLambdaToolRequest" /> class.
        /// </summary>
        public TestLambdaToolRequest()
        {
        }
    }
}