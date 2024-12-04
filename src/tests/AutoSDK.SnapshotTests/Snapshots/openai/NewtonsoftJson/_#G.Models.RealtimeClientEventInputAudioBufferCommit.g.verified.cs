//HintName: G.Models.RealtimeClientEventInputAudioBufferCommit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send this event to commit the user input audio buffer, which will create a <br/>
    /// new user message item in the conversation. This event will produce an error <br/>
    /// if the input audio buffer is empty. When in Server VAD mode, the client does <br/>
    /// not need to send this event, the server will commit the audio buffer <br/>
    /// automatically.<br/>
    /// Committing the input audio buffer will trigger input audio transcription <br/>
    /// (if enabled in session configuration), but it will not create a response <br/>
    /// from the model. The server will respond with an `input_audio_buffer.committed` <br/>
    /// event.
    /// </summary>
    public sealed partial class RealtimeClientEventInputAudioBufferCommit
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be `input_audio_buffer.commit`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeClientEventInputAudioBufferCommitType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventInputAudioBufferCommit" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `input_audio_buffer.commit`.
        /// </param>
        public RealtimeClientEventInputAudioBufferCommit(
            string? eventId,
            global::G.RealtimeClientEventInputAudioBufferCommitType type)
        {
            this.EventId = eventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventInputAudioBufferCommit" /> class.
        /// </summary>
        public RealtimeClientEventInputAudioBufferCommit()
        {
        }
    }
}