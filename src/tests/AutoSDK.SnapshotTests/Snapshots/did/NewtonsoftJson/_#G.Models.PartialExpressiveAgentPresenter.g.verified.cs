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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PartialExpressiveAgentPresenterType? Type { get; set; }

        /// <summary>
        /// Id of avatar that will be shown for user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presenter_id")]
        public string? PresenterId { get; set; }

        /// <summary>
        /// presenter background config
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background")]
        public global::G.PartialExpressiveAgentPresenterBackground? Background { get; set; }

        /// <summary>
        /// Voice provider for text-to-speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public global::G.AnyOf<global::G.PartialExpressiveAgentPresenterVoiceMicrosoft, global::G.PartialExpressiveAgentPresenterVoiceElevenLabs, global::G.PartialExpressiveAgentPresenterVoiceOpenAI>? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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