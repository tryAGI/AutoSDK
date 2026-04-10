//HintName: G.Models.AgentPresenterExpressiveAvatar2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentPresenterExpressiveAvatar2
    {
        /// <summary>
        /// Presenter type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AgentPresenterExpressiveAvatarType2JsonConverter))]
        public global::G.AgentPresenterExpressiveAvatarType2 Type { get; set; }

        /// <summary>
        /// Voice provider for text-to-speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public global::G.AnyOf<global::G.AgentPresenterExpressiveAvatarVoiceMicrosoft2, global::G.AgentPresenterExpressiveAvatarVoiceElevenLabs2, global::G.AgentPresenterExpressiveAvatarVoiceOpenAI2>? Voice { get; set; }

        /// <summary>
        /// Id of avatar that will be shown for user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presenter_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PresenterId { get; set; } = default!;

        /// <summary>
        /// presenter background config
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background")]
        public global::G.AgentPresenterExpressiveAvatarBackground2? Background { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPresenterExpressiveAvatar2" /> class.
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
        public AgentPresenterExpressiveAvatar2(
            string presenterId,
            global::G.AgentPresenterExpressiveAvatarType2 type,
            global::G.AnyOf<global::G.AgentPresenterExpressiveAvatarVoiceMicrosoft2, global::G.AgentPresenterExpressiveAvatarVoiceElevenLabs2, global::G.AgentPresenterExpressiveAvatarVoiceOpenAI2>? voice,
            global::G.AgentPresenterExpressiveAvatarBackground2? background)
        {
            this.Type = type;
            this.Voice = voice;
            this.PresenterId = presenterId ?? throw new global::System.ArgumentNullException(nameof(presenterId));
            this.Background = background;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPresenterExpressiveAvatar2" /> class.
        /// </summary>
        public AgentPresenterExpressiveAvatar2()
        {
        }
    }
}