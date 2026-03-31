//HintName: G.Models.AgentUpdateDtoPresenterPhotoAvatar.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class AgentUpdateDtoPresenterPhotoAvatar
    {
        /// <summary>
        /// Presenter type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentUpdateDtoPresenterPhotoAvatarTypeJsonConverter))]
        public global::G.AgentUpdateDtoPresenterPhotoAvatarType? Type { get; set; }

        /// <summary>
        /// Image URL used to create the avatar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// Preview image URL for the avatar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail")]
        public string? Thumbnail { get; set; }

        /// <summary>
        /// Controls the output framing.&lt;br/&gt;<br/>
        /// `true` - Original image framing<br/>
        /// `false` - Close-up framing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stitch")]
        public bool? Stitch { get; set; }

        /// <summary>
        /// Voice provider for text-to-speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.AgentUpdateDtoPresenterPhotoAvatarVoiceMicrosoft, global::G.AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabs, global::G.AgentUpdateDtoPresenterPhotoAvatarVoiceOpenAI>))]
        public global::G.AnyOf<global::G.AgentUpdateDtoPresenterPhotoAvatarVoiceMicrosoft, global::G.AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabs, global::G.AgentUpdateDtoPresenterPhotoAvatarVoiceOpenAI>? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentUpdateDtoPresenterPhotoAvatar" /> class.
        /// </summary>
        /// <param name="type">
        /// Presenter type
        /// </param>
        /// <param name="sourceUrl">
        /// Image URL used to create the avatar.
        /// </param>
        /// <param name="thumbnail">
        /// Preview image URL for the avatar.
        /// </param>
        /// <param name="stitch">
        /// Controls the output framing.&lt;br/&gt;<br/>
        /// `true` - Original image framing<br/>
        /// `false` - Close-up framing
        /// </param>
        /// <param name="voice">
        /// Voice provider for text-to-speech.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentUpdateDtoPresenterPhotoAvatar(
            global::G.AgentUpdateDtoPresenterPhotoAvatarType? type,
            string? sourceUrl,
            string? thumbnail,
            bool? stitch,
            global::G.AnyOf<global::G.AgentUpdateDtoPresenterPhotoAvatarVoiceMicrosoft, global::G.AgentUpdateDtoPresenterPhotoAvatarVoiceElevenLabs, global::G.AgentUpdateDtoPresenterPhotoAvatarVoiceOpenAI>? voice)
        {
            this.Type = type;
            this.SourceUrl = sourceUrl;
            this.Thumbnail = thumbnail;
            this.Stitch = stitch;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentUpdateDtoPresenterPhotoAvatar" /> class.
        /// </summary>
        public AgentUpdateDtoPresenterPhotoAvatar()
        {
        }
    }
}