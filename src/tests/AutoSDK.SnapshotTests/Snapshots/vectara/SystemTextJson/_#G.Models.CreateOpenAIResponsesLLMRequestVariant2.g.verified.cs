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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "openai-responses";

        /// <summary>
        /// The model name to use with the Responses API (e.g. o1-preview, o1-mini). This is used in the API request to the remote LLM provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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