//HintName: G.Models.ContentSafetyLabelResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentSafetyLabelResult
    {
        /// <summary>
        /// The transcript of the section flagged by the Content Moderation model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// An array of safety labels, one per sensitive topic that was detected in the section
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ContentSafetyLabel> Labels { get; set; } = default!;

        /// <summary>
        /// The sentence index at which the section begins
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentences_idx_start", Required = global::Newtonsoft.Json.Required.Always)]
        public int SentencesIdxStart { get; set; } = default!;

        /// <summary>
        /// The sentence index at which the section ends
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentences_idx_end", Required = global::Newtonsoft.Json.Required.Always)]
        public int SentencesIdxEnd { get; set; } = default!;

        /// <summary>
        /// Timestamp containing a start and end property in milliseconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Timestamp Timestamp { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// Timestamp containing a start and end property in milliseconds
        /// </param>
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