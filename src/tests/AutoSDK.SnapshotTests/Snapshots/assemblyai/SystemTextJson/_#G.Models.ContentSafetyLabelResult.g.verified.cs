//HintName: G.Models.ContentSafetyLabelResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"text":"Smoke from hundreds of wildfires in Canada is triggering air quality alerts throughout the US. Skylines from Maine to Maryland to Minnesota are gray and smoggy. And in some places, the air quality warnings include the warning to stay inside. We wanted to better understand what\u0027s happening here and why, so we called Peter de Carlo, an associate professor in the Department of Environmental Health and Engineering at Johns Hopkins University Varsity. Good morning, professor. Good morning.","labels":[{"label":"disasters","confidence":0.8142836093902588,"severity":0.4093044400215149}],"sentences_idx_start":0,"sentences_idx_end":5,"timestamp":{"start":250,"end":28840}}
    /// </summary>
    public sealed partial class ContentSafetyLabelResult
    {
        /// <summary>
        /// The transcript of the section flagged by the Content Moderation model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// An array of safety labels, one per sensitive topic that was detected in the section
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ContentSafetyLabel> Labels { get; set; }

        /// <summary>
        /// The sentence index at which the section begins
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentences_idx_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SentencesIdxStart { get; set; }

        /// <summary>
        /// The sentence index at which the section ends
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentences_idx_end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SentencesIdxEnd { get; set; }

        /// <summary>
        /// Timestamp containing a start and end property in milliseconds<br/>
        /// Example: {"start":3978,"end":5114}
        /// </summary>
        /// <example>{"start":3978,"end":5114}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Timestamp Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentSafetyLabelResult" /> class.
        /// </summary>
        /// <param name="text">
        /// The transcript of the section flagged by the Content Moderation model
        /// </param>
        /// <param name="labels">
        /// An array of safety labels, one per sensitive topic that was detected in the section
        /// </param>
        /// <param name="sentencesIdxStart">
        /// The sentence index at which the section begins
        /// </param>
        /// <param name="sentencesIdxEnd">
        /// The sentence index at which the section ends
        /// </param>
        /// <param name="timestamp">
        /// Timestamp containing a start and end property in milliseconds<br/>
        /// Example: {"start":3978,"end":5114}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentSafetyLabelResult(
            string text,
            global::System.Collections.Generic.IList<global::G.ContentSafetyLabel> labels,
            int sentencesIdxStart,
            int sentencesIdxEnd,
            global::G.Timestamp timestamp)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.SentencesIdxStart = sentencesIdxStart;
            this.SentencesIdxEnd = sentencesIdxEnd;
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentSafetyLabelResult" /> class.
        /// </summary>
        public ContentSafetyLabelResult()
        {
        }
    }
}