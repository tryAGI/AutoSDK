//HintName: G.Models.InitFileUploadRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InitFileUploadRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileSizeBytes", Required = global::Newtonsoft.Json.Required.Always)]
        public long FileSizeBytes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InitFileUploadRequest" /> class.
        /// </summary>
        /// <param name="fileSizeBytes"></param>
        public InitFileUploadRequest(
            long fileSizeBytes)
        {
            this.FileSizeBytes = fileSizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitFileUploadRequest" /> class.
        /// </summary>
        public InitFileUploadRequest()
        {
        }
    }
}