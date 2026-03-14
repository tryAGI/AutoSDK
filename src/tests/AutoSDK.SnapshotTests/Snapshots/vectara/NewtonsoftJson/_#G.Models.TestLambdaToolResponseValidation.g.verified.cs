//HintName: G.Models.TestLambdaToolResponseValidation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Results of code validation (static and sandbox).
    /// </summary>
    public sealed partial class TestLambdaToolResponseValidation
    {
        /// <summary>
        /// Overall validation status.<br/>
        /// Example: valid
        /// </summary>
        /// <example>valid</example>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TestLambdaToolResponseValidationStatus Status { get; set; } = default!;

        /// <summary>
        /// List of validation errors if the code is invalid.<br/>
        /// Example: [Line 5: Use of forbidden module 'os']
        /// </summary>
        /// <example>[Line 5: Use of forbidden module 'os']</example>
        [global::Newtonsoft.Json.JsonProperty("errors")]
        public global::System.Collections.Generic.IList<string>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestLambdaToolResponseValidation" /> class.
        /// </summary>
        /// <param name="status">
        /// Overall validation status.<br/>
        /// Example: valid
        /// </param>
        /// <param name="errors">
        /// List of validation errors if the code is invalid.<br/>
        /// Example: [Line 5: Use of forbidden module 'os']
        /// </param>
        public TestLambdaToolResponseValidation(
            global::G.TestLambdaToolResponseValidationStatus status,
            global::System.Collections.Generic.IList<string>? errors)
        {
            this.Status = status;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestLambdaToolResponseValidation" /> class.
        /// </summary>
        public TestLambdaToolResponseValidation()
        {
        }
    }
}