//HintName: G.Models.UpdateOpenAILLMRequestVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateOpenAILLMRequestVariant2
    {
        /// <summary>
        /// Must be "openai-compatible" for OpenAI and OpenAI-compatible APIs<br/>
        /// Default Value: openai-compatible
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOpenAILLMRequestVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be "openai-compatible" for OpenAI and OpenAI-compatible APIs<br/>
        /// Default Value: openai-compatible
        /// </param>
        public UpdateOpenAILLMRequestVariant2(
            string? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOpenAILLMRequestVariant2" /> class.
        /// </summary>
        public UpdateOpenAILLMRequestVariant2()
        {
        }
    }
}