//HintName: G.Models.TestLambdaToolResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from testing a Lambda tool before creation. Contains comprehensive validation, schema discovery, and execution results to help users create tools successfully.
    /// </summary>
    public sealed partial class TestLambdaToolResponse
    {
        /// <summary>
        /// Results of code validation (static and sandbox).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TestLambdaToolResponseValidation Validation { get; set; }

        /// <summary>
        /// The discovered input schema from type annotations. May be null if validation failed or no type hints provided.<br/>
        /// Example: {"type":"object","properties":{"order_count":{"type":"integer"},"total_revenue":{"type":"number"}},"required":["order_count","total_revenue"]}
        /// </summary>
        /// <example>{"type":"object","properties":{"order_count":{"type":"integer"},"total_revenue":{"type":"number"}},"required":["order_count","total_revenue"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        public object? InputSchema { get; set; }

        /// <summary>
        /// The discovered output schema from type annotations. May be null if validation failed or no type hints provided.<br/>
        /// Example: {"type":"object","properties":{"score":{"type":"number"}}}
        /// </summary>
        /// <example>{"type":"object","properties":{"score":{"type":"number"}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_schema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// Results of executing the function with test input. Only present if validation passed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution")]
        public global::G.TestLambdaToolResponseExecution? Execution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestLambdaToolResponse" /> class.
        /// </summary>
        /// <param name="validation">
        /// Results of code validation (static and sandbox).
        /// </param>
        /// <param name="inputSchema">
        /// The discovered input schema from type annotations. May be null if validation failed or no type hints provided.<br/>
        /// Example: {"type":"object","properties":{"order_count":{"type":"integer"},"total_revenue":{"type":"number"}},"required":["order_count","total_revenue"]}
        /// </param>
        /// <param name="outputSchema">
        /// The discovered output schema from type annotations. May be null if validation failed or no type hints provided.<br/>
        /// Example: {"type":"object","properties":{"score":{"type":"number"}}}
        /// </param>
        /// <param name="execution">
        /// Results of executing the function with test input. Only present if validation passed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestLambdaToolResponse(
            global::G.TestLambdaToolResponseValidation validation,
            object? inputSchema,
            object? outputSchema,
            global::G.TestLambdaToolResponseExecution? execution)
        {
            this.Validation = validation ?? throw new global::System.ArgumentNullException(nameof(validation));
            this.InputSchema = inputSchema;
            this.OutputSchema = outputSchema;
            this.Execution = execution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestLambdaToolResponse" /> class.
        /// </summary>
        public TestLambdaToolResponse()
        {
        }
    }
}