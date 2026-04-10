//HintName: G.Models.AgentPresenterVideoAvatar2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentPresenterVideoAvatar2
    {
        /// <summary>
        /// Presenter type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AgentPresenterVideoAvatarType2JsonConverter))]
        public global::G.AgentPresenterVideoAvatarType2 Type { get; set; }

        /// <summary>
        /// Voice provider for text-to-speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public global::G.AnyOf<global::G.AgentPresenterVideoAvatarVoiceMicrosoft2, global::G.AgentPresenterVideoAvatarVoiceElevenLabs2, global::G.AgentPresenterVideoAvatarVoiceOpenAI2>? Voice { get; set; }

        /// <summary>
        /// ID of the video avatar used by the Agent.  Retrieved from the GET/ presenters endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presenter_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PresenterId { get; set; } = default!;

        /// <summary>
        /// presenter background config
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background")]
        public global::G.AgentPresenterVideoAvatarBackground2? Background { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPresenterVideoAvatar2" /> class.
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
        public AgentPresenterVideoAvatar2(
            string presenterId,
            global::G.AgentPresenterVideoAvatarType2 type,
            global::G.AnyOf<global::G.AgentPresenterVideoAvatarVoiceMicrosoft2, global::G.AgentPresenterVideoAvatarVoiceElevenLabs2, global::G.AgentPresenterVideoAvatarVoiceOpenAI2>? voice,
            global::G.AgentPresenterVideoAvatarBackground2? background)
        {
            this.Type = type;
            this.Voice = voice;
            this.PresenterId = presenterId ?? throw new global::System.ArgumentNullException(nameof(presenterId));
            this.Background = background;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPresenterVideoAvatar2" /> class.
        /// </summary>
        public AgentPresenterVideoAvatar2()
        {
        }
    }
}