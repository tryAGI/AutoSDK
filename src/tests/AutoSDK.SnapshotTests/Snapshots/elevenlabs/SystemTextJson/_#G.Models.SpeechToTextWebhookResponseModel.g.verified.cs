//HintName: G.Models.SpeechToTextWebhookResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"message":"Request accepted. Transcription result will be sent to the webhook endpoint.","request_id":"1234567890"}
    /// </summary>
    public sealed partial class SpeechToTextWebhookResponseModel
    {
        /// <summary>
        /// The message of the webhook response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The request ID of the webhook response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// The transcription ID of the webhook response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription_id")]
        public string? TranscriptionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextWebhookResponseModel" /> class.
        /// </summary>
        /// <param name="message">
        /// The message of the webhook response.
        /// </param>
        /// <param name="requestId">
        /// The request ID of the webhook response.
        /// </param>
        /// <param name="transcriptionId">
        /// The transcription ID of the webhook response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechToTextWebhookResponseModel(
            string message,
            string requestId,
            string? transcriptionId)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.TranscriptionId = transcriptionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextWebhookResponseModel" /> class.
        /// </summary>
        public SpeechToTextWebhookResponseModel()
        {
        }
    }
}