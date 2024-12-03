//HintName: G.Models.Chapter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Chapter of the audio file
    /// </summary>
    public sealed partial class Chapter
    {
        /// <summary>
        /// An ultra-short summary (just a few words) of the content spoken in the chapter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gist")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Gist { get; set; }

        /// <summary>
        /// A single sentence summary of the content spoken during the chapter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headline")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Headline { get; set; }

        /// <summary>
        /// A one paragraph summary of the content spoken during the chapter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Summary { get; set; }

        /// <summary>
        /// The starting time, in milliseconds, for the chapter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Start { get; set; }

        /// <summary>
        /// The starting time, in milliseconds, for the chapter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Chapter" /> class.
        /// </summary>
        /// <param name="gist">
        /// An ultra-short summary (just a few words) of the content spoken in the chapter
        /// </param>
        /// <param name="headline">
        /// A single sentence summary of the content spoken during the chapter
        /// </param>
        /// <param name="summary">
        /// A one paragraph summary of the content spoken during the chapter
        /// </param>
        /// <param name="start">
        /// The starting time, in milliseconds, for the chapter
        /// </param>
        /// <param name="end">
        /// The starting time, in milliseconds, for the chapter
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Chapter(
            string gist,
            string headline,
            string summary,
            int start,
            int end)
        {
            this.Gist = gist ?? throw new global::System.ArgumentNullException(nameof(gist));
            this.Headline = headline ?? throw new global::System.ArgumentNullException(nameof(headline));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chapter" /> class.
        /// </summary>
        public Chapter()
        {
        }
    }
}