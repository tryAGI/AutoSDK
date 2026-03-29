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
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FailResultOutcomeJsonConverter))]
        public global::G.FailResultOutcome Outcome { get; set; }

        /// <summary>
        /// The error message from the validator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorMessage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErrorMessage { get; set; }

        /// <summary>
        /// A suggested fix value from the validator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fixValue")]
        public string? FixValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorSpans")]
        public global::System.Collections.Generic.IList<global::G.ErrorSpan>? ErrorSpans { get; set; }

        /// <summary>
        /// Additional metadata from the validator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The chunk of data that was validated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validatedChunk")]
        public string? ValidatedChunk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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