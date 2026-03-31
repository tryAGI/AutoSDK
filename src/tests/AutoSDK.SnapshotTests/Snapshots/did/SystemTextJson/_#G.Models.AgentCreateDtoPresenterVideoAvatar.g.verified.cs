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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentCreateDtoPresenterVideoAvatarTypeJsonConverter))]
        public global::G.AgentCreateDtoPresenterVideoAvatarType Type { get; set; }

        /// <summary>
        /// Voice provider for text-to-speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.AgentCreateDtoPresenterVideoAvatarVoiceMicrosoft, global::G.AgentCreateDtoPresenterVideoAvatarVoiceElevenLabs, global::G.AgentCreateDtoPresenterVideoAvatarVoiceOpenAI>))]
        public global::G.AnyOf<global::G.AgentCreateDtoPresenterVideoAvatarVoiceMicrosoft, global::G.AgentCreateDtoPresenterVideoAvatarVoiceElevenLabs, global::G.AgentCreateDtoPresenterVideoAvatarVoiceOpenAI>? Voice { get; set; }

        /// <summary>
        /// ID of the video avatar used by the Agent.  Retrieved from the GET/ presenters endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presenter_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PresenterId { get; set; }

        /// <summary>
        /// presenter background config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public global::G.AgentCreateDtoPresenterVideoAvatarBackground? Background { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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