//HintName: G.Models.OrganizationSourcesStats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Complete metadata response for organization sources
    /// </summary>
    public sealed partial class OrganizationSourcesStats
    {
        /// <summary>
        /// Total number of sources<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_sources")]
        public int? TotalSources { get; set; }

        /// <summary>
        /// Total number of files across all sources<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_files")]
        public int? TotalFiles { get; set; }

        /// <summary>
        /// Total size of all files in bytes<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_size")]
        public long? TotalSize { get; set; }

        /// <summary>
        /// List of source metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::G.SourceStats>? Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationSourcesStats" /> class.
        /// </summary>
        /// <param name="totalSources">
        /// Total number of sources<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="totalFiles">
        /// Total number of files across all sources<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="totalSize">
        /// Total size of all files in bytes<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="sources">
        /// List of source metadata
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationSourcesStats(
            int? totalSources,
            int? totalFiles,
            long? totalSize,
            global::System.Collections.Generic.IList<global::G.SourceStats>? sources)
        {
            this.TotalSources = totalSources;
            this.TotalFiles = totalFiles;
            this.TotalSize = totalSize;
            this.Sources = sources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationSourcesStats" /> class.
        /// </summary>
        public OrganizationSourcesStats()
        {
        }
    }
}