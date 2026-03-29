//HintName: G.Models.InitFileUploadResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InitFileUploadResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileSizeBytes")]
        public long? FileSizeBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunkSize")]
        public long? ChunkSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InitFileUploadResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fileSizeBytes"></param>
        /// <param name="chunkSize"></param>
        /// <param name="mimeType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InitFileUploadResponse(
            global::System.Guid? id,
            long? fileSizeBytes,
            long? chunkSize,
            string? mimeType)
        {
            this.Id = id;
            this.FileSizeBytes = fileSizeBytes;
            this.ChunkSize = chunkSize;
            this.MimeType = mimeType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitFileUploadResponse" /> class.
        /// </summary>
        public InitFileUploadResponse()
        {
        }
    }
}