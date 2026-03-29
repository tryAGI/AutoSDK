//HintName: G.Models.Outputs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output data from an iteration.
    /// </summary>
    public sealed partial class Outputs
    {
        /// <summary>
        /// Information from the LLM response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llmResponseInfo")]
        public global::G.LLMResponse? LlmResponseInfo { get; set; }

        /// <summary>
        /// The string content from the LLM response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rawOutput")]
        public string? RawOutput { get; set; }

        /// <summary>
        /// The parsed output from the LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parsedOutput")]
        public string? ParsedOutput { get; set; }

        /// <summary>
        /// The validation response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validationResponse")]
        public string? ValidationResponse { get; set; }

        /// <summary>
        /// The guarded output after validation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardedOutput")]
        public string? GuardedOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasks")]
        public global::System.Collections.Generic.IList<global::G.Reask>? Reasks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validatorLogs")]
        public global::System.Collections.Generic.IList<global::G.ValidatorLog>? ValidatorLogs { get; set; }

        /// <summary>
        /// Error message if an exception occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Outputs" /> class.
        /// </summary>
        /// <param name="llmResponseInfo">
        /// Information from the LLM response.
        /// </param>
        /// <param name="rawOutput">
        /// The string content from the LLM response.
        /// </param>
        /// <param name="parsedOutput">
        /// The parsed output from the LLM.
        /// </param>
        /// <param name="validationResponse">
        /// The validation response.
        /// </param>
        /// <param name="guardedOutput">
        /// The guarded output after validation.
        /// </param>
        /// <param name="reasks"></param>
        /// <param name="validatorLogs"></param>
        /// <param name="error">
        /// Error message if an exception occurred.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Outputs(
            global::G.LLMResponse? llmResponseInfo,
            string? rawOutput,
            string? parsedOutput,
            string? validationResponse,
            string? guardedOutput,
            global::System.Collections.Generic.IList<global::G.Reask>? reasks,
            global::System.Collections.Generic.IList<global::G.ValidatorLog>? validatorLogs,
            string? error)
        {
            this.LlmResponseInfo = llmResponseInfo;
            this.RawOutput = rawOutput;
            this.ParsedOutput = parsedOutput;
            this.ValidationResponse = validationResponse;
            this.GuardedOutput = guardedOutput;
            this.Reasks = reasks;
            this.ValidatorLogs = validatorLogs;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Outputs" /> class.
        /// </summary>
        public Outputs()
        {
        }
    }
}