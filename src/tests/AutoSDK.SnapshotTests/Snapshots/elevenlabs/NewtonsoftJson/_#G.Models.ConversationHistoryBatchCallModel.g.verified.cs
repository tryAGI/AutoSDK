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
        [global::Newtonsoft.Json.JsonProperty("batch_call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BatchCallId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_call_recipient_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BatchCallRecipientId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryBatchCallModel" /> class.
        /// </summary>
        /// <param name="batchCallId"></param>
        /// <param name="batchCallRecipientId"></param>
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