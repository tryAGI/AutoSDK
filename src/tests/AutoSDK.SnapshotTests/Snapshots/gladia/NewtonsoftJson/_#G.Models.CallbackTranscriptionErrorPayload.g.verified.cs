//HintName: G.Models.CallbackTranscriptionErrorPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallbackTranscriptionErrorPayload
    {
        /// <summary>
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </summary>
        /// <example>45463597-20b7-4af7-b3b3-f5fb778203ab</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Type of event<br/>
        /// Default Value: transcription.error<br/>
        /// Example: transcription.error
        /// </summary>
        /// <default>global::G.CallbackTranscriptionErrorPayloadEvent.TranscriptionError</default>
        /// <example>transcription.error</example>
        [global::Newtonsoft.Json.JsonProperty("event")]
        public global::G.CallbackTranscriptionErrorPayloadEvent Event { get; set; } = global::G.CallbackTranscriptionErrorPayloadEvent.TranscriptionError;

        /// <summary>
        /// The error that occurred during the transcription
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ErrorDTO Error { get; set; } = default!;

        /// <summary>
        /// Custom metadata given in the initial request<br/>
        /// Example: {"user":"John Doe"}
        /// </summary>
        /// <example>{"user":"John Doe"}</example>
        [global::Newtonsoft.Json.JsonProperty("custom_metadata")]
        public object? CustomMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackTranscriptionErrorPayload" /> class.
        /// </summary>
        /// <param name="id">
        /// Id of the job<br/>
        /// Example: 45463597-20b7-4af7-b3b3-f5fb778203ab
        /// </param>
        /// <param name="error">
        /// The error that occurred during the transcription
        /// </param>
        /// <param name="customMetadata">
        /// Custom metadata given in the initial request<br/>
        /// Example: {"user":"John Doe"}
        /// </param>
        /// <param name="event">
        /// Type of event<br/>
        /// Default Value: transcription.error<br/>
        /// Example: transcription.error
        /// </param>
        public CallbackTranscriptionErrorPayload(
            global::System.Guid id,
            global::G.ErrorDTO error,
            object? customMetadata,
            global::G.CallbackTranscriptionErrorPayloadEvent @event = global::G.CallbackTranscriptionErrorPayloadEvent.TranscriptionError)
        {
            this.Id = id;
            this.Event = @event;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.CustomMetadata = customMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackTranscriptionErrorPayload" /> class.
        /// </summary>
        public CallbackTranscriptionErrorPayload()
        {
        }
    }
}