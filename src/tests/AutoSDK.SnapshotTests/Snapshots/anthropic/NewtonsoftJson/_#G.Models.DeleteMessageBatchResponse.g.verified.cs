//HintName: G.Models.DeleteMessageBatchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteMessageBatchResponse
    {
        /// <summary>
        /// ID of the Message Batch.<br/>
        /// Example: msgbatch_013Zva2CMHLNnXjNJJKqJ2EF
        /// </summary>
        /// <example>msgbatch_013Zva2CMHLNnXjNJJKqJ2EF</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Deleted object type.<br/>
        /// For Message Batches, this is always `"message_batch_deleted"`.<br/>
        /// Default Value: message_batch_deleted
        /// </summary>
        /// <default>global::G.DeleteMessageBatchResponseType.MessageBatchDeleted</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.DeleteMessageBatchResponseType Type { get; set; } = global::G.DeleteMessageBatchResponseType.MessageBatchDeleted;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMessageBatchResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the Message Batch.<br/>
        /// Example: msgbatch_013Zva2CMHLNnXjNJJKqJ2EF
        /// </param>
        /// <param name="type">
        /// Deleted object type.<br/>
        /// For Message Batches, this is always `"message_batch_deleted"`.<br/>
        /// Default Value: message_batch_deleted
        /// </param>
        public DeleteMessageBatchResponse(
            string id,
            global::G.DeleteMessageBatchResponseType type = global::G.DeleteMessageBatchResponseType.MessageBatchDeleted)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMessageBatchResponse" /> class.
        /// </summary>
        public DeleteMessageBatchResponse()
        {
        }
    }
}