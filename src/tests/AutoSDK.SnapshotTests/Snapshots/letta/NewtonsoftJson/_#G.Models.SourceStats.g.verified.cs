//HintName: G.Models.SourceStats.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Aggregated metadata for a source
    /// </summary>
    public sealed partial class SourceStats
    {
        /// <summary>
        /// Deprecated: Use `folder_id` field instead. Unique identifier of the source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceId { get; set; } = default!;

        /// <summary>
        /// Deprecated: Use `folder_name` field instead. Name of the source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceName { get; set; } = default!;

        /// <summary>
        /// Number of files in the source<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_count")]
        public int? FileCount { get; set; }

        /// <summary>
        /// Total size of all files in bytes<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_size")]
        public long? TotalSize { get; set; }

        /// <summary>
        /// List of file statistics
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files")]
        public global::System.Collections.Generic.IList<global::G.FileStats>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceStats" /> class.
        /// </summary>
        /// <param name="sourceId">
        /// Deprecated: Use `folder_id` field instead. Unique identifier of the source
        /// </param>
        /// <param name="sourceName">
        /// Deprecated: Use `folder_name` field instead. Name of the source
        /// </param>
        /// <param name="fileCount">
        /// Number of files in the source<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="totalSize">
        /// Total size of all files in bytes<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="files">
        /// List of file statistics
        /// </param>
        public SourceStats(
            string sourceId,
            string sourceName,
            int? fileCount,
            long? totalSize,
            global::System.Collections.Generic.IList<global::G.FileStats>? files)
        {
            this.SourceId = sourceId ?? throw new global::System.ArgumentNullException(nameof(sourceId));
            this.SourceName = sourceName ?? throw new global::System.ArgumentNullException(nameof(sourceName));
            this.FileCount = fileCount;
            this.TotalSize = totalSize;
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceStats" /> class.
        /// </summary>
        public SourceStats()
        {
        }
    }
}