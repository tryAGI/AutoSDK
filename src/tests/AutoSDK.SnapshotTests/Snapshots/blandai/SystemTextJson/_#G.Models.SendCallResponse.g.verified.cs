//HintName: G.Models.SendCallResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendCallResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SendCallResponseStatusJsonConverter))]
        public global::G.SendCallResponseStatus? Status { get; set; }

        /// <summary>
        /// Status explanation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Unique call identifier (present on success)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        /// Batch ID if part of a batch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_id")]
        public string? BatchId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendCallResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message">
        /// Status explanation
        /// </param>
        /// <param name="callId">
        /// Unique call identifier (present on success)
        /// </param>
        /// <param name="batchId">
        /// Batch ID if part of a batch
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SendCallResponse(
            global::G.SendCallResponseStatus? status,
            string? message,
            string? callId,
            string? batchId)
        {
            this.Status = status;
            this.Message = message;
            this.CallId = callId;
            this.BatchId = batchId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendCallResponse" /> class.
        /// </summary>
        public SendCallResponse()
        {
        }
    }
}