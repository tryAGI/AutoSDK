//HintName: G.Models.ValidatePayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Payload for running validations on LLM output.
    /// </summary>
    public sealed partial class ValidatePayload
    {
        /// <summary>
        /// The LLM output as a string or the input prompts for the LLM<br/>
        /// Example: stubbed llm output
        /// </summary>
        /// <example>stubbed llm output</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("llmOutput")]
        public string? LlmOutput { get; set; }

        /// <summary>
        /// An override for the number of re-asks to perform
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numReasks")]
        public int? NumReasks { get; set; }

        /// <summary>
        /// Additional params for llm prompts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptParams")]
        public object? PromptParams { get; set; }

        /// <summary>
        /// The LLM API to use for validation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llmApi")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ValidatePayloadLlmApiJsonConverter))]
        public global::G.ValidatePayloadLlmApi? LlmApi { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidatePayload" /> class.
        /// </summary>
        /// <param name="llmOutput">
        /// The LLM output as a string or the input prompts for the LLM<br/>
        /// Example: stubbed llm output
        /// </param>
        /// <param name="numReasks">
        /// An override for the number of re-asks to perform
        /// </param>
        /// <param name="promptParams">
        /// Additional params for llm prompts
        /// </param>
        /// <param name="llmApi">
        /// The LLM API to use for validation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidatePayload(
            string? llmOutput,
            int? numReasks,
            object? promptParams,
            global::G.ValidatePayloadLlmApi? llmApi)
        {
            this.LlmOutput = llmOutput;
            this.NumReasks = numReasks;
            this.PromptParams = promptParams;
            this.LlmApi = llmApi;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidatePayload" /> class.
        /// </summary>
        public ValidatePayload()
        {
        }
    }
}