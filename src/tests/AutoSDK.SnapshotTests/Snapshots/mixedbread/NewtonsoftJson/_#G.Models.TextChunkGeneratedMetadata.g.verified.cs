//HintName: G.Models.TextChunkGeneratedMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextChunkGeneratedMetadata
    {
        /// <summary>
        /// Default Value: text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Default Value: text/plain
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextChunkGeneratedMetadata" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: text
        /// </param>
        /// <param name="fileType">
        /// Default Value: text/plain
        /// </param>
        /// <param name="language"></param>
        /// <param name="wordCount"></param>
        /// <param name="fileSize"></param>
        /// <param name="startLine">
        /// Default Value: 0
        /// </param>
        /// <param name="numLines">
        /// Default Value: 0
        /// </param>
        /// <param name="fileExtension"></param>
        public TextChunkGeneratedMetadata(
            string? type,
            string? fileType,
            string? language,
            int? wordCount,
            int? fileSize,
            int? startLine,
            int? numLines,
            string? fileExtension)
        {
            this.Type = type;
            this.FileType = fileType;
            this.Language = language;
            this.WordCount = wordCount;
            this.FileSize = fileSize;
            this.StartLine = startLine;
            this.NumLines = numLines;
            this.FileExtension = fileExtension;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextChunkGeneratedMetadata" /> class.
        /// </summary>
        public TextChunkGeneratedMetadata()
        {
        }
    }
}