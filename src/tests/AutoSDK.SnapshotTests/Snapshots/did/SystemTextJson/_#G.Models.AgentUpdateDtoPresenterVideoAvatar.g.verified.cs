//HintName: G.Models.AgentUpdateDtoPresenterVideoAvatar.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class AgentUpdateDtoPresenterVideoAvatar
    {
        /// <summary>
        /// Presenter type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentUpdateDtoPresenterVideoAvatarTypeJsonConverter))]
        public global::G.AgentUpdateDtoPresenterVideoAvatarType? Type { get; set; }

        /// <summary>
        /// ID of the video avatar used by the Agent.  Retrieved from the GET/ presenters endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presenter_id")]
        public string? PresenterId { get; set; }

        /// <summary>
        /// presenter background config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public global::G.AgentUpdateDtoPresenterVideoAvatarBackground? Background { get; set; }

        /// <summary>
        /// Voice provider for text-to-speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.AgentUpdateDtoPresenterVideoAvatarVoiceMicrosoft, global::G.AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabs, global::G.AgentUpdateDtoPresenterVideoAvatarVoiceOpenAI>))]
        public global::G.AnyOf<global::G.AgentUpdateDtoPresenterVideoAvatarVoiceMicrosoft, global::G.AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabs, global::G.AgentUpdateDtoPresenterVideoAvatarVoiceOpenAI>? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentUpdateDtoPresenterVideoAvatar" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentUpdateDtoPresenterVideoAvatar(
            global::G.AgentUpdateDtoPresenterVideoAvatarType? type,
            string? presenterId,
            global::G.AgentUpdateDtoPresenterVideoAvatarBackground? background,
            global::G.AnyOf<global::G.AgentUpdateDtoPresenterVideoAvatarVoiceMicrosoft, global::G.AgentUpdateDtoPresenterVideoAvatarVoiceElevenLabs, global::G.AgentUpdateDtoPresenterVideoAvatarVoiceOpenAI>? voice)
        {
            this.Type = type;
            this.PresenterId = presenterId;
            this.Background = background;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentUpdateDtoPresenterVideoAvatar" /> class.
        /// </summary>
        public AgentUpdateDtoPresenterVideoAvatar()
        {
        }
    }
}