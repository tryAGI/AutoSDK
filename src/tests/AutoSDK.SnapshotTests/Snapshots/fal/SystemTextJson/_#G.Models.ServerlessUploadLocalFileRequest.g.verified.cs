//HintName: G.Models.ServerlessUploadLocalFileRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerlessUploadLocalFileRequest
    {
        /// <summary>
        /// Binary file content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_upload")]
        public object? FileUpload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessUploadLocalFileRequest" /> class.
        /// </summary>
        /// <param name="fileUpload">
        /// Binary file content
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerlessUploadLocalFileRequest(
            object? fileUpload)
        {
            this.FileUpload = fileUpload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessUploadLocalFileRequest" /> class.
        /// </summary>
        public ServerlessUploadLocalFileRequest()
        {
        }
    }
}