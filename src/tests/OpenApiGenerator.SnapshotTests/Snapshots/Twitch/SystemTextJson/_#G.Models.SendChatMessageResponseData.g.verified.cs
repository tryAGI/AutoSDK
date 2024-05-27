//HintName: G.Models.SendChatMessageResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendChatMessageResponseData
    {
        /// <summary>
        /// The message id for the message that was sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MessageId { get; set; }

        /// <summary>
        /// If the message passed all checks and was sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_sent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsSent { get; set; }

        /// <summary>
        /// The reason the message was dropped, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drop_reason")]
        public global::System.Collections.Generic.IList<SendChatMessageResponseDataDropReason?>? DropReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}