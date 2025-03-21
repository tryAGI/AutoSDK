//HintName: G.Models.RealtimeServerEventResponseContentPartDonePart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The content part that is done.
    /// </summary>
    public sealed partial class RealtimeServerEventResponseContentPartDonePart
    {
        /// <summary>
        /// Base64-encoded audio data (if type is "audio").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// The text content (if type is "text").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The transcript of the audio (if type is "audio").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// The content type ("text", "audio").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeServerEventResponseContentPartDonePartType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseContentPartDonePart" /> class.
        /// </summary>
        /// <param name="audio">
        /// Base64-encoded audio data (if type is "audio").
        /// </param>
        /// <param name="text">
        /// The text content (if type is "text").
        /// </param>
        /// <param name="transcript">
        /// The transcript of the audio (if type is "audio").
        /// </param>
        /// <param name="type">
        /// The content type ("text", "audio").
        /// </param>
        public RealtimeServerEventResponseContentPartDonePart(
            string? audio,
            string? text,
            string? transcript,
            global::G.RealtimeServerEventResponseContentPartDonePartType? type)
        {
            this.Audio = audio;
            this.Text = text;
            this.Transcript = transcript;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseContentPartDonePart" /> class.
        /// </summary>
        public RealtimeServerEventResponseContentPartDonePart()
        {
        }
    }
}