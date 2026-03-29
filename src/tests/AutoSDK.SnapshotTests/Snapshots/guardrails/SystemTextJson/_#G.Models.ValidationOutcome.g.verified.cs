//HintName: G.Models.ValidationOutcome.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The output from a Guard execution.
    /// </summary>
    public sealed partial class ValidationOutcome
    {
        /// <summary>
        /// Foreign key to the most recent Call this resulted from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// The raw, unchanged string content from the LLM call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rawLlmOutput")]
        public string? RawLlmOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validationSummaries")]
        public global::System.Collections.Generic.IList<global::G.ValidationSummary>? ValidationSummaries { get; set; }

        /// <summary>
        /// The validated, and potentially fixed, output from the LLM call after undergoing validation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validatedOutput")]
        public string? ValidatedOutput { get; set; }

        /// <summary>
        /// A reask request when validation fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reask")]
        public global::G.Reask? Reask { get; set; }

        /// <summary>
        /// A boolean to indicate whether or not the LLM output passed validation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validationPassed")]
        public bool? ValidationPassed { get; set; }

        /// <summary>
        /// If the validation process raised a handleable exception, this field will contain the error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationOutcome" /> class.
        /// </summary>
        /// <param name="callId">
        /// Foreign key to the most recent Call this resulted from.
        /// </param>
        /// <param name="rawLlmOutput">
        /// The raw, unchanged string content from the LLM call.
        /// </param>
        /// <param name="validationSummaries"></param>
        /// <param name="validatedOutput">
        /// The validated, and potentially fixed, output from the LLM call after undergoing validation.
        /// </param>
        /// <param name="reask">
        /// A reask request when validation fails.
        /// </param>
        /// <param name="validationPassed">
        /// A boolean to indicate whether or not the LLM output passed validation.
        /// </param>
        /// <param name="error">
        /// If the validation process raised a handleable exception, this field will contain the error message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidationOutcome(
            string callId,
            string? rawLlmOutput,
            global::System.Collections.Generic.IList<global::G.ValidationSummary>? validationSummaries,
            string? validatedOutput,
            global::G.Reask? reask,
            bool? validationPassed,
            string? error)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.RawLlmOutput = rawLlmOutput;
            this.ValidationSummaries = validationSummaries;
            this.ValidatedOutput = validatedOutput;
            this.Reask = reask;
            this.ValidationPassed = validationPassed;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationOutcome" /> class.
        /// </summary>
        public ValidationOutcome()
        {
        }
    }
}