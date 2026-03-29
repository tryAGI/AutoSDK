//HintName: G.Models.AgentCreateDtoPresenterVideoAvatar.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentCreateDtoPresenterVideoAvatar
    {
        /// <summary>
        /// Presenter type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.AgentCreateDtoPresenterVideoAvatarType Type { get; set; }

        /// <summary>
        /// Voice provider for text-to-speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public global::G.AnyOf<global::G.AgentCreateDtoPresenterVideoAvatarVoiceMicrosoft, global::G.AgentCreateDtoPresenterVideoAvatarVoiceElevenLabs, global::G.AgentCreateDtoPresenterVideoAvatarVoiceOpenAI>? Voice { get; set; }

        /// <summary>
        /// ID of the video avatar used by the Agent.  Retrieved from the GET/ presenters endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presenter_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PresenterId { get; set; } = default!;

        /// <summary>
        /// presenter background config
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background")]
        public global::G.AgentCreateDtoPresenterVideoAvatarBackground? Background { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCreateDtoPresenterVideoAvatar" /> class.
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
        public AgentCreateDtoPresenterVideoAvatar(
            string presenterId,
            global::G.AgentCreateDtoPresenterVideoAvatarType type,
            global::G.AnyOf<global::G.AgentCreateDtoPresenterVideoAvatarVoiceMicrosoft, global::G.AgentCreateDtoPresenterVideoAvatarVoiceElevenLabs, global::G.AgentCreateDtoPresenterVideoAvatarVoiceOpenAI>? voice,
            global::G.AgentCreateDtoPresenterVideoAvatarBackground? background)
        {
            this.Type = type;
            this.Voice = voice;
            this.PresenterId = presenterId ?? throw new global::System.ArgumentNullException(nameof(presenterId));
            this.Background = background;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCreateDtoPresenterVideoAvatar" /> class.
        /// </summary>
        public AgentCreateDtoPresenterVideoAvatar()
        {
        }
    }
}