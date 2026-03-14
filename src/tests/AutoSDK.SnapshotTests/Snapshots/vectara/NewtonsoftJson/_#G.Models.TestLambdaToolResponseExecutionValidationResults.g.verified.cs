//HintName: G.Models.TestLambdaToolResponseExecutionValidationResults.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Results of input/output schema validation.
    /// </summary>
    public sealed partial class TestLambdaToolResponseExecutionValidationResults
    {
        /// <summary>
        /// Whether the test input matched the discovered schema.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("input_valid")]
        public bool? InputValid { get; set; }

        /// <summary>
        /// Whether the output matched the discovered schema.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("output_valid")]
        public bool? OutputValid { get; set; }

        /// <summary>
        /// Details of any schema validation errors.<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::Newtonsoft.Json.JsonProperty("validation_errors")]
        public global::System.Collections.Generic.IList<string>? ValidationErrors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestLambdaToolResponseExecutionValidationResults" /> class.
        /// </summary>
        /// <param name="inputValid">
        /// Whether the test input matched the discovered schema.<br/>
        /// Example: true
        /// </param>
        /// <param name="outputValid">
        /// Whether the output matched the discovered schema.<br/>
        /// Example: true
        /// </param>
        /// <param name="validationErrors">
        /// Details of any schema validation errors.<br/>
        /// Example: []
        /// </param>
        public TestLambdaToolResponseExecutionValidationResults(
            bool? inputValid,
            bool? outputValid,
            global::System.Collections.Generic.IList<string>? validationErrors)
        {
            this.InputValid = inputValid;
            this.OutputValid = outputValid;
            this.ValidationErrors = validationErrors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestLambdaToolResponseExecutionValidationResults" /> class.
        /// </summary>
        public TestLambdaToolResponseExecutionValidationResults()
        {
        }
    }
}