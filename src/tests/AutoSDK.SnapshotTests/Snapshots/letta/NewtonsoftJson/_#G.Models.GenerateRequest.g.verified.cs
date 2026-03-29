//HintName: G.Models.GenerateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request for direct LLM generation without agent processing.
    /// </summary>
    public sealed partial class GenerateRequest
    {
        /// <summary>
        /// The prompt/message to send to the LLM
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// Optional system prompt to prepend to the conversation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Model handle to use instead of agent's default (e.g., 'openai/gpt-4', 'anthropic/claude-3-5-sonnet')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("override_model")]
        public string? OverrideModel { get; set; }

        /// <summary>
        /// JSON schema for structured output. When provided, the LLM will be forced to return a response matching this schema via tool calling. The schema should follow JSON Schema format with 'properties' and optionally 'required' fields.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_schema")]
        public object? ResponseSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt/message to send to the LLM
        /// </param>
        /// <param name="systemPrompt">
        /// Optional system prompt to prepend to the conversation
        /// </param>
        /// <param name="overrideModel">
        /// Model handle to use instead of agent's default (e.g., 'openai/gpt-4', 'anthropic/claude-3-5-sonnet')
        /// </param>
        /// <param name="responseSchema">
        /// JSON schema for structured output. When provided, the LLM will be forced to return a response matching this schema via tool calling. The schema should follow JSON Schema format with 'properties' and optionally 'required' fields.
        /// </param>
        public GenerateRequest(
            string prompt,
            string? systemPrompt,
            string? overrideModel,
            object? responseSchema)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.SystemPrompt = systemPrompt;
            this.OverrideModel = overrideModel;
            this.ResponseSchema = responseSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateRequest" /> class.
        /// </summary>
        public GenerateRequest()
        {
        }
    }
}