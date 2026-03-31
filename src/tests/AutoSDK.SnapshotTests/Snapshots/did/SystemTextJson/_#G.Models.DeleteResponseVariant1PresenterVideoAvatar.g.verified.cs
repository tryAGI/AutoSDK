//HintName: G.Models.DeleteResponseVariant1PresenterVideoAvatar.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteResponseVariant1PresenterVideoAvatar
    {
        /// <summary>
        /// Presenter type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DeleteResponseVariant1PresenterVideoAvatarTypeJsonConverter))]
        public global::G.DeleteResponseVariant1PresenterVideoAvatarType Type { get; set; }

        /// <summary>
        /// Voice provider for text-to-speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::G.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::G.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAI>))]
        public global::G.AnyOf<global::G.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::G.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::G.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAI>? Voice { get; set; }

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
        public global::G.DeleteResponseVariant1PresenterVideoAvatarBackground? Background { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteResponseVariant1PresenterVideoAvatar" /> class.
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
        public DeleteResponseVariant1PresenterVideoAvatar(
            string presenterId,
            global::G.DeleteResponseVariant1PresenterVideoAvatarType type,
            global::G.AnyOf<global::G.DeleteResponseVariant1PresenterVideoAvatarVoiceMicrosoft, global::G.DeleteResponseVariant1PresenterVideoAvatarVoiceElevenLabs, global::G.DeleteResponseVariant1PresenterVideoAvatarVoiceOpenAI>? voice,
            global::G.DeleteResponseVariant1PresenterVideoAvatarBackground? background)
        {
            this.Type = type;
            this.Voice = voice;
            this.PresenterId = presenterId ?? throw new global::System.ArgumentNullException(nameof(presenterId));
            this.Background = background;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteResponseVariant1PresenterVideoAvatar" /> class.
        /// </summary>
        public DeleteResponseVariant1PresenterVideoAvatar()
        {
        }
    }
}