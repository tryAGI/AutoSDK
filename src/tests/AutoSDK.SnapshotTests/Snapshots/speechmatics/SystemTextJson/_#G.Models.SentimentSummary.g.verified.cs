//HintName: G.Models.SentimentSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Holds overall sentiment information, as well as detailed per-speaker and per-channel sentiment data.
    /// </summary>
    public sealed partial class SentimentSummary
    {
        /// <summary>
        /// Holds the count of sentiment information grouped by positive, neutral and negative.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall")]
        public global::G.SentimentSummaryDetail? Overall { get; set; }

        /// <summary>
        /// An array of objects that represent sentiment data for a specific speaker.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speakers")]
        public global::System.Collections.Generic.IList<global::G.SentimentSpeakerSummary>? Speakers { get; set; }

        /// <summary>
        /// An array of objects that represent sentiment data for a specific channel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        public global::System.Collections.Generic.IList<global::G.SentimentChannelSummary>? Channels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentSummary" /> class.
        /// </summary>
        /// <param name="overall">
        /// Holds the count of sentiment information grouped by positive, neutral and negative.
        /// </param>
        /// <param name="speakers">
        /// An array of objects that represent sentiment data for a specific speaker.
        /// </param>
        /// <param name="channels">
        /// An array of objects that represent sentiment data for a specific channel.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SentimentSummary(
            global::G.SentimentSummaryDetail? overall,
            global::System.Collections.Generic.IList<global::G.SentimentSpeakerSummary>? speakers,
            global::System.Collections.Generic.IList<global::G.SentimentChannelSummary>? channels)
        {
            this.Overall = overall;
            this.Speakers = speakers;
            this.Channels = channels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentSummary" /> class.
        /// </summary>
        public SentimentSummary()
        {
        }
    }
}