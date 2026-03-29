//HintName: G.Models.FileStats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File statistics for metadata endpoint
    /// </summary>
    public sealed partial class FileStats
    {
        /// <summary>
        /// Unique identifier of the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// Name of the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileName { get; set; } = default!;

        /// <summary>
        /// Size of the file in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_size")]
        public long? FileSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileStats" /> class.
        /// </summary>
        /// <param name="fileId">
        /// Unique identifier of the file
        /// </param>
        /// <param name="fileName">
        /// Name of the file
        /// </param>
        /// <param name="fileSize">
        /// Size of the file in bytes
        /// </param>
        public FileStats(
            string fileId,
            string fileName,
            long? fileSize)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.FileSize = fileSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileStats" /> class.
        /// </summary>
        public FileStats()
        {
        }
    }
}