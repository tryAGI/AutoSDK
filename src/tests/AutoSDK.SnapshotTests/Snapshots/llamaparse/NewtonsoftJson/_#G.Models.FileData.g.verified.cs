//HintName: G.Models.FileData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for file data with base64 content and MIME type.
    /// </summary>
    public sealed partial class FileData
    {
        /// <summary>
        /// The file content as base64-encoded string
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public string Data { get; set; } = default!;

        /// <summary>
        /// The MIME type of the file (e.g., 'application/pdf', 'text/plain')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mime_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string MimeType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileData" /> class.
        /// </summary>
        /// <param name="data">
        /// The file content as base64-encoded string
        /// </param>
        /// <param name="mimeType">
        /// The MIME type of the file (e.g., 'application/pdf', 'text/plain')
        /// </param>
        public FileData(
            string data,
            string mimeType)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileData" /> class.
        /// </summary>
        public FileData()
        {
        }
    }
}