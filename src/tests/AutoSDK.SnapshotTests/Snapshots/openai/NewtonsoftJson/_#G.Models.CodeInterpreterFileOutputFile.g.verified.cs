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
        /// The MIME type of the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mime_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string MimeType { get; set; } = default!;

        /// <summary>
        /// The ID of the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterFileOutputFile" /> class.
        /// </summary>
        /// <param name="mimeType">
        /// The MIME type of the file.
        /// </param>
        /// <param name="fileId">
        /// The ID of the file.
        /// </param>
        public CodeInterpreterFileOutputFile(
            string mimeType,
            string fileId)
        {
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterFileOutputFile" /> class.
        /// </summary>
        public CodeInterpreterFileOutputFile()
        {
        }
    }
}