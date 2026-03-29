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
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// The MIME type of the file (e.g., 'application/pdf', 'text/plain')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MimeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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