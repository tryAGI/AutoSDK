//HintName: G.Models.FailResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result from a failed validation.
    /// </summary>
    public sealed partial class FailResult
    {
        /// <summary>
        /// Always 'fail' for FailResult.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outcome")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FailResultOutcomeJsonConverter))]
        public global::G.FailResultOutcome Outcome { get; set; }

        /// <summary>
        /// The error message from the validator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errorMessage", Required = global::Newtonsoft.Json.Required.Always)]
        public string ErrorMessage { get; set; } = default!;

        /// <summary>
        /// A suggested fix value from the validator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fixValue")]
        public string? FixValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errorSpans")]
        public global::System.Collections.Generic.IList<global::G.ErrorSpan>? ErrorSpans { get; set; }

        /// <summary>
        /// Additional metadata from the validator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The chunk of data that was validated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validatedChunk")]
        public string? ValidatedChunk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FailResult" /> class.
        /// </summary>
        /// <param name="errorMessage">
        /// The error message from the validator.
        /// </param>
        /// <param name="outcome">
        /// Always 'fail' for FailResult.
        /// </param>
        /// <param name="fixValue">
        /// A suggested fix value from the validator.
        /// </param>
        /// <param name="errorSpans"></param>
        /// <param name="metadata">
        /// Additional metadata from the validator.
        /// </param>
        /// <param name="validatedChunk">
        /// The chunk of data that was validated.
        /// </param>
        public FailResult(
            string errorMessage,
            global::G.FailResultOutcome outcome,
            string? fixValue,
            global::System.Collections.Generic.IList<global::G.ErrorSpan>? errorSpans,
            object? metadata,
            string? validatedChunk)
        {
            this.Outcome = outcome;
            this.ErrorMessage = errorMessage ?? throw new global::System.ArgumentNullException(nameof(errorMessage));
            this.FixValue = fixValue;
            this.ErrorSpans = errorSpans;
            this.Metadata = metadata;
            this.ValidatedChunk = validatedChunk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FailResult" /> class.
        /// </summary>
        public FailResult()
        {
        }
    }
}