//HintName: G.Models.UpdateOpenAIResponsesLLMRequestVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateOpenAIResponsesLLMRequestVariant2
    {
        /// <summary>
        /// Must be "openai-responses" for OpenAI Responses API<br/>
        /// Default Value: openai-responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOpenAIResponsesLLMRequestVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be "openai-responses" for OpenAI Responses API<br/>
        /// Default Value: openai-responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateOpenAIResponsesLLMRequestVariant2(
            string? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOpenAIResponsesLLMRequestVariant2" /> class.
        /// </summary>
        public UpdateOpenAIResponsesLLMRequestVariant2()
        {
        }
    }
}