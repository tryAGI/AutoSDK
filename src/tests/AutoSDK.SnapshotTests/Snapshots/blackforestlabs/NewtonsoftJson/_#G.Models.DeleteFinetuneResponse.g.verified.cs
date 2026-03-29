//HintName: G.Models.DeleteFinetuneResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteFinetuneResponse
    {
        /// <summary>
        /// Status of the deletion
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Message about the deletion
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// ID of the deleted finetune
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_finetune_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DeletedFinetuneId { get; set; } = default!;

        /// <summary>
        /// Timestamp of the deletion
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public string Timestamp { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFinetuneResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of the deletion
        /// </param>
        /// <param name="message">
        /// Message about the deletion
        /// </param>
        /// <param name="deletedFinetuneId">
        /// ID of the deleted finetune
        /// </param>
        /// <param name="timestamp">
        /// Timestamp of the deletion
        /// </param>
        public DeleteFinetuneResponse(
            string status,
            string message,
            string deletedFinetuneId,
            string timestamp)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.DeletedFinetuneId = deletedFinetuneId ?? throw new global::System.ArgumentNullException(nameof(deletedFinetuneId));
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFinetuneResponse" /> class.
        /// </summary>
        public DeleteFinetuneResponse()
        {
        }
    }
}