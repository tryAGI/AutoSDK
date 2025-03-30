//HintName: G.Models.BulkExportRunProgress.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkExportRunProgress
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rows_written", Required = global::Newtonsoft.Json.Required.Always)]
        public int RowsWritten { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exported_files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> ExportedFiles { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("export_path", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExportPath { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latest_cursor", Required = global::Newtonsoft.Json.Required.Always)]
        public string? LatestCursor { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportRunProgress" /> class.
        /// </summary>
        /// <param name="rowsWritten"></param>
        /// <param name="exportedFiles"></param>
        /// <param name="exportPath"></param>
        /// <param name="latestCursor"></param>
        public BulkExportRunProgress(
            int rowsWritten,
            global::System.Collections.Generic.IList<string> exportedFiles,
            string exportPath,
            string? latestCursor)
        {
            this.RowsWritten = rowsWritten;
            this.ExportedFiles = exportedFiles ?? throw new global::System.ArgumentNullException(nameof(exportedFiles));
            this.ExportPath = exportPath ?? throw new global::System.ArgumentNullException(nameof(exportPath));
            this.LatestCursor = latestCursor ?? throw new global::System.ArgumentNullException(nameof(latestCursor));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportRunProgress" /> class.
        /// </summary>
        public BulkExportRunProgress()
        {
        }
    }
}