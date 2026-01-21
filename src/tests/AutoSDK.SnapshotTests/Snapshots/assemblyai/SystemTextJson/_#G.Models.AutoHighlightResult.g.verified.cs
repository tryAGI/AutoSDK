//HintName: G.Models.AutoHighlightResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"count":1,"rank":0.08,"text":"air quality alerts","timestamps":[{"start":3978,"end":5114}]}
    /// </summary>
    public sealed partial class AutoHighlightResult
    {
        /// <summary>
        /// The total number of times the key phrase appears in the audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// The total relevancy to the overall audio file of this key phrase - a greater number means more relevant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Rank { get; set; }

        /// <summary>
        /// The text itself of the key phrase
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The timestamp of the of the key phrase
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Timestamp> Timestamps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoHighlightResult" /> class.
        /// </summary>
        /// <param name="count">
        /// The total number of times the key phrase appears in the audio file
        /// </param>
        /// <param name="rank">
        /// The total relevancy to the overall audio file of this key phrase - a greater number means more relevant
        /// </param>
        /// <param name="text">
        /// The text itself of the key phrase
        /// </param>
        /// <param name="timestamps">
        /// The timestamp of the of the key phrase
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoHighlightResult(
            int count,
            float rank,
            string text,
            global::System.Collections.Generic.IList<global::G.Timestamp> timestamps)
        {
            this.Count = count;
            this.Rank = rank;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Timestamps = timestamps ?? throw new global::System.ArgumentNullException(nameof(timestamps));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoHighlightResult" /> class.
        /// </summary>
        public AutoHighlightResult()
        {
        }
    }
}