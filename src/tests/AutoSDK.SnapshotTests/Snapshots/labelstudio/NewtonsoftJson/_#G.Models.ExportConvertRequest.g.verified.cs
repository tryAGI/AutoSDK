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
        [global::Newtonsoft.Json.JsonProperty("download_resources")]
        public bool? DownloadResources { get; set; }

        /// <summary>
        /// Export file format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("export_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExportType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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