//HintName: G.Models.MarkdownChunkGeneratedMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MarkdownChunkGeneratedMetadata
    {
        /// <summary>
        /// Default Value: markdown
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Default Value: text/markdown
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_type")]
        public string? FileType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("word_count")]
        public int? WordCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_size")]
        public int? FileSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk_headings")]
        public global::System.Collections.Generic.IList<global::G.MarkdownHeading>? ChunkHeadings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("heading_context")]
        public global::System.Collections.Generic.IList<global::G.MarkdownHeading>? HeadingContext { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_line")]
        public int? StartLine { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_lines")]
        public int? NumLines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_extension")]
        public string? FileExtension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frontmatter")]
        public object? Frontmatter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownChunkGeneratedMetadata" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: markdown
        /// </param>
        /// <param name="fileType">
        /// Default Value: text/markdown
        /// </param>
        /// <param name="language"></param>
        /// <param name="wordCount"></param>
        /// <param name="fileSize"></param>
        /// <param name="chunkHeadings"></param>
        /// <param name="headingContext"></param>
        /// <param name="startLine">
        /// Default Value: 0
        /// </param>
        /// <param name="numLines">
        /// Default Value: 0
        /// </param>
        /// <param name="fileExtension"></param>
        /// <param name="frontmatter"></param>
        public MarkdownChunkGeneratedMetadata(
            string? type,
            string? fileType,
            string? language,
            int? wordCount,
            int? fileSize,
            global::System.Collections.Generic.IList<global::G.MarkdownHeading>? chunkHeadings,
            global::System.Collections.Generic.IList<global::G.MarkdownHeading>? headingContext,
            int? startLine,
            int? numLines,
            string? fileExtension,
            object? frontmatter)
        {
            this.Type = type;
            this.FileType = fileType;
            this.Language = language;
            this.WordCount = wordCount;
            this.FileSize = fileSize;
            this.ChunkHeadings = chunkHeadings;
            this.HeadingContext = headingContext;
            this.StartLine = startLine;
            this.NumLines = numLines;
            this.FileExtension = fileExtension;
            this.Frontmatter = frontmatter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownChunkGeneratedMetadata" /> class.
        /// </summary>
        public MarkdownChunkGeneratedMetadata()
        {
        }
    }
}