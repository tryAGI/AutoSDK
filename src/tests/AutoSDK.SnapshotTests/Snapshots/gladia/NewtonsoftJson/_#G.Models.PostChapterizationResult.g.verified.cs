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
        [global::Newtonsoft.Json.JsonProperty("abstractive_summary")]
        public string? AbstractiveSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extractive_summary")]
        public string? ExtractiveSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headline", Required = global::Newtonsoft.Json.Required.Always)]
        public string Headline { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gist", Required = global::Newtonsoft.Json.Required.Always)]
        public string Gist { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keywords", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Keywords { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public double Start { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public double End { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentences", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChapterizationSentence> Sentences { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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