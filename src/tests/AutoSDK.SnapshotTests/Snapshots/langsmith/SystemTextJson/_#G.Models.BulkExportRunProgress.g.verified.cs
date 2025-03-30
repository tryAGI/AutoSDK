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
        [global::System.Text.Json.Serialization.JsonPropertyName("rows_written")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RowsWritten { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exported_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ExportedFiles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExportPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_cursor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? LatestCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportRunProgress" /> class.
        /// </summary>
        /// <param name="rowsWritten"></param>
        /// <param name="exportedFiles"></param>
        /// <param name="exportPath"></param>
        /// <param name="latestCursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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