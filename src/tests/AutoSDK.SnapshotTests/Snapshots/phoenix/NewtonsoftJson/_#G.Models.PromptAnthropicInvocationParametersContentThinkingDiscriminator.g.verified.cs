//HintName: G.Models.PromptAnthropicInvocationParametersContentThinkingDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptAnthropicInvocationParametersContentThinkingDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PromptAnthropicInvocationParametersContentThinkingDiscriminatorTypeJsonConverter))]
        public global::G.PromptAnthropicInvocationParametersContentThinkingDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAnthropicInvocationParametersContentThinkingDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public PromptAnthropicInvocationParametersContentThinkingDiscriminator(
            global::G.PromptAnthropicInvocationParametersContentThinkingDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAnthropicInvocationParametersContentThinkingDiscriminator" /> class.
        /// </summary>
        public PromptAnthropicInvocationParametersContentThinkingDiscriminator()
        {
        }
    }
}