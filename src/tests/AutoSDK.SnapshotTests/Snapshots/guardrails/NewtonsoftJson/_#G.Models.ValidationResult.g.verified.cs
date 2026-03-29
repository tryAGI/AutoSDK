//HintName: G.Models.ValidationResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The output from a single Validator.
    /// </summary>
    public sealed partial class ValidationResult
    {
        /// <summary>
        /// Whether validation passed or failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outcome", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ValidationResultOutcome Outcome { get; set; } = default!;

        /// <summary>
        /// Additional metadata.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The chunk of data that was validated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validatedChunk")]
        public string? ValidatedChunk { get; set; }

        /// <summary>
        /// Error message if validation failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errorMessage")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// A suggested fix value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fixValue")]
        public string? FixValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errorSpans")]
        public global::System.Collections.Generic.IList<global::G.ErrorSpan>? ErrorSpans { get; set; }

        /// <summary>
        /// An override value if validation passed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("valueOverride")]
        public string? ValueOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationResult" /> class.
        /// </summary>
        /// <param name="outcome">
        /// Whether validation passed or failed.
        /// </param>
        /// <param name="metadata">
        /// Additional metadata.
        /// </param>
        /// <param name="validatedChunk">
        /// The chunk of data that was validated.
        /// </param>
        /// <param name="errorMessage">
        /// Error message if validation failed.
        /// </param>
        /// <param name="fixValue">
        /// A suggested fix value.
        /// </param>
        /// <param name="errorSpans"></param>
        /// <param name="valueOverride">
        /// An override value if validation passed.
        /// </param>
        public ValidationResult(
            global::G.ValidationResultOutcome outcome,
            object? metadata,
            string? validatedChunk,
            string? errorMessage,
            string? fixValue,
            global::System.Collections.Generic.IList<global::G.ErrorSpan>? errorSpans,
            string? valueOverride)
        {
            this.Outcome = outcome;
            this.Metadata = metadata;
            this.ValidatedChunk = validatedChunk;
            this.ErrorMessage = errorMessage;
            this.FixValue = fixValue;
            this.ErrorSpans = errorSpans;
            this.ValueOverride = valueOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationResult" /> class.
        /// </summary>
        public ValidationResult()
        {
        }
    }
}