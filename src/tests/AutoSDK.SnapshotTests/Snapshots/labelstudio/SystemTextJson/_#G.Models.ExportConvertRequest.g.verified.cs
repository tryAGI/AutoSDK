//HintName: G.Models.ExportConvertRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExportConvertRequest
    {
        /// <summary>
        /// Download resources in converter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_resources")]
        public bool? DownloadResources { get; set; }

        /// <summary>
        /// Export file format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExportType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportConvertRequest" /> class.
        /// </summary>
        /// <param name="exportType">
        /// Export file format.
        /// </param>
        /// <param name="downloadResources">
        /// Download resources in converter.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExportConvertRequest(
            string exportType,
            bool? downloadResources)
        {
            this.DownloadResources = downloadResources;
            this.ExportType = exportType ?? throw new global::System.ArgumentNullException(nameof(exportType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportConvertRequest" /> class.
        /// </summary>
        public ExportConvertRequest()
        {
        }
    }
}