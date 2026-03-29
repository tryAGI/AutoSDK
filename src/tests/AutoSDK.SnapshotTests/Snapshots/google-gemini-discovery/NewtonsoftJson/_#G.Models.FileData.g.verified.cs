//HintName: G.Models.FileData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// URI based data.
    /// </summary>
    public sealed partial class FileData
    {
        /// <summary>
        /// Optional. The IANA standard MIME type of the source data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Required. URI.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileUri")]
        public string? FileUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileData" /> class.
        /// </summary>
        /// <param name="mimeType">
        /// Optional. The IANA standard MIME type of the source data.
        /// </param>
        /// <param name="fileUri">
        /// Required. URI.
        /// </param>
        public FileData(
            string? mimeType,
            string? fileUri)
        {
            this.MimeType = mimeType;
            this.FileUri = fileUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileData" /> class.
        /// </summary>
        public FileData()
        {
        }
    }
}