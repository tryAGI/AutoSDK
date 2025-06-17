//HintName: G.Models.SpeakerResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeakerResponseModel
    {
        /// <summary>
        /// The ID of the speaker.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaker_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SpeakerId { get; set; } = default!;

        /// <summary>
        /// The duration of the speaker segment in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public double DurationSecs { get; set; } = default!;

        /// <summary>
        /// The utterances of the speaker.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("utterances")]
        public global::System.Collections.Generic.IList<global::G.UtteranceResponseModel>? Utterances { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerResponseModel" /> class.
        /// </summary>
        /// <param name="speakerId">
        /// The ID of the speaker.
        /// </param>
        /// <param name="durationSecs">
        /// The duration of the speaker segment in seconds.
        /// </param>
        /// <param name="utterances">
        /// The utterances of the speaker.
        /// </param>
        public SpeakerResponseModel(
            string speakerId,
            double durationSecs,
            global::System.Collections.Generic.IList<global::G.UtteranceResponseModel>? utterances)
        {
            this.SpeakerId = speakerId ?? throw new global::System.ArgumentNullException(nameof(speakerId));
            this.DurationSecs = durationSecs;
            this.Utterances = utterances;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeakerResponseModel" /> class.
        /// </summary>
        public SpeakerResponseModel()
        {
        }
    }
}