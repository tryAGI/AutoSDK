//HintName: G.Models.ConversationItemContentPart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A content part within a conversation item.
    /// </summary>
    public sealed partial class ConversationItemContentPart
    {
        /// <summary>
        /// The content type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConversationItemContentPartTypeJsonConverter))]
        public global::G.ConversationItemContentPartType? Type { get; set; }

        /// <summary>
        /// The text content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Base64-encoded audio bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// The transcript of the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemContentPart" /> class.
        /// </summary>
        /// <param name="type">
        /// The content type.
        /// </param>
        /// <param name="text">
        /// The text content.
        /// </param>
        /// <param name="audio">
        /// Base64-encoded audio bytes.
        /// </param>
        /// <param name="transcript">
        /// The transcript of the audio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationItemContentPart(
            global::G.ConversationItemContentPartType? type,
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
        /// Initializes a new instance of the <see cref="ConversationItemContentPart" /> class.
        /// </summary>
        public ConversationItemContentPart()
        {
        }
    }
}