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
        [global::Newtonsoft.Json.JsonProperty("callId", Required = global::Newtonsoft.Json.Required.Always)]
        public string CallId { get; set; } = default!;

        /// <summary>
        /// The raw, unchanged string content from the LLM call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rawLlmOutput")]
        public string? RawLlmOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validationSummaries")]
        public global::System.Collections.Generic.IList<global::G.ValidationSummary>? ValidationSummaries { get; set; }

        /// <summary>
        /// The validated, and potentially fixed, output from the LLM call after undergoing validation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validatedOutput")]
        public string? ValidatedOutput { get; set; }

        /// <summary>
        /// A reask request when validation fails.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reask")]
        public global::G.Reask? Reask { get; set; }

        /// <summary>
        /// A boolean to indicate whether or not the LLM output passed validation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validationPassed")]
        public bool? ValidationPassed { get; set; }

        /// <summary>
        /// If the validation process raised a handleable exception, this field will contain the error message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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