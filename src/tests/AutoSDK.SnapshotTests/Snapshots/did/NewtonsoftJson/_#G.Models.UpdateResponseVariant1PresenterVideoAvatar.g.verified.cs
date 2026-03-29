//HintName: G.Models.UpdateResponseVariant1PresenterVideoAvatar.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateResponseVariant1PresenterVideoAvatar
    {
        /// <summary>
        /// Presenter type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.UpdateResponseVariant1PresenterVideoAvatarType Type { get; set; }

        /// <summary>
        /// Voice provider for text-to-speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public global::G.AnyOf<global::G.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::G.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::G.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAI>? Voice { get; set; }

        /// <summary>
        /// ID of the video avatar used by the Agent.  Retrieved from the GET/ presenters endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presenter_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PresenterId { get; set; } = default!;

        /// <summary>
        /// presenter background config
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background")]
        public global::G.UpdateResponseVariant1PresenterVideoAvatarBackground? Background { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResponseVariant1PresenterVideoAvatar" /> class.
        /// </summary>
        /// <param name="presenterId">
        /// ID of the video avatar used by the Agent.  Retrieved from the GET/ presenters endpoint.
        /// </param>
        /// <param name="type">
        /// Presenter type
        /// </param>
        /// <param name="voice">
        /// Voice provider for text-to-speech.
        /// </param>
        /// <param name="background">
        /// presenter background config
        /// </param>
        public UpdateResponseVariant1PresenterVideoAvatar(
            string presenterId,
            global::G.UpdateResponseVariant1PresenterVideoAvatarType type,
            global::G.AnyOf<global::G.UpdateResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::G.UpdateResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::G.UpdateResponseVariant1PresenterVideoAvatarVoiceOpenAI>? voice,
            global::G.UpdateResponseVariant1PresenterVideoAvatarBackground? background)
        {
            this.Type = type;
            this.Voice = voice;
            this.PresenterId = presenterId ?? throw new global::System.ArgumentNullException(nameof(presenterId));
            this.Background = background;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResponseVariant1PresenterVideoAvatar" /> class.
        /// </summary>
        public UpdateResponseVariant1PresenterVideoAvatar()
        {
        }
    }
}