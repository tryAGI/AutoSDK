//HintName: G.Models.CreateOpenAILLMRequestVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOpenAILLMRequestVariant2
    {
        /// <summary>
        /// Must be "openai-compatible" for OpenAI and OpenAI-compatible APIs (like Anthropic Claude, Azure OpenAI, etc)<br/>
        /// Default Value: openai-compatible
        /// </summary>
        /// <default>"openai-compatible"</default>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The model name to use with the API (e.g. gpt-4, claude-2, etc). This is used in the API request to the remote LLM provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOpenAILLMRequestVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be "openai-compatible" for OpenAI and OpenAI-compatible APIs (like Anthropic Claude, Azure OpenAI, etc)<br/>
        /// Default Value: openai-compatible
        /// </param>
        /// <param name="model">
        /// The model name to use with the API (e.g. gpt-4, claude-2, etc). This is used in the API request to the remote LLM provider.
        /// </param>
        public CreateOpenAILLMRequestVariant2(
            string type,
            string model)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOpenAILLMRequestVariant2" /> class.
        /// </summary>
        public CreateOpenAILLMRequestVariant2()
        {
        }
    }
}