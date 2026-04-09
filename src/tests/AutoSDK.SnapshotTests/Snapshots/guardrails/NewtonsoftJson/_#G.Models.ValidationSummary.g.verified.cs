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
        [global::Newtonsoft.Json.JsonProperty("validatorName", Required = global::Newtonsoft.Json.Required.Always)]
        public string ValidatorName { get; set; } = default!;

        /// <summary>
        /// Whether the validator passed or failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validatorStatus", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ValidationSummaryValidatorStatusJsonConverter))]
        public global::G.ValidationSummaryValidatorStatus ValidatorStatus { get; set; } = default!;

        /// <summary>
        /// The JSON path to the property which was validated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("propertyPath")]
        public string? PropertyPath { get; set; }

        /// <summary>
        /// The error message indicating why validation failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failureReason")]
        public string? FailureReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errorSpans")]
        public global::System.Collections.Generic.IList<global::G.ErrorSpan>? ErrorSpans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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