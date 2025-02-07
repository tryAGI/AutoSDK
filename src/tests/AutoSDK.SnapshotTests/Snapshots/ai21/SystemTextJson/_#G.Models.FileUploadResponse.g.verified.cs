//HintName: G.Models.FileUploadResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileUploadResponse
    {
        /// <summary>
        /// A unique ID for the request (not the message). Repeated identical requests<br/>
        /// get different IDs. However, for a streaming response, the ID will be the same<br/>
        /// for all responses in the stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A unique identifier for the uploaded file. Use this later to request, modify metadata,<br/>
        /// or delete the file. You don't need to store the value though, as it is returned<br/>
        /// along with all file information in any file GET request. Example: da13301a-14e4-4487-aa2f-cc6048e73cdc
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileUploadResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique ID for the request (not the message). Repeated identical requests<br/>
        /// get different IDs. However, for a streaming response, the ID will be the same<br/>
        /// for all responses in the stream.
        /// </param>
        /// <param name="fileId">
        /// A unique identifier for the uploaded file. Use this later to request, modify metadata,<br/>
        /// or delete the file. You don't need to store the value though, as it is returned<br/>
        /// along with all file information in any file GET request. Example: da13301a-14e4-4487-aa2f-cc6048e73cdc
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileUploadResponse(
            string id,
            string fileId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileUploadResponse" /> class.
        /// </summary>
        public FileUploadResponse()
        {
        }
    }
}