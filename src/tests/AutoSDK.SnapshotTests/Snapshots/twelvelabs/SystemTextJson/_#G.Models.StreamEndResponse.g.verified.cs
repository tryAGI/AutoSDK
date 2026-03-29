//HintName: G.Models.StreamEndResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates the end of the stream.
    /// </summary>
    public sealed partial class StreamEndResponse
    {
        /// <summary>
        /// This field is always set to `stream_end` for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StreamEndResponseEventTypeJsonConverter))]
        public global::G.StreamEndResponseEventType EventType { get; set; }

        /// <summary>
        /// The reason for the generation to finish.<br/>
        /// - `stop`: The generation stopped because the model reached the end of the output text.<br/>
        /// - `length`: The generation stopped because the model reached the maximum number of tokens. For JSON responses, this may result in truncated, invalid JSON that fails to parse.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FinishReasonJsonConverter))]
        public global::G.FinishReason? FinishReason { get; set; }

        /// <summary>
        /// An object containing metadata about the stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.StreamEndResponseMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamEndResponse" /> class.
        /// </summary>
        /// <param name="eventType">
        /// This field is always set to `stream_end` for this event.
        /// </param>
        /// <param name="finishReason">
        /// The reason for the generation to finish.<br/>
        /// - `stop`: The generation stopped because the model reached the end of the output text.<br/>
        /// - `length`: The generation stopped because the model reached the maximum number of tokens. For JSON responses, this may result in truncated, invalid JSON that fails to parse.
        /// </param>
        /// <param name="metadata">
        /// An object containing metadata about the stream.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamEndResponse(
            global::G.StreamEndResponseEventType eventType,
            global::G.FinishReason? finishReason,
            global::G.StreamEndResponseMetadata? metadata)
        {
            this.EventType = eventType;
            this.FinishReason = finishReason;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamEndResponse" /> class.
        /// </summary>
        public StreamEndResponse()
        {
        }
    }
}