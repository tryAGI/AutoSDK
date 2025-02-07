//HintName: G.Models.SendChatMessageResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendChatMessageResponseDataItem
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
        public global::System.Collections.Generic.IList<global::G.SendChatMessageResponseDataItemDropReasonItem>? DropReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendChatMessageResponseDataItem" /> class.
        /// </summary>
        /// <param name="messageId">
        /// The message id for the message that was sent.
        /// </param>
        /// <param name="isSent">
        /// If the message passed all checks and was sent.
        /// </param>
        /// <param name="dropReason">
        /// The reason the message was dropped, if any.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SendChatMessageResponseDataItem(
            string messageId,
            bool isSent,
            global::System.Collections.Generic.IList<global::G.SendChatMessageResponseDataItemDropReasonItem>? dropReason)
        {
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
            this.IsSent = isSent;
            this.DropReason = dropReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendChatMessageResponseDataItem" /> class.
        /// </summary>
        public SendChatMessageResponseDataItem()
        {
        }
    }
}