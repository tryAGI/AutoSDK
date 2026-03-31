//HintName: G.Models.CreateResponseVariant1PresenterExpressiveAvatar.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateResponseVariant1PresenterExpressiveAvatar
    {
        /// <summary>
        /// Presenter type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateResponseVariant1PresenterExpressiveAvatarTypeJsonConverter))]
        public global::G.CreateResponseVariant1PresenterExpressiveAvatarType Type { get; set; }

        /// <summary>
        /// Voice provider for text-to-speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::G.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::G.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>))]
        public global::G.AnyOf<global::G.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::G.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::G.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>? Voice { get; set; }

        /// <summary>
        /// Id of avatar that will be shown for user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presenter_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PresenterId { get; set; }

        /// <summary>
        /// presenter background config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public global::G.CreateResponseVariant1PresenterExpressiveAvatarBackground? Background { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseVariant1PresenterExpressiveAvatar" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateResponseVariant1PresenterExpressiveAvatar(
            string presenterId,
            global::G.CreateResponseVariant1PresenterExpressiveAvatarType type,
            global::G.AnyOf<global::G.CreateResponseVariant1PresenterExpressiveAvatarVoiceMicrosoft, global::G.CreateResponseVariant1PresenterExpressiveAvatarVoiceElevenLabs, global::G.CreateResponseVariant1PresenterExpressiveAvatarVoiceOpenAI>? voice,
            global::G.CreateResponseVariant1PresenterExpressiveAvatarBackground? background)
        {
            this.Type = type;
            this.Voice = voice;
            this.PresenterId = presenterId ?? throw new global::System.ArgumentNullException(nameof(presenterId));
            this.Background = background;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseVariant1PresenterExpressiveAvatar" /> class.
        /// </summary>
        public CreateResponseVariant1PresenterExpressiveAvatar()
        {
        }
    }
}