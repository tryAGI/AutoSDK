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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpeakerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DurationSecs { get; set; }

        /// <summary>
        /// 
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
        /// <param name="speakerId"></param>
        /// <param name="durationSecs"></param>
        /// <param name="utterances"></param>
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