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
        [global::Newtonsoft.Json.JsonProperty("file_upload")]
        public object? FileUpload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessUploadLocalFileRequest" /> class.
        /// </summary>
        /// <param name="fileUpload">
        /// Binary file content
        /// </param>
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