//HintName: G.Models.Blob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Raw media bytes. Text should not be sent as raw bytes, use the 'text' field.
    /// </summary>
    public sealed partial class Blob
    {
        /// <summary>
        /// The IANA standard MIME type of the source data. Examples: - image/png - image/jpeg If an unsupported MIME type is provided, an error will be returned. For a complete list of supported types, see [Supported file formats](https://ai.google.dev/gemini-api/docs/prompting_with_media#supported_file_formats).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Raw bytes for media formats.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public byte[]? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Blob" /> class.
        /// </summary>
        /// <param name="mimeType">
        /// The IANA standard MIME type of the source data. Examples: - image/png - image/jpeg If an unsupported MIME type is provided, an error will be returned. For a complete list of supported types, see [Supported file formats](https://ai.google.dev/gemini-api/docs/prompting_with_media#supported_file_formats).
        /// </param>
        /// <param name="data">
        /// Raw bytes for media formats.
        /// </param>
        public Blob(
            string? mimeType,
            byte[]? data)
        {
            this.MimeType = mimeType;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Blob" /> class.
        /// </summary>
        public Blob()
        {
        }
    }
}