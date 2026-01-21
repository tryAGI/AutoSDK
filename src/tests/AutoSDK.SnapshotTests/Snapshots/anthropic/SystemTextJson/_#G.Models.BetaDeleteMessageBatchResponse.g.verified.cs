//HintName: G.Models.BetaDeleteMessageBatchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaDeleteMessageBatchResponse
    {
        /// <summary>
        /// ID of the Message Batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Deleted object type.<br/>
        /// For Message Batches, this is always `"message_batch_deleted"`.<br/>
        /// Default Value: message_batch_deleted
        /// </summary>
        /// <default>global::G.BetaDeleteMessageBatchResponseType.MessageBatchDeleted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BetaDeleteMessageBatchResponseTypeJsonConverter))]
        public global::G.BetaDeleteMessageBatchResponseType Type { get; set; } = global::G.BetaDeleteMessageBatchResponseType.MessageBatchDeleted;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeleteMessageBatchResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the Message Batch.
        /// </param>
        /// <param name="type">
        /// Deleted object type.<br/>
        /// For Message Batches, this is always `"message_batch_deleted"`.<br/>
        /// Default Value: message_batch_deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDeleteMessageBatchResponse(
            string id,
            global::G.BetaDeleteMessageBatchResponseType type = global::G.BetaDeleteMessageBatchResponseType.MessageBatchDeleted)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeleteMessageBatchResponse" /> class.
        /// </summary>
        public BetaDeleteMessageBatchResponse()
        {
        }
    }
}