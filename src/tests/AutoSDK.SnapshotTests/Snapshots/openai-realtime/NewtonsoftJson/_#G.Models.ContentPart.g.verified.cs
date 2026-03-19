//HintName: G.Models.ContentPart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A content part in a response.
    /// </summary>
    public sealed partial class ContentPart
    {
        /// <summary>
        /// The content type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ContentPartType? Type { get; set; }

        /// <summary>
        /// The text content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Base64-encoded audio data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// The transcript of the audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentPart" /> class.
        /// </summary>
        /// <param name="type">
        /// The content type.
        /// </param>
        /// <param name="text">
        /// The text content.
        /// </param>
        /// <param name="audio">
        /// Base64-encoded audio data.
        /// </param>
        /// <param name="transcript">
        /// The transcript of the audio.
        /// </param>
        public ContentPart(
            global::G.ContentPartType? type,
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
        /// Initializes a new instance of the <see cref="ContentPart" /> class.
        /// </summary>
        public ContentPart()
        {
        }
    }
}