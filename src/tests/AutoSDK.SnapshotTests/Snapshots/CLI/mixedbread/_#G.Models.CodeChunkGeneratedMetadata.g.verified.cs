//HintName: G.Models.CodeChunkGeneratedMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeChunkGeneratedMetadata
    {
        /// <summary>
        /// Default Value: code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_count")]
        public int? WordCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_size")]
        public int? FileSize { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_line")]
        public int? StartLine { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_lines")]
        public int? NumLines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_extension")]
        public string? FileExtension { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeChunkGeneratedMetadata" /> class.
        /// </summary>
        /// <param name="fileType"></param>
        /// <param name="type">
        /// Default Value: code
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeChunkGeneratedMetadata(
            string fileType,
            string? type,
            string? language,
            int? wordCount,
            int? fileSize,
            int? startLine,
            int? numLines,
            string? fileExtension)
        {
            this.Type = type;
            this.FileType = fileType ?? throw new global::System.ArgumentNullException(nameof(fileType));
            this.Language = language;
            this.WordCount = wordCount;
            this.FileSize = fileSize;
            this.StartLine = startLine;
            this.NumLines = numLines;
            this.FileExtension = fileExtension;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeChunkGeneratedMetadata" /> class.
        /// </summary>
        public CodeChunkGeneratedMetadata()
        {
        }
    }
}