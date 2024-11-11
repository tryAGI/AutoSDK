//HintName: G.Models.RestartPlaygroundConversationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// RestartPlaygroundConversationResponse represents a response for restarting a playground conversation.
    /// </summary>
    public sealed partial class RestartPlaygroundConversationResponse
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public global::G.Conversation? Conversation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RestartPlaygroundConversationResponse" /> class.
        /// </summary>
        /// <param name="conversation">
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RestartPlaygroundConversationResponse(
            global::G.Conversation? conversation)
        {
            this.Conversation = conversation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestartPlaygroundConversationResponse" /> class.
        /// </summary>
        public RestartPlaygroundConversationResponse()
        {
        }
    }
}