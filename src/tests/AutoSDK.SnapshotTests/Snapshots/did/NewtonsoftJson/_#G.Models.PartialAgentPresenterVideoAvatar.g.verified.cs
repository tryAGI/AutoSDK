//HintName: G.Models.PartialAgentPresenterVideoAvatar.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialAgentPresenterVideoAvatar
    {
        /// <summary>
        /// Presenter type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PartialAgentPresenterVideoAvatarType? Type { get; set; }

        /// <summary>
        /// ID of the video avatar used by the Agent.  Retrieved from the GET/ presenters endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presenter_id")]
        public string? PresenterId { get; set; }

        /// <summary>
        /// presenter background config
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background")]
        public global::G.PartialAgentPresenterVideoAvatarBackground? Background { get; set; }

        /// <summary>
        /// Voice provider for text-to-speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public global::G.AnyOf<global::G.PartialAgentPresenterVideoAvatarVoiceMicrosoft, global::G.PartialAgentPresenterVideoAvatarVoiceElevenLabs, global::G.PartialAgentPresenterVideoAvatarVoiceOpenAI>? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialAgentPresenterVideoAvatar" /> class.
        /// </summary>
        /// <param name="type">
        /// Presenter type
        /// </param>
        /// <param name="presenterId">
        /// ID of the video avatar used by the Agent.  Retrieved from the GET/ presenters endpoint.
        /// </param>
        /// <param name="background">
        /// presenter background config
        /// </param>
        /// <param name="voice">
        /// Voice provider for text-to-speech.
        /// </param>
        public PartialAgentPresenterVideoAvatar(
            global::G.PartialAgentPresenterVideoAvatarType? type,
            string? presenterId,
            global::G.PartialAgentPresenterVideoAvatarBackground? background,
            global::G.AnyOf<global::G.PartialAgentPresenterVideoAvatarVoiceMicrosoft, global::G.PartialAgentPresenterVideoAvatarVoiceElevenLabs, global::G.PartialAgentPresenterVideoAvatarVoiceOpenAI>? voice)
        {
            this.Type = type;
            this.PresenterId = presenterId;
            this.Background = background;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialAgentPresenterVideoAvatar" /> class.
        /// </summary>
        public PartialAgentPresenterVideoAvatar()
        {
        }
    }
}