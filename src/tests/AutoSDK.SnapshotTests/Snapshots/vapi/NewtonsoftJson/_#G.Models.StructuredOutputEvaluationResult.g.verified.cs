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
        [global::Newtonsoft.Json.JsonProperty("structuredOutputId", Required = global::Newtonsoft.Json.Required.Always)]
        public string StructuredOutputId { get; set; } = default!;

        /// <summary>
        /// This is the name of the structured output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// This is the value extracted from the call by the structured output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extractedValue", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<double?, string, bool?, object> ExtractedValue { get; set; } = default!;

        /// <summary>
        /// This is the expected value that was defined in the evaluation plan.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expectedValue", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<double?, string, bool?> ExpectedValue { get; set; } = default!;

        /// <summary>
        /// This is the comparison operator used for evaluation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comparator", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.StructuredOutputEvaluationResultComparator Comparator { get; set; } = default!;

        /// <summary>
        /// This indicates whether the evaluation passed (extracted value matched expected value using comparator).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("passed", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Passed { get; set; } = default!;

        /// <summary>
        /// This indicates whether this evaluation was required for the simulation to pass.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Required { get; set; } = default!;

        /// <summary>
        /// This contains any error that occurred during extraction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// This indicates whether this evaluation was skipped (e.g., multimodal in chat mode).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isSkipped")]
        public bool? IsSkipped { get; set; }

        /// <summary>
        /// This contains the reason for skipping the evaluation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("skipReason")]
        public string? SkipReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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