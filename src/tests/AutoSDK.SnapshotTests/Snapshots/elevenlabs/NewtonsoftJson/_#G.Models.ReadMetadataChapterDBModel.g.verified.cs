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
        [global::Newtonsoft.Json.JsonProperty("chapter_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ChapterName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("word_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int WordCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("char_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int CharCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("starting_char_offset", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartingCharOffset { get; set; } = default!;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_parsed_html")]
        public bool? HasParsedHtml { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_summary")]
        public bool? HasSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_seconds")]
        public double? DurationSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_number")]
        public string? FileNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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