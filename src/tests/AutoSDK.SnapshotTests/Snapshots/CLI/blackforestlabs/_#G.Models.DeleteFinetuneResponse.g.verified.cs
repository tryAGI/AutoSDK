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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Message about the deletion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// ID of the deleted finetune
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_finetune_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeletedFinetuneId { get; set; }

        /// <summary>
        /// Timestamp of the deletion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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