//HintName: G.Models.ConversationHistoryBatchCallModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryBatchCallModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BatchCallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_call_recipient_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BatchCallRecipientId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryBatchCallModel" /> class.
        /// </summary>
        /// <param name="batchCallId"></param>
        /// <param name="batchCallRecipientId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationHistoryBatchCallModel(
            string batchCallId,
            string batchCallRecipientId)
        {
            this.BatchCallId = batchCallId ?? throw new global::System.ArgumentNullException(nameof(batchCallId));
            this.BatchCallRecipientId = batchCallRecipientId ?? throw new global::System.ArgumentNullException(nameof(batchCallRecipientId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryBatchCallModel" /> class.
        /// </summary>
        public ConversationHistoryBatchCallModel()
        {
        }
    }
}