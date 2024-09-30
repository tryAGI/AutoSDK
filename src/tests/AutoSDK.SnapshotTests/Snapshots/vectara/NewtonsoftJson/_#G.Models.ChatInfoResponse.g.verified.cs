//HintName: G.Models.ChatInfoResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about the chat.
    /// </summary>
    public sealed partial class ChatInfoResponse
    {
        /// <summary>
        /// This will be `chat_info` when the stream event contains information<br/>
        /// about how the chat is stored.<br/>
        /// Default Value: chat_info
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; } = "chat_info";

        /// <summary>
        /// ID of the chat.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// ID of the turn.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("turn_id")]
        public string? TurnId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}