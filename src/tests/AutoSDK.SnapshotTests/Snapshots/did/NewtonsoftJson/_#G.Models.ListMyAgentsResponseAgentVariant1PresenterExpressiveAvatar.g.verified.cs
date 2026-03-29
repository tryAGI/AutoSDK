//HintName: G.Models.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatar.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatar
    {
        /// <summary>
        /// Presenter type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarType Type { get; set; }

        /// <summary>
        /// Voice provider for text-to-speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public global::G.AnyOf<global::G.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::G.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::G.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAI>? Voice { get; set; }

        /// <summary>
        /// Id of avatar that will be shown for user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presenter_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PresenterId { get; set; } = default!;

        /// <summary>
        /// presenter background config
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background")]
        public global::G.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarBackground? Background { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatar" /> class.
        /// </summary>
        /// <param name="presenterId">
        /// Id of avatar that will be shown for user
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
        public ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatar(
            string presenterId,
            global::G.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarType type,
            global::G.AnyOf<global::G.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::G.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::G.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAI>? voice,
            global::G.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarBackground? background)
        {
            this.Type = type;
            this.Voice = voice;
            this.PresenterId = presenterId ?? throw new global::System.ArgumentNullException(nameof(presenterId));
            this.Background = background;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatar" /> class.
        /// </summary>
        public ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatar()
        {
        }
    }
}