//HintName: G.Models.BodySpeechToTextV1SpeechToTextPostWebhookId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional specific webhook ID to send the transcription result to. Only valid when webhook is set to true. If not provided, transcription will be sent to all configured speech-to-text webhooks.
    /// </summary>
    public sealed partial class BodySpeechToTextV1SpeechToTextPostWebhookId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}