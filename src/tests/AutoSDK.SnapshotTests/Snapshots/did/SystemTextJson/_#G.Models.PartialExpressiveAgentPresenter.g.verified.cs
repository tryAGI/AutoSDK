//HintName: G.Models.PartialExpressiveAgentPresenter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialExpressiveAgentPresenter
    {
        /// <summary>
        /// Presenter type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PartialExpressiveAgentPresenterTypeJsonConverter))]
        public global::G.PartialExpressiveAgentPresenterType? Type { get; set; }

        /// <summary>
        /// Id of avatar that will be shown for user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presenter_id")]
        public string? PresenterId { get; set; }

        /// <summary>
        /// presenter background config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public global::G.PartialExpressiveAgentPresenterBackground? Background { get; set; }

        /// <summary>
        /// Voice provider for text-to-speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.PartialExpressiveAgentPresenterVoiceMicrosoft, global::G.PartialExpressiveAgentPresenterVoiceElevenLabs, global::G.PartialExpressiveAgentPresenterVoiceOpenAI>))]
        public global::G.AnyOf<global::G.PartialExpressiveAgentPresenterVoiceMicrosoft, global::G.PartialExpressiveAgentPresenterVoiceElevenLabs, global::G.PartialExpressiveAgentPresenterVoiceOpenAI>? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialExpressiveAgentPresenter" /> class.
        /// </summary>
        /// <param name="type">
        /// Presenter type
        /// </param>
        /// <param name="presenterId">
        /// Id of avatar that will be shown for user
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
        public PartialExpressiveAgentPresenter(
            global::G.PartialExpressiveAgentPresenterType? type,
            string? presenterId,
            global::G.PartialExpressiveAgentPresenterBackground? background,
            global::G.AnyOf<global::G.PartialExpressiveAgentPresenterVoiceMicrosoft, global::G.PartialExpressiveAgentPresenterVoiceElevenLabs, global::G.PartialExpressiveAgentPresenterVoiceOpenAI>? voice)
        {
            this.Type = type;
            this.PresenterId = presenterId;
            this.Background = background;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialExpressiveAgentPresenter" /> class.
        /// </summary>
        public PartialExpressiveAgentPresenter()
        {
        }
    }
}