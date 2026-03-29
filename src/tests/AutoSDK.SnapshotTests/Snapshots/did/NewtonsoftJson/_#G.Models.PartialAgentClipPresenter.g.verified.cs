//HintName: G.Models.PartialAgentClipPresenter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialAgentClipPresenter
    {
        /// <summary>
        /// Presenter type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PartialAgentClipPresenterType? Type { get; set; }

        /// <summary>
        /// ID of the video avatar used by the Agent.  Retrieved from the GET/ presenters endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presenter_id")]
        public string? PresenterId { get; set; }

        /// <summary>
        /// presenter background config
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background")]
        public global::G.PartialAgentClipPresenterBackground? Background { get; set; }

        /// <summary>
        /// Voice provider for text-to-speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public global::G.AnyOf<global::G.PartialAgentClipPresenterVoiceMicrosoft, global::G.PartialAgentClipPresenterVoiceElevenLabs, global::G.PartialAgentClipPresenterVoiceOpenAI>? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialAgentClipPresenter" /> class.
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
        public PartialAgentClipPresenter(
            global::G.PartialAgentClipPresenterType? type,
            string? presenterId,
            global::G.PartialAgentClipPresenterBackground? background,
            global::G.AnyOf<global::G.PartialAgentClipPresenterVoiceMicrosoft, global::G.PartialAgentClipPresenterVoiceElevenLabs, global::G.PartialAgentClipPresenterVoiceOpenAI>? voice)
        {
            this.Type = type;
            this.PresenterId = presenterId;
            this.Background = background;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialAgentClipPresenter" /> class.
        /// </summary>
        public PartialAgentClipPresenter()
        {
        }
    }
}