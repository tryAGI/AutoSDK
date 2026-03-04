//HintName: G.Models.FineTuneChatCompletionRequestAssistantMessageAssistantMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FineTuneChatCompletionRequestAssistantMessageAssistantMessage
    {
        /// <summary>
        /// Controls whether the assistant message is trained against (0 or 1)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public int? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneChatCompletionRequestAssistantMessageAssistantMessage" /> class.
        /// </summary>
        /// <param name="weight">
        /// Controls whether the assistant message is trained against (0 or 1)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuneChatCompletionRequestAssistantMessageAssistantMessage(
            int? weight)
        {
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneChatCompletionRequestAssistantMessageAssistantMessage" /> class.
        /// </summary>
        public FineTuneChatCompletionRequestAssistantMessageAssistantMessage()
        {
        }
    }
}