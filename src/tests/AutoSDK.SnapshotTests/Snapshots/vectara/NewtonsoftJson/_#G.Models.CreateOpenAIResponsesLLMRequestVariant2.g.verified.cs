//HintName: G.Models.CreateOpenAIResponsesLLMRequestVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOpenAIResponsesLLMRequestVariant2
    {
        /// <summary>
        /// Must be "openai-responses" for OpenAI Responses API (reasoning models like o1, o3)<br/>
        /// Default Value: openai-responses
        /// </summary>
        /// <default>"openai-responses"</default>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The model name to use with the Responses API (e.g. o1-preview, o1-mini). This is used in the API request to the remote LLM provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOpenAIResponsesLLMRequestVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be "openai-responses" for OpenAI Responses API (reasoning models like o1, o3)<br/>
        /// Default Value: openai-responses
        /// </param>
        /// <param name="model">
        /// The model name to use with the Responses API (e.g. o1-preview, o1-mini). This is used in the API request to the remote LLM provider.
        /// </param>
        public CreateOpenAIResponsesLLMRequestVariant2(
            string type,
            string model)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOpenAIResponsesLLMRequestVariant2" /> class.
        /// </summary>
        public CreateOpenAIResponsesLLMRequestVariant2()
        {
        }
    }
}