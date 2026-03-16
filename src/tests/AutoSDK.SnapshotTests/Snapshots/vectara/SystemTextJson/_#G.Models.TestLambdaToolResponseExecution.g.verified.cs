//HintName: G.Models.TestLambdaToolResponseExecution.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Results of executing the function with test input. Only present if validation passed.
    /// </summary>
    public sealed partial class TestLambdaToolResponseExecution
    {
        /// <summary>
        /// Whether the execution was successful.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// The output returned by the function.<br/>
        /// Example: {"score":105}
        /// </summary>
        /// <example>{"score":105}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// Error information if execution failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::G.TestLambdaToolResponseExecutionError? Error { get; set; }

        /// <summary>
        /// Time taken to execute the function in milliseconds.<br/>
        /// Example: 125
        /// </summary>
        /// <example>125</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_millis")]
        public int? LatencyMillis { get; set; }

        /// <summary>
        /// Memory used during execution in megabytes.<br/>
        /// Example: 32
        /// </summary>
        /// <example>32</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_used_mb")]
        public long? MemoryUsedMb { get; set; }

        /// <summary>
        /// Results of input/output schema validation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_results")]
        public global::G.TestLambdaToolResponseExecutionValidationResults? ValidationResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestLambdaToolResponseExecution" /> class.
        /// </summary>
        /// <param name="success">
        /// Whether the execution was successful.<br/>
        /// Example: true
        /// </param>
        /// <param name="output">
        /// The output returned by the function.<br/>
        /// Example: {"score":105}
        /// </param>
        /// <param name="error">
        /// Error information if execution failed.
        /// </param>
        /// <param name="latencyMillis">
        /// Time taken to execute the function in milliseconds.<br/>
        /// Example: 125
        /// </param>
        /// <param name="memoryUsedMb">
        /// Memory used during execution in megabytes.<br/>
        /// Example: 32
        /// </param>
        /// <param name="validationResults">
        /// Results of input/output schema validation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestLambdaToolResponseExecution(
            bool success,
            object? output,
            global::G.TestLambdaToolResponseExecutionError? error,
            int? latencyMillis,
            long? memoryUsedMb,
            global::G.TestLambdaToolResponseExecutionValidationResults? validationResults)
        {
            this.Success = success;
            this.Output = output;
            this.Error = error;
            this.LatencyMillis = latencyMillis;
            this.MemoryUsedMb = memoryUsedMb;
            this.ValidationResults = validationResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestLambdaToolResponseExecution" /> class.
        /// </summary>
        public TestLambdaToolResponseExecution()
        {
        }
    }
}