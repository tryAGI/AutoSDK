//HintName: G.Models.RetrieveTranscriptResponseAudioEventSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Summary statistics per event type, keyed by `type`, e.g. music
    /// </summary>
    public sealed partial class RetrieveTranscriptResponseAudioEventSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall")]
        public global::System.Collections.Generic.Dictionary<string, global::G.AudioEventSummaryItem>? Overall { get; set; }

        /// <summary>
        /// Summary keyed by channel, only set if channel diarization is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::G.AudioEventSummaryItem>>? Channels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveTranscriptResponseAudioEventSummary" /> class.
        /// </summary>
        /// <param name="overall"></param>
        /// <param name="channels">
        /// Summary keyed by channel, only set if channel diarization is enabled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrieveTranscriptResponseAudioEventSummary(
            global::System.Collections.Generic.Dictionary<string, global::G.AudioEventSummaryItem>? overall,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, global::G.AudioEventSummaryItem>>? channels)
        {
            this.Overall = overall;
            this.Channels = channels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveTranscriptResponseAudioEventSummary" /> class.
        /// </summary>
        public RetrieveTranscriptResponseAudioEventSummary()
        {
        }
    }
}