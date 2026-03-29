//HintName: G.Models.PDFChunkGeneratedMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PDFChunkGeneratedMetadata
    {
        /// <summary>
        /// Default Value: pdf
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Default Value: application/pdf
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_type")]
        public string? FileType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_pages")]
        public int? TotalPages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_size")]
        public int? TotalSize { get; set; }

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
        /// Initializes a new instance of the <see cref="PDFChunkGeneratedMetadata" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: pdf
        /// </param>
        /// <param name="fileType">
        /// Default Value: application/pdf
        /// </param>
        /// <param name="totalPages"></param>
        /// <param name="totalSize"></param>
        /// <param name="fileExtension"></param>
        public PDFChunkGeneratedMetadata(
            string? type,
            string? fileType,
            int? totalPages,
            int? totalSize,
            string? fileExtension)
        {
            this.Type = type;
            this.FileType = fileType;
            this.TotalPages = totalPages;
            this.TotalSize = totalSize;
            this.FileExtension = fileExtension;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PDFChunkGeneratedMetadata" /> class.
        /// </summary>
        public PDFChunkGeneratedMetadata()
        {
        }
    }
}