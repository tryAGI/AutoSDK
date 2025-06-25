//HintName: G.Models.SendChatMessageResponseDataItemDropReasonItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendChatMessageResponseDataItemDropReasonItem
    {
        /// <summary>
        /// Code for why the message was dropped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Message for why the message was dropped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendChatMessageResponseDataItemDropReasonItem" /> class.
        /// </summary>
        /// <param name="code">
        /// Code for why the message was dropped.
        /// </param>
        /// <param name="message">
        /// Message for why the message was dropped.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SendChatMessageResponseDataItemDropReasonItem(
            string code,
            string message)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendChatMessageResponseDataItemDropReasonItem" /> class.
        /// </summary>
        public SendChatMessageResponseDataItemDropReasonItem()
        {
        }
    }
}