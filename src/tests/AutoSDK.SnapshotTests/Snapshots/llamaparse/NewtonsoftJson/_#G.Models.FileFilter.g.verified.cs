//HintName: G.Models.FileFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filter parameters for file queries.
    /// </summary>
    public sealed partial class FileFilter
    {
        /// <summary>
        /// Filter by project ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Filter by specific file IDs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? FileIds { get; set; }

        /// <summary>
        /// Filter by file name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_name")]
        public string? FileName { get; set; }

        /// <summary>
        /// Filter by data source ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_source_id")]
        public global::System.Guid? DataSourceId { get; set; }

        /// <summary>
        /// Filter by external file ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_file_id")]
        public string? ExternalFileId { get; set; }

        /// <summary>
        /// Filter only manually uploaded files (data_source_id is null)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("only_manually_uploaded")]
        public bool? OnlyManuallyUploaded { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileFilter" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Filter by project ID
        /// </param>
        /// <param name="fileIds">
        /// Filter by specific file IDs
        /// </param>
        /// <param name="fileName">
        /// Filter by file name
        /// </param>
        /// <param name="dataSourceId">
        /// Filter by data source ID
        /// </param>
        /// <param name="externalFileId">
        /// Filter by external file ID
        /// </param>
        /// <param name="onlyManuallyUploaded">
        /// Filter only manually uploaded files (data_source_id is null)
        /// </param>
        public FileFilter(
            global::System.Guid? projectId,
            global::System.Collections.Generic.IList<global::System.Guid>? fileIds,
            string? fileName,
            global::System.Guid? dataSourceId,
            string? externalFileId,
            bool? onlyManuallyUploaded)
        {
            this.ProjectId = projectId;
            this.FileIds = fileIds;
            this.FileName = fileName;
            this.DataSourceId = dataSourceId;
            this.ExternalFileId = externalFileId;
            this.OnlyManuallyUploaded = onlyManuallyUploaded;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileFilter" /> class.
        /// </summary>
        public FileFilter()
        {
        }
    }
}