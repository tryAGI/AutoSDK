//HintName: G.Models.CallbackTranscriptionSuccessPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallbackTranscriptionSuccessPayload
    {
        /// <summary>
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </summary>
        /// <example>45463597-20b7-4af7-b3b3-f5fb778203ab</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Type of event<br/>
        /// Default Value: transcription.success<br/>
        /// Example: transcription.success
        /// </summary>
        /// <default>global::G.CallbackTranscriptionSuccessPayloadEvent.TranscriptionSuccess</default>
        /// <example>transcription.success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CallbackTranscriptionSuccessPayloadEventJsonConverter))]
        public global::G.CallbackTranscriptionSuccessPayloadEvent Event { get; set; } = global::G.CallbackTranscriptionSuccessPayloadEvent.TranscriptionSuccess;

        /// <summary>
        /// Result of the transcription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TranscriptionResultDTO Payload { get; set; }

        /// <summary>
        /// Custom metadata given in the initial request<br/>
        /// Example: {"user":"John Doe"}
        /// </summary>
        /// <example>{"user":"John Doe"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_metadata")]
        public object? CustomMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackTranscriptionSuccessPayload" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </param>
        /// <param name="payload">
        /// Result of the transcription
        /// </param>
        /// <param name="customMetadata">
        /// Custom metadata given in the initial request<br/>
        /// Example: {"user":"John Doe"}
        /// </param>
        /// <param name="event">
        /// Type of event<br/>
        /// Default Value: transcription.success<br/>
        /// Example: transcription.success
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallbackTranscriptionSuccessPayload(
            global::System.Guid id,
            global::G.TranscriptionResultDTO payload,
            object? customMetadata,
            global::G.CallbackTranscriptionSuccessPayloadEvent @event = global::G.CallbackTranscriptionSuccessPayloadEvent.TranscriptionSuccess)
        {
            this.Id = id;
            this.Event = @event;
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
            this.CustomMetadata = customMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackTranscriptionSuccessPayload" /> class.
        /// </summary>
        public CallbackTranscriptionSuccessPayload()
        {
        }
    }
}