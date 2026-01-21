//HintName: G.Models.SpeakerResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"duration_secs":5,"speaker_id":"DCwhRBWXzGAHq8TQ4Fs18"}
    /// </summary>
    public sealed partial class SpeakerResponseModel
    {
        /// <summary>
        /// The ID of the speaker.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpeakerId { get; set; }

        /// <summary>
        /// The duration of the speaker segment in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DurationSecs { get; set; }

        /// <summary>
        /// The utterances of the speaker.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utterances")]
        public global::System.Collections.Generic.IList<global::G.UtteranceResponseModel>? Utterances { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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