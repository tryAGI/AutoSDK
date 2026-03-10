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
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// The request ID of the webhook response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestId { get; set; } = default!;

        /// <summary>
        /// The transcription ID of the webhook response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcription_id")]
        public string? TranscriptionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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