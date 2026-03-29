//HintName: G.Models.ValidationSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Summary of a single validator's execution.
    /// </summary>
    public sealed partial class ValidationSummary
    {
        /// <summary>
        /// The class name of the validator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validatorName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ValidatorName { get; set; }

        /// <summary>
        /// Whether the validator passed or failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validatorStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ValidationSummaryValidatorStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ValidationSummaryValidatorStatus ValidatorStatus { get; set; }

        /// <summary>
        /// The JSON path to the property which was validated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("propertyPath")]
        public string? PropertyPath { get; set; }

        /// <summary>
        /// The error message indicating why validation failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failureReason")]
        public string? FailureReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorSpans")]
        public global::System.Collections.Generic.IList<global::G.ErrorSpan>? ErrorSpans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationSummary" /> class.
        /// </summary>
        /// <param name="validatorName">
        /// The class name of the validator.
        /// </param>
        /// <param name="validatorStatus">
        /// Whether the validator passed or failed.
        /// </param>
        /// <param name="propertyPath">
        /// The JSON path to the property which was validated.
        /// </param>
        /// <param name="failureReason">
        /// The error message indicating why validation failed.
        /// </param>
        /// <param name="errorSpans"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidationSummary(
            string validatorName,
            global::G.ValidationSummaryValidatorStatus validatorStatus,
            string? propertyPath,
            string? failureReason,
            global::System.Collections.Generic.IList<global::G.ErrorSpan>? errorSpans)
        {
            this.ValidatorName = validatorName ?? throw new global::System.ArgumentNullException(nameof(validatorName));
            this.ValidatorStatus = validatorStatus;
            this.PropertyPath = propertyPath;
            this.FailureReason = failureReason;
            this.ErrorSpans = errorSpans;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationSummary" /> class.
        /// </summary>
        public ValidationSummary()
        {
        }
    }
}