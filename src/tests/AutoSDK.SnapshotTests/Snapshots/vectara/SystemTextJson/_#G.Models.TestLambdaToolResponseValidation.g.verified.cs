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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TestLambdaToolResponseValidationStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TestLambdaToolResponseValidationStatus Status { get; set; }

        /// <summary>
        /// List of validation errors if the code is invalid.<br/>
        /// Example: [Line 5: Use of forbidden module 'os']
        /// </summary>
        /// <example>[Line 5: Use of forbidden module 'os']</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<string>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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