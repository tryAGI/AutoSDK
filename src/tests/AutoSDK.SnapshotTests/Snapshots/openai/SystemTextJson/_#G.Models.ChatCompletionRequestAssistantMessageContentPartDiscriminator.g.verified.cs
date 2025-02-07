//HintName: G.Models.ChatCompletionRequestAssistantMessageContentPartDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequestAssistantMessageContentPartDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionRequestAssistantMessageContentPartDiscriminatorTypeJsonConverter))]
        public global::G.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestAssistantMessageContentPartDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequestAssistantMessageContentPartDiscriminator(
            global::G.ChatCompletionRequestAssistantMessageContentPartDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestAssistantMessageContentPartDiscriminator" /> class.
        /// </summary>
        public ChatCompletionRequestAssistantMessageContentPartDiscriminator()
        {
        }
    }
}