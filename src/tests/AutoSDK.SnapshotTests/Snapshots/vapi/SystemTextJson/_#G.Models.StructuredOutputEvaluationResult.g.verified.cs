//HintName: G.Models.StructuredOutputEvaluationResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StructuredOutputEvaluationResult
    {
        /// <summary>
        /// This is the ID of the structured output that was evaluated.<br/>
        /// Will be 'inline' for inline structured output definitions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredOutputId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StructuredOutputId { get; set; }

        /// <summary>
        /// This is the name of the structured output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// This is the value extracted from the call by the structured output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extractedValue")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<double?, string, bool?, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<double?, string, bool?, object> ExtractedValue { get; set; }

        /// <summary>
        /// This is the expected value that was defined in the evaluation plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expectedValue")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<double?, string, bool?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<double?, string, bool?> ExpectedValue { get; set; }

        /// <summary>
        /// This is the comparison operator used for evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StructuredOutputEvaluationResultComparatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.StructuredOutputEvaluationResultComparator Comparator { get; set; }

        /// <summary>
        /// This indicates whether the evaluation passed (extracted value matched expected value using comparator).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passed { get; set; }

        /// <summary>
        /// This indicates whether this evaluation was required for the simulation to pass.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Required { get; set; }

        /// <summary>
        /// This contains any error that occurred during extraction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// This indicates whether this evaluation was skipped (e.g., multimodal in chat mode).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isSkipped")]
        public bool? IsSkipped { get; set; }

        /// <summary>
        /// This contains the reason for skipping the evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipReason")]
        public string? SkipReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredOutputEvaluationResult" /> class.
        /// </summary>
        /// <param name="structuredOutputId">
        /// This is the ID of the structured output that was evaluated.<br/>
        /// Will be 'inline' for inline structured output definitions.
        /// </param>
        /// <param name="name">
        /// This is the name of the structured output.
        /// </param>
        /// <param name="extractedValue">
        /// This is the value extracted from the call by the structured output.
        /// </param>
        /// <param name="expectedValue">
        /// This is the expected value that was defined in the evaluation plan.
        /// </param>
        /// <param name="comparator">
        /// This is the comparison operator used for evaluation.
        /// </param>
        /// <param name="passed">
        /// This indicates whether the evaluation passed (extracted value matched expected value using comparator).
        /// </param>
        /// <param name="required">
        /// This indicates whether this evaluation was required for the simulation to pass.
        /// </param>
        /// <param name="error">
        /// This contains any error that occurred during extraction.
        /// </param>
        /// <param name="isSkipped">
        /// This indicates whether this evaluation was skipped (e.g., multimodal in chat mode).
        /// </param>
        /// <param name="skipReason">
        /// This contains the reason for skipping the evaluation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StructuredOutputEvaluationResult(
            string structuredOutputId,
            string name,
            global::G.OneOf<double?, string, bool?, object> extractedValue,
            global::G.OneOf<double?, string, bool?> expectedValue,
            global::G.StructuredOutputEvaluationResultComparator comparator,
            bool passed,
            bool required,
            string? error,
            bool? isSkipped,
            string? skipReason)
        {
            this.StructuredOutputId = structuredOutputId ?? throw new global::System.ArgumentNullException(nameof(structuredOutputId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ExtractedValue = extractedValue;
            this.ExpectedValue = expectedValue;
            this.Comparator = comparator;
            this.Passed = passed;
            this.Required = required;
            this.Error = error;
            this.IsSkipped = isSkipped;
            this.SkipReason = skipReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredOutputEvaluationResult" /> class.
        /// </summary>
        public StructuredOutputEvaluationResult()
        {
        }
    }
}