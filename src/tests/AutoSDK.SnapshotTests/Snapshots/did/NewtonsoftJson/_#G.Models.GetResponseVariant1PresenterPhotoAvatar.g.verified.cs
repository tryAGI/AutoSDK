//HintName: G.Models.GetResponseVariant1PresenterPhotoAvatar.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetResponseVariant1PresenterPhotoAvatar
    {
        /// <summary>
        /// Presenter type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.GetResponseVariant1PresenterPhotoAvatarType Type { get; set; }

        /// <summary>
        /// Voice provider for text-to-speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public global::G.AnyOf<global::G.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::G.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::G.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAI>? Voice { get; set; }

        /// <summary>
        /// Image URL used to create the avatar.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceUrl { get; set; } = default!;

        /// <summary>
        /// Preview image URL for the avatar.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail", Required = global::Newtonsoft.Json.Required.Always)]
        public string Thumbnail { get; set; } = default!;

        /// <summary>
        /// Controls the output framing.&lt;br/&gt;<br/>
        /// `true` - Original image framing<br/>
        /// `false` - Close-up framing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stitch")]
        public bool? Stitch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetResponseVariant1PresenterPhotoAvatar" /> class.
        /// </summary>
        /// <param name="sourceUrl">
        /// Image URL used to create the avatar.
        /// </param>
        /// <param name="thumbnail">
        /// Preview image URL for the avatar.
        /// </param>
        /// <param name="type">
        /// Presenter type
        /// </param>
        /// <param name="voice">
        /// Voice provider for text-to-speech.
        /// </param>
        /// <param name="stitch">
        /// Controls the output framing.&lt;br/&gt;<br/>
        /// `true` - Original image framing<br/>
        /// `false` - Close-up framing
        /// </param>
        public GetResponseVariant1PresenterPhotoAvatar(
            string sourceUrl,
            string thumbnail,
            global::G.GetResponseVariant1PresenterPhotoAvatarType type,
            global::G.AnyOf<global::G.GetResponseVariant1PresenterPhotoAvatarVoiceMicrosoft, global::G.GetResponseVariant1PresenterPhotoAvatarVoiceElevenLabs, global::G.GetResponseVariant1PresenterPhotoAvatarVoiceOpenAI>? voice,
            bool? stitch)
        {
            this.Type = type;
            this.Voice = voice;
            this.SourceUrl = sourceUrl ?? throw new global::System.ArgumentNullException(nameof(sourceUrl));
            this.Thumbnail = thumbnail ?? throw new global::System.ArgumentNullException(nameof(thumbnail));
            this.Stitch = stitch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetResponseVariant1PresenterPhotoAvatar" /> class.
        /// </summary>
        public GetResponseVariant1PresenterPhotoAvatar()
        {
        }
    }
}