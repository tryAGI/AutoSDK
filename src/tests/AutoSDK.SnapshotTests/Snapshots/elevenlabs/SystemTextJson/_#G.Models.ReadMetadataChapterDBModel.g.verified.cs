//HintName: G.Models.ReadMetadataChapterDBModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReadMetadataChapterDBModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chapter_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChapterName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WordCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("char_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CharCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starting_char_offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartingCharOffset { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_parsed_html")]
        public bool? HasParsedHtml { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_summary")]
        public bool? HasSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_seconds")]
        public double? DurationSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_number")]
        public string? FileNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadMetadataChapterDBModel" /> class.
        /// </summary>
        /// <param name="chapterName"></param>
        /// <param name="wordCount"></param>
        /// <param name="charCount"></param>
        /// <param name="startingCharOffset"></param>
        /// <param name="hasParsedHtml">
        /// Default Value: false
        /// </param>
        /// <param name="hasSummary">
        /// Default Value: false
        /// </param>
        /// <param name="durationSeconds"></param>
        /// <param name="fileNumber"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReadMetadataChapterDBModel(
            string chapterName,
            int wordCount,
            int charCount,
            int startingCharOffset,
            bool? hasParsedHtml,
            bool? hasSummary,
            double? durationSeconds,
            string? fileNumber)
        {
            this.ChapterName = chapterName ?? throw new global::System.ArgumentNullException(nameof(chapterName));
            this.WordCount = wordCount;
            this.CharCount = charCount;
            this.StartingCharOffset = startingCharOffset;
            this.HasParsedHtml = hasParsedHtml;
            this.HasSummary = hasSummary;
            this.DurationSeconds = durationSeconds;
            this.FileNumber = fileNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadMetadataChapterDBModel" /> class.
        /// </summary>
        public ReadMetadataChapterDBModel()
        {
        }
    }
}