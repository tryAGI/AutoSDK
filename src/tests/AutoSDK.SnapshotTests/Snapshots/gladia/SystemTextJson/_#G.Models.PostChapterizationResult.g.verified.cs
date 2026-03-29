//HintName: G.Models.PostChapterizationResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostChapterizationResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("abstractive_summary")]
        public string? AbstractiveSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extractive_summary")]
        public string? ExtractiveSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headline")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Headline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gist")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Gist { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keywords")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Keywords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double End { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentences")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChapterizationSentence> Sentences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostChapterizationResult" /> class.
        /// </summary>
        /// <param name="headline"></param>
        /// <param name="gist"></param>
        /// <param name="keywords"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="sentences"></param>
        /// <param name="text"></param>
        /// <param name="abstractiveSummary"></param>
        /// <param name="extractiveSummary"></param>
        /// <param name="summary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostChapterizationResult(
            string headline,
            string gist,
            global::System.Collections.Generic.IList<string> keywords,
            double start,
            double end,
            global::System.Collections.Generic.IList<global::G.ChapterizationSentence> sentences,
            string text,
            string? abstractiveSummary,
            string? extractiveSummary,
            string? summary)
        {
            this.AbstractiveSummary = abstractiveSummary;
            this.ExtractiveSummary = extractiveSummary;
            this.Summary = summary;
            this.Headline = headline ?? throw new global::System.ArgumentNullException(nameof(headline));
            this.Gist = gist ?? throw new global::System.ArgumentNullException(nameof(gist));
            this.Keywords = keywords ?? throw new global::System.ArgumentNullException(nameof(keywords));
            this.Start = start;
            this.End = end;
            this.Sentences = sentences ?? throw new global::System.ArgumentNullException(nameof(sentences));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostChapterizationResult" /> class.
        /// </summary>
        public PostChapterizationResult()
        {
        }
    }
}