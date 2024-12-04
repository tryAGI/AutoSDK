//HintName: G.Models.RealtimeServerEventResponseContentPartAddedPart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The content part that was added.
    /// </summary>
    public sealed partial class RealtimeServerEventResponseContentPartAddedPart
    {
        /// <summary>
        /// The content type ("text", "audio").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeServerEventResponseContentPartAddedPartTypeJsonConverter))]
        public global::G.RealtimeServerEventResponseContentPartAddedPartType? Type { get; set; }

        /// <summary>
        /// The text content (if type is "text").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Base64-encoded audio data (if type is "audio").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// The transcript of the audio (if type is "audio").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseContentPartAddedPart" /> class.
        /// </summary>
        /// <param name="type">
        /// The content type ("text", "audio").
        /// </param>
        /// <param name="text">
        /// The text content (if type is "text").
        /// </param>
        /// <param name="audio">
        /// Base64-encoded audio data (if type is "audio").
        /// </param>
        /// <param name="transcript">
        /// The transcript of the audio (if type is "audio").
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeServerEventResponseContentPartAddedPart(
            global::G.RealtimeServerEventResponseContentPartAddedPartType? type,
            string? text,
            string? audio,
            string? transcript)
        {
            this.Type = type;
            this.Text = text;
            this.Audio = audio;
            this.Transcript = transcript;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseContentPartAddedPart" /> class.
        /// </summary>
        public RealtimeServerEventResponseContentPartAddedPart()
        {
        }
    }
}