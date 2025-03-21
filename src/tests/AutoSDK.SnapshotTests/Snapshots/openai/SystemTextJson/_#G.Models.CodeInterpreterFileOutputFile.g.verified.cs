//HintName: G.Models.CodeInterpreterFileOutputFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeInterpreterFileOutputFile
    {
        /// <summary>
        /// The ID of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// The MIME type of the file.
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
        /// Initializes a new instance of the <see cref="CodeInterpreterFileOutputFile" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file.
        /// </param>
        /// <param name="mimeType">
        /// The MIME type of the file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeInterpreterFileOutputFile(
            string fileId,
            string mimeType)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterFileOutputFile" /> class.
        /// </summary>
        public CodeInterpreterFileOutputFile()
        {
        }
    }
}